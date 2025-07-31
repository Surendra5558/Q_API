using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for managing clients, including retrieval, creation, update, and deletion.
/// </summary>
public class ClientBusiness(ILogger<ClientBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork)
    : IClientBusiness
{
    private const string ClassName = nameof(ClientBusiness);

    /// <summary>
    /// Retrieves a queryable collection of all clients, including related details and status.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{ClientViewModel}"/>
    /// representing all clients.
    /// </returns>
    public async Task<IQueryable<ClientViewModel>> GetAsync()
    {
        try
        {
            logger.LogInformation("{ClassName} - GetAsync started", ClassName);

            var result = from c in await unitOfWork.Clients.GetAsync()
                         join ce in await unitOfWork.ClientExtensions.GetAsync() on c.Id equals ce.ClientId into ceGroup
                         from ce in ceGroup.DefaultIfEmpty()
                         join uc in await unitOfWork.Users.GetAsync() on c.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on c.ModifiedBy equals um.Id
                         orderby c.ModifiedOn descending
                         select new ClientViewModel
                         {
                             Id = c.Id,
                             Name = c.Name,
                             LegalName = ce.LegalName,
                             Address = ce.Address,
                             PhoneNumber = ce.PhoneNumber,
                             ContactPerson = ce.ContactPerson,
                             ContactPersonEmail = ce.ContactPersonEmail,
                             ContactPersonPhone = ce.ContactPersonPhone,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = c.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = c.ModifiedOn
                         };

            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in GetAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - GetAsync completed", ClassName);
        }
    }

    /// <summary>
    /// Retrieves a client by its unique identifier, including related details and status.
    /// </summary>
    /// <param name="id">The unique identifier of the client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the <see cref="ClientViewModel"/> if found; otherwise, <c>null</c>.
    /// </returns>
    /// <exception cref="KeyNotFoundException">Thrown if the client with the specified ID is not found.</exception>
    public async Task<ClientViewModel?> GetByIdAsync(long id)
    {
        try
        {
            logger.LogInformation("{ClassName} - GetByIdAsync started", ClassName);

            var domain = await unitOfWork.Clients.GetByIdAsync(id);

            if (domain == null)
            {
                logger.LogError("{ClassName} - Client with Id {Id} not found", ClassName, id);
                throw new KeyNotFoundException($"Client with Id {id} not found.");
            }

            var ce = (await unitOfWork.ClientExtensions.GetAsync()).FirstOrDefault(x => x.ClientId == domain.Id);
            var uc = await unitOfWork.Users.GetByIdAsync(domain.CreatedBy);
            var um = await unitOfWork.Users.GetByIdAsync(domain.ModifiedBy);

            var result = new ClientViewModel
            {
                Id = domain.Id,
                Name = domain.Name,
                LegalName = ce?.LegalName,
                Address = ce?.Address,
                PhoneNumber = ce?.PhoneNumber,
                ContactPerson = ce?.ContactPerson,
                ContactPersonEmail = ce?.ContactPersonEmail,
                ContactPersonPhone = ce?.ContactPersonPhone,
                CreatedBy = string.Concat(uc?.FirstName, " ", uc?.LastName),
                CreatedOn = domain.CreatedOn,
                ModifiedBy = string.Concat(um?.FirstName, " ", um?.LastName),
                ModifiedOn = domain.ModifiedOn
            };

            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in GetByIdAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - GetByIdAsync completed", ClassName);
        }
    }

    /// <summary>
    /// Creates a new client using the provided model.
    /// </summary>
    /// <param name="model">The model containing data for the new client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    /// <exception cref="InvalidOperationException">Thrown if a client with the same name already exists.</exception>
    public async Task<int> CreateAsync(ClientCreateModel model)
    {
        try
        {
            logger.LogInformation("{ClassName} - CreateAsync started", ClassName);

            var result = (await unitOfWork.Clients.GetAsync()).FirstOrDefault(x => x.Name == model.Name);
            if (result != null)
            {
                logger.LogError("{ClassName} - Client with Name {Name} already exists", ClassName, model.Name);
                throw new InvalidOperationException($"Client with Name {model.Name} already exists.");
            }

            var modifiedCount = 0;

            await unitOfWork.ExecuteAsync(async () =>
            {

                var domain = new Client
                {
                    Name = model.Name
                };
                userContext.SetDomainDefaults(domain, DataModes.Add);
                await unitOfWork.Clients.AddAsync(domain);
                modifiedCount = await unitOfWork.SaveChangesAsync();

                var clientExtensionDomain = new ClientExtension
                {
                    ClientId = domain.Id,
                    LegalName = model.LegalName,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    ContactPerson = model.ContactPerson,
                    ContactPersonEmail = model.ContactPersonEmail,
                    ContactPersonPhone = model.ContactPersonPhone,
                    NumberOfLocations = model.NumberOfLocations,
                    NumberOfEmployees = model.NumberOfEmployees,
                    NumberOfSuppliers = model.NumberOfSuppliers,
                    NumberOfExternalPartners = model.NumberOfExternalPartners
                };

                await unitOfWork.ClientExtensions.AddAsync(clientExtensionDomain);
                modifiedCount += await unitOfWork.SaveChangesAsync();
            });

            return modifiedCount;

        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in CreateAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - CreateAsync completed", ClassName);
        }
    }

    /// <summary>
    /// Updates an existing client using the provided model.
    /// </summary>
    /// <param name="model">The model containing updated data for the client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    /// <exception cref="KeyNotFoundException">Thrown if the client with the specified ID is not found.</exception>
    /// <exception cref="InvalidOperationException">Thrown if a client with the same name already exists.</exception>
    public async Task<int> UpdateAsync(ClientUpdateModel model)
    {
        try
        {
            logger.LogInformation("{ClassName} - UpdateAsync started", ClassName);

            var domain = await unitOfWork.Clients.GetByIdAsync(model.Id);

            if (domain == null)
            {
                logger.LogError("{ClassName} - Client with Id {Id} not found", ClassName, model.Id);
                throw new KeyNotFoundException($"Client with Id {model.Id} not found.");
            }

            var existingClient = (await unitOfWork.Clients.GetAsync()).FirstOrDefault(x => x.Name == model.Name && x.Id != model.Id);

            if (existingClient != null)
            {
                logger.LogError("{ClassName} - Client with Name {Name} already exists", ClassName, model.Name);
                throw new InvalidOperationException($"Client with Name {model.Name} already exists.");
            }

            var domainClientExt =
                (await unitOfWork.ClientExtensions.GetAsync()).FirstOrDefault(x => x.ClientId == model.Id);

            var isAdd = false;

            if (domainClientExt == null)
            {
                isAdd = true;
                domainClientExt = new ClientExtension
                {
                    ClientId = model.Id
                };
            }

            var modifiedCount = 0;
            await unitOfWork.ExecuteAsync(async () =>
            {

                domain.Name = model.Name;

                domainClientExt.LegalName = model.LegalName;
                domainClientExt.Address = model.Address;
                domainClientExt.PhoneNumber = model.PhoneNumber;
                domainClientExt.ContactPerson = model.ContactPerson;
                domainClientExt.ContactPersonEmail = model.ContactPersonEmail;
                domainClientExt.ContactPersonPhone = model.ContactPersonPhone;

                userContext.SetDomainDefaults(domain, DataModes.Edit);
                userContext.SetDomainDefaults(domainClientExt, DataModes.Edit);

                await unitOfWork.Clients.UpdateAsync(model.Id, domain);

                if (isAdd)
                {
                    await unitOfWork.ClientExtensions.AddAsync(domainClientExt);
                }
                else
                {
                    await unitOfWork.ClientExtensions.UpdateAsync(domainClientExt.Id, domainClientExt);
                }

                modifiedCount = await unitOfWork.SaveChangesAsync();
            });
            return modifiedCount;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in UpdateAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - UpdateAsync completed", ClassName);
        }
    }

    /// <summary>
    /// Deletes a client by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client to delete.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    /// <exception cref="KeyNotFoundException">Thrown if the client with the specified ID is not found.</exception>
    public async Task<int> DeleteAsync(long id)
    {
        try
        {
            logger.LogInformation("{ClassName} - DeleteAsync started", ClassName);

            var domain = await unitOfWork.Clients.GetByIdAsync(id);

            if (domain == null)
            {
                logger.LogError("{ClassName} - Client with Id {Id} not found", ClassName, id);
                throw new KeyNotFoundException($"Client with Id {id} not found.");
            }

            userContext.SetDomainDefaults(domain, DataModes.Delete);
            await unitOfWork.Clients.UpdateAsync(domain.Id, domain);
            var modifiedCount = await unitOfWork.SaveChangesAsync();

            return modifiedCount;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in DeleteAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - DeleteAsync completed", ClassName);
        }
    }
}