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
/// Provides business operations for managing users, including retrieval, creation, update, and deletion.
/// </summary>
public class UserBusiness(ILogger<UserBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork)
    : IUserBusiness
{
    private const string ClassName = nameof(UserBusiness);

    /// <summary>
    /// Asynchronously retrieves all users as a queryable collection of view models.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{UserViewModel}"/>
    /// representing all users.
    /// </returns>
    public async Task<IQueryable<UserViewModel>> GetAsync()
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(GetAsync));

            var users = from u in await unitOfWork.Users.GetAsync()
                        join c in await unitOfWork.Clients.GetAsync() on u.ClientId equals c.Id
                        join r in await unitOfWork.RoleTypes.GetAsync() on u.RoleId equals r.Id
                        join uc in await unitOfWork.Users.GetAsync() on u.CreatedBy equals uc.Id
                        join um in await unitOfWork.Users.GetAsync() on u.ModifiedBy equals um.Id
                        orderby u.ModifiedOn descending
                        select new UserViewModel
                        {
                            Id = u.Id,
                            Email = u.UserName,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            ClientId = c.Id,
                            ClientName = c.Name,
                            RoleId = r.Id,
                            RoleName = r.Name,
                            CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                            CreatedOn = u.CreatedOn,
                            ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                            ModifiedOn = u.ModifiedOn
                        };

            return users;
        }
        catch (Exception e)
        {
            logger.LogError("{ClassName} - {MethodName} - Exception: {ExceptionMessage}", ClassName, nameof(GetAsync), e.Message);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - {MethodName} - End", ClassName, nameof(GetAsync));
        }
    }

    /// <summary>
    /// Asynchronously retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="UserViewModel"/>
    /// with the user's details.
    /// </returns>
    public async Task<UserViewModel> GetByIdAsync(long id)
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(GetByIdAsync));

            var domain = await unitOfWork.Users.GetByIdAsync(id);
            if (domain == null)
            {
                logger.LogError("{ClassName} - {MethodName} - User not found for ID: {UserId}", ClassName, nameof(GetByIdAsync), id);
                throw new ArgumentException($"User with ID {id} does not exist.");
            }

            var client = await unitOfWork.Clients.GetByIdAsync(domain.ClientId);
            var role = await unitOfWork.RoleTypes.GetByIdAsync(domain.RoleId);
            var uc = await unitOfWork.Users.GetByIdAsync(domain.CreatedBy);
            var um = await unitOfWork.Users.GetByIdAsync(domain.ModifiedBy);

            var userViewModel = new UserViewModel
            {
                Id = domain.Id,
                Email = domain.UserName,
                ClientId = domain.ClientId,
                ClientName = client?.Name ?? string.Empty,
                RoleId = domain.RoleId,
                RoleName = role?.Name ?? string.Empty,
                FirstName = domain.FirstName,
                LastName = domain.LastName,
                PhoneNumber = domain.PhoneNumber,
                Address = domain.Address,
                CreatedBy = string.Concat(uc?.FirstName, " ", uc?.LastName),
                CreatedOn = domain.CreatedOn,
                ModifiedBy = string.Concat(um?.FirstName, " ", um?.LastName),
                ModifiedOn = domain.ModifiedOn
            };

            return userViewModel;
        }
        catch (Exception e)
        {
            logger.LogError("{ClassName} - {MethodName} - Exception: {ExceptionMessage}", ClassName, nameof(GetByIdAsync), e.Message);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - {MethodName} - End", ClassName, nameof(GetByIdAsync));
        }
    }

    /// <summary>
    /// Asynchronously creates a new user with the specified information.
    /// </summary>
    /// <param name="model">The model containing the user's creation details.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public async Task<int> CreateAsync(UserCreateModel model)
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(CreateAsync));

            var user = (await unitOfWork.Users.GetAsync()).FirstOrDefault(x => x.UserName == model.Email);

            if (user != null)
            {
                logger.LogError("{ClassName} - {MethodName} - User already exists with Email: {Email}", ClassName, nameof(CreateAsync), model.Email);
                throw new ArgumentException($"User with Email {model.Email} already exists.");
            }

            var client = await unitOfWork.Clients.GetByIdAsync(model.ClientId);
            if (client == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client not found for ID: {ClientId}", ClassName, nameof(CreateAsync), model.ClientId);
                throw new ArgumentException($"Client with ID {model.ClientId} does not exist.");
            }

            var role = await unitOfWork.RoleTypes.GetByIdAsync(model.RoleId);
            if (role == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Role not found for ID: {RoleId}", ClassName, nameof(CreateAsync), model.RoleId);
                throw new ArgumentException($"Role with ID {model.RoleId} does not exist.");
            }

            var domain = new User
            {
                UserName = model.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password, workFactor: 12),
                ClientId = model.ClientId,
                RoleId = model.RoleId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
            };
            userContext.SetDomainDefaults(domain, DataModes.Add);
            await unitOfWork.Users.AddAsync(domain);
            var result = await unitOfWork.SaveChangesAsync();

            return result;
        }
        catch (Exception e)
        {
            logger.LogError("{ClassName} - {MethodName} - Exception: {ExceptionMessage}", ClassName, nameof(CreateAsync), e.Message);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - {MethodName} - End", ClassName, nameof(CreateAsync));
        }
    }

    /// <summary>
    /// Asynchronously updates an existing user.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public Task<int> UpdateAsync()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Asynchronously deletes a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }
}