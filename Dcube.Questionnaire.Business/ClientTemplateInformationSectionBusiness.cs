using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for retrieving additional sections associated with a client template.
/// </summary>
public class ClientTemplateInformationSectionBusiness(ILogger<ClientBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork)
    : IClientTemplateInformationSectionBusiness
{
    private const string ClassName = nameof(ClientTemplateInformationSectionBusiness);

    /// <summary>
    /// Retrieves all additional sections for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientTemplateInfromationSectionViewModel"/> representing the additional sections for the client template.
    /// </returns>
    public async Task<IQueryable<ClientTemplateInfromationSectionViewModel>> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("{ClassName} - GetAsync started", ClassName);

            var result = from ct in await unitOfWork.ClientTemplateInformationSections.GetAsync()
                         join isc in await unitOfWork.InformationSections.GetAsync() on ct.InformationSectionId equals isc.Id
                         join uc in await unitOfWork.Users.GetAsync() on ct.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on ct.ModifiedBy equals um.Id
                         orderby isc.OrderBy
                         where ct.ClientTemplateId == clientTemplateId
                         select new ClientTemplateInfromationSectionViewModel
                         {
                             Id = ct.Id,
                             InformationSectionId = isc.Id,
                             Name = isc.Name,
                             Description = isc.Description,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = ct.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = ct.ModifiedOn
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
}