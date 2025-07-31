using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for managing solutions or resolutions for client template sections.
/// </summary>
public class ClientTemplateSectionSolutionBusiness(ILogger<ClientTemplateSectionSolutionBusiness> logger,
    IUserContext userContext, IUnitOfWork unitOfWork)
    : IClientTemplateSectionSolutionBusiness
{
    private const string ClassName = nameof(ClientTemplateSectionSolutionBusiness);

    /// <summary>
    /// Retrieves all solution or resolution details for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientTemplateSectionSolutionViewModel"/> representing the solutions for the client template sections.
    /// </returns>
    public async Task<IQueryable<ClientTemplateSectionSolutionViewModel>> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("{ClassName} - GetAsync started", ClassName);

            var result = from ctss in await unitOfWork.ClientTemplateSectionSolutions.GetAsync()
                         join cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync() on ctss.ClientTemplateSectionId
                             equals cts.Id
                         join ts in await unitOfWork.TemplateSections.GetAsync() on cts.TemplateSectionId equals ts.Id
                         where cts.ClientTemplateId == clientTemplateId
                         orderby ts.OrderBy
                         select new ClientTemplateSectionSolutionViewModel
                         {
                             Id = ctss.Id,
                             TemplateSectionId = ts.Id,
                             TemplateSectionName = ts.Name,
                             Score = cts.Score,
                             Percentage = cts.Percentage,
                             Variance = ctss.Variance,
                             Resolution = ctss.Resolution
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
    /// Creates new solutions or resolutions for client template sections using the provided models.
    /// </summary>
    /// <param name="models">A list of models containing data required to create solutions for client template sections.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the number of domain entities does not match the number of models, or if a model is not found for a given entity.
    /// </exception>
    public async Task<int> SaveAsync(List<ClientTemplateSectionSolutionSaveModel> models)
    {
        try
        {
            logger.LogInformation("{ClassName} - CreateAsync started", ClassName);

            var modelIds = models.Select(m => m.Id).ToList();
            var domainClientTemplateSectionSolutions = (await unitOfWork.ClientTemplateSectionSolutions.GetAsync())
                .Where(x => modelIds.Contains(x.Id))
                .ToList();

            if (domainClientTemplateSectionSolutions.Count == 0 &&
                domainClientTemplateSectionSolutions.Count! == modelIds.Count)
            {
                logger.LogError("{ClassName} - Counts missmatch", ClassName);
                throw new InvalidOperationException($"Counts missmatch");
            }

            foreach (var domainClientTemplateSectionSolution in domainClientTemplateSectionSolutions)
            {
                var modelInfo = models.FirstOrDefault(x => x.Id == domainClientTemplateSectionSolution.Id);
                if (modelInfo == null)
                {
                    logger.LogError("{ClassName} - Model not found for Id: {Id}", ClassName,
                        domainClientTemplateSectionSolution.Id);
                    throw new InvalidOperationException(
                        $"Model not found for Id: {domainClientTemplateSectionSolution.Id}");
                }

                domainClientTemplateSectionSolution.Variance = modelInfo.Variance;
                domainClientTemplateSectionSolution.Resolution = modelInfo.Resolution;
            }

            userContext.SetDomainDefaults(domainClientTemplateSectionSolutions, DataModes.Add);

            await unitOfWork.ClientTemplateSectionSolutions.UpdateRangeAsync(domainClientTemplateSectionSolutions);
            var saved = await unitOfWork.SaveChangesAsync();
            return saved;
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
}