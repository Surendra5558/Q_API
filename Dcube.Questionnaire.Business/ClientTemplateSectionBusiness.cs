using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for retrieving client template section information.
/// </summary>
public class ClientTemplateSectionBusiness(ILogger<ClientTemplateSectionBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork)
    : IClientTemplateSectionBusiness
{
    private const string ClassName = nameof(ClientTemplateSectionBusiness);

    /// <summary>
    /// Asynchronously retrieves the collection of section view models for a given client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{ClientTemplateSectionViewModel}"/>
    /// representing the sections associated with the specified client template.
    /// </returns>
    public async Task<IQueryable<ClientTemplateSectionViewModel>> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(GetAsync));

            var domain = from cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync()
                         join ts in await unitOfWork.TemplateSections.GetAsync() on cts.TemplateSectionId equals ts.Id
                         join tsp in await unitOfWork.TemplateSections.GetAsync() on ts.ParentSectionId equals tsp.Id into tspGroup
                         from tsp in tspGroup.DefaultIfEmpty() // Ensure parent section is either null or active
                         join s in await unitOfWork.QuestionnaireStatusTypes.GetAsync() on cts.StatusId equals s.Id
                         join uc in await unitOfWork.Users.GetAsync() on cts.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on cts.ModifiedBy equals um.Id
                         orderby ts.OrderBy ascending
                         where cts.ClientTemplateId == clientTemplateId
                         select new ClientTemplateSectionViewModel
                         {
                             Id = cts.Id,
                             TemplateSectionId = ts.Id,
                             TemplateSectionName = ts.Name,
                             TemplateSectionDescription = ts.Description,
                             ParentTemplateSectionId = tsp != null ? tsp.Id : null,
                             ParentTemplateSectionName = tsp != null ? tsp.Name : null,
                             ParentTemplateSectionNDescription = tsp != null ? tsp.Description : null,
                             Percentage = cts.Percentage,
                             Score = cts.Score,
                             StatusId = s.Id,
                             StatusName = s.Name,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = cts.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = cts.ModifiedOn
                         };

            return domain;
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
}