using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for handling client questionnaire responses section-wise,
/// including retrieval and saving of section-wise responses.
/// </summary>
public class ClientQuestionnaireResponseSectionWiseBusiness(ILogger<ClientQuestionnaireResponseSectionWiseBusiness> logger,
    IUserContext userContext, IUnitOfWork unitOfWork)
    : IClientQuestionnaireResponseSectionWiseBusiness
{
    private const string ClassName = nameof(ClientQuestionnaireResponseSectionWiseBusiness);

    /// <summary>
    /// Retrieves the section-wise client questionnaire response view model for the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client questionnaire section response.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="ClientQuestionnaireResponseSectionWiseViewModel"/>
    /// with details about the section and its questionnaire responses.
    /// </returns>
    public async Task<ClientQuestionnaireResponseSectionWiseViewModel> GetAsync(long id)
    {
        try
        {
            logger.LogInformation(
                "{ClassName} - GetAsync method started with clientTemplateSectionId: {ClientTemplateSectionId}",
                ClassName, id);

            var clientTemplateSection =
                await unitOfWork.ClientTemplateSectionResponses.GetByIdAsync(id);
            if (clientTemplateSection == null)
            {
                logger.LogError("{ClassName} - No ClientTemplateSection found for Id: {ClientTemplateSectionId}",
                    ClassName, id);
                throw new KeyNotFoundException(
                    $"No ClientTemplateSection found for Id: {id}");
            }

            var sectionStatus = await unitOfWork.QuestionnaireStatusTypes.GetByIdAsync(clientTemplateSection.StatusId);
            if (sectionStatus == null)
            {
                logger.LogError("{ClassName} - No StatusType found for Id: {StatusId}", ClassName, clientTemplateSection.StatusId);
                throw new KeyNotFoundException($"No StatusType found for Id: {clientTemplateSection.StatusId}");
            }

            var templateSection = await unitOfWork.TemplateSections.GetByIdAsync(clientTemplateSection.TemplateSectionId);
            if (templateSection == null)
            {
                logger.LogError("{ClassName} - No TemplateSection found for Id: {TemplateSectionId}", ClassName, clientTemplateSection.TemplateSectionId);
                throw new KeyNotFoundException($"No TemplateSection found for Id: {clientTemplateSection.TemplateSectionId}");
            }

            var uc = await unitOfWork.Users.GetByIdAsync(clientTemplateSection.CreatedBy);
            var um = await unitOfWork.Users.GetByIdAsync(clientTemplateSection.ModifiedBy);

            var questionnaireResponse = from cqr in await unitOfWork.ClientQuestionnaireResponses.GetAsync()
                                        join q in await unitOfWork.Questionnaires.GetAsync() on cqr.QuestionnaireId equals q.Id
                                        join r in await unitOfWork.RenderTypes.GetAsync() on q.RenderTypeId equals r.Id
                                        where cqr.ClientTemplateSectionResponseId == id
                                        select new QuestionnaireResponse
                                        {
                                            ClientQuestionnaireResponseId = cqr.Id,
                                            QuestionnaireId = q.Id,
                                            Description = q.Description,
                                            RenderTypeId = r.Id,
                                            RenderTypeName = r.Name,
                                            IsMandatory = q.IsMandatory,
                                            Options = q.Options,
                                            SectionDescription = q.Description,
                                            Response = cqr.Response,
                                            Comments = cqr.Comments
                                        };

            var response = new ClientQuestionnaireResponseSectionWiseViewModel
            {
                Id = id,
                ClientQuestionnaireSectionStatusId = sectionStatus.Id,
                ClientQuestionnaireSectionStatusName = sectionStatus.Name,
                SectionId = templateSection.Id,
                SectionName = templateSection.Name,
                SectionDescription = templateSection.Description,
                QuestionnaireResponses = questionnaireResponse.ToList(),
                CreatedBy = string.Concat(uc?.FirstName, " ", uc?.LastName),
                CreatedOn = clientTemplateSection.CreatedOn,
                ModifiedBy = string.Concat(um?.FirstName, " ", um?.LastName),
                ModifiedOn = clientTemplateSection.ModifiedOn
            };

            return response;
        }
        catch (Exception e)
        {
            logger.LogError(e,
                "{ClassName} - An error occurred in GetAsync method with clientTemplateSectionId: {ClientTemplateSectionId}",
                ClassName, id);
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - GetAsync method executed", ClassName);
        }
    }

    /// <summary>
    /// Saves the client questionnaire responses for a specific section.
    /// </summary>
    /// <param name="clientQuestionnaireResponses">The model containing the client template section response ID and the questionnaire responses to save.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public async Task<int> SaveAsync(List<ClientQuestionnaireResponseSaveModel> clientQuestionnaireResponses)
    {
        try
        {
            logger.LogInformation("{ClassName} - SaveSync method started with model: {@Model}", ClassName, clientQuestionnaireResponses);
            if (clientQuestionnaireResponses == null || clientQuestionnaireResponses.Count == 0)
            {
                logger.LogError("{ClassName} - SaveSync method received null model", ClassName);
                throw new ArgumentNullException(nameof(clientQuestionnaireResponses), "Model cannot be null");
            }

            var domainClientQuestionnaireResponses = (await unitOfWork.ClientQuestionnaireResponses.GetAsync())
                .Where(c => clientQuestionnaireResponses.Select(x => x.Id).Contains(c.Id));
            if (domainClientQuestionnaireResponses == null || !domainClientQuestionnaireResponses.Any())
            {
                logger.LogError("{ClassName} - No ClientTemplateSectionResponses found for provided IDs", ClassName);
                throw new KeyNotFoundException("No ClientTemplateSectionResponses found for provided IDs");
            }

            var clientTemplateSection = (await unitOfWork.ClientTemplateSectionResponses.GetAsync()).FirstOrDefault(x =>
                x.Id == domainClientQuestionnaireResponses.First().ClientTemplateSectionResponseId);

            if (clientTemplateSection == null)
            {
                logger.LogError("{ClassName} - No ClientTemplateSection found for provided IDs", ClassName);
                throw new KeyNotFoundException("No ClientTemplateSection found for provided IDs");
            }

            if (domainClientQuestionnaireResponses.Count() != domainClientQuestionnaireResponses.Count(
                    x => x.ClientTemplateSectionResponseId == clientTemplateSection.Id))
            {
                logger.LogError("{ClassName} - Wrong section questions passed", ClassName);
                throw new KeyNotFoundException("Wrong section questions passed");
            }

            var clientTemplate =
                await unitOfWork.ClientTemplates.GetByIdAsync(clientTemplateSection.ClientTemplateId);
            if (clientTemplate == null)
            {
                logger.LogError("{ClassName} - ClientTemplate not found for Id: {ClientTemplateId}", ClassName,
                    clientTemplateSection.Id);
                throw new KeyNotFoundException(
                    $"ClientTemplate not found for Id: {clientTemplateSection.Id}");
            }

            if (clientTemplate.StatusId == 3)
            {
                logger.LogError("{ClassName} - ClientTemplate not found or is inactive for Id: {ClientTemplateId}",
                    ClassName, clientTemplateSection.Id);
                throw new KeyNotFoundException(
                    $"ClientTemplate not found or is inactive for Id: {clientTemplateSection.Id}");
            }

            var domainClientQuestionnaireResponsesList = domainClientQuestionnaireResponses.ToList();

            // Replace the problematic code block with the following:

            var weight = (await unitOfWork.QuestionResponseWeightageTypes.GetAsync())
                .ToDictionary(x => x.Name.ToLower(), x => x.Weight);

            domainClientQuestionnaireResponsesList.ForEach(c =>
           {
               c.Response = clientQuestionnaireResponses.FirstOrDefault(x => x.Id == c.Id)?.Response;
               c.Comments = clientQuestionnaireResponses.FirstOrDefault(x => x.Id == c.Id)?.Comments;
               switch (c.Response?.ToLower())
               {
                   case "yes":
                       c.Score = weight["yes"];
                       break;
                   case "inprogress":
                       c.Score = weight["inprogress"];
                       break;
                   case "no":
                       c.Score = weight["no"];
                       break;
                   default:
                       c.Score = weight["na"];
                       break;
               }
               userContext.SetDomainDefaults(c, DataModes.Edit);
           });

            await unitOfWork.ClientQuestionnaireResponses.UpdateRangeAsync(domainClientQuestionnaireResponsesList);

            var clientTemplateCal = (from cqr in (await unitOfWork.ClientQuestionnaireResponses.GetAsync())
                    .Where(x => x.ClientTemplateSectionResponseId == clientTemplateSection.Id).ToList()
                                     join dcq in domainClientQuestionnaireResponsesList on cqr.Id equals dcq.Id
                                         into dcqGroup
                                     from tempGroup in dcqGroup.DefaultIfEmpty()
                                     select new
                                     {
                                         Score = tempGroup?.Score ?? cqr.Score
                                     }).ToList();

            clientTemplateSection.Score = clientTemplateCal.Sum(x => x.Score);
            clientTemplateSection.Percentage =
                (int)((clientTemplateSection.Score * 100) / clientTemplateCal.Count());
            clientTemplateSection.StatusId = 3; // Assuming 2 is InProgress and 3 is Completed
            userContext.SetDomainDefaults(clientTemplateSection, DataModes.Edit);
            await unitOfWork.ClientTemplateSectionResponses.UpdateAsync(clientTemplateSection.Id, clientTemplateSection);

            var parentSectionId =
                (await unitOfWork.TemplateSections.GetAsync()).FirstOrDefault(x =>
                    x.Id == clientTemplateSection.TemplateSectionId)?.ParentSectionId;

            if (parentSectionId == null)
            {
                logger.LogError("{ClassName} - Parent section not found for TemplateSectionId: {TemplateSectionId}",
                    ClassName, clientTemplateSection.TemplateSectionId);
                throw new KeyNotFoundException(
                    $"Parent section not found for TemplateSectionId: {clientTemplateSection.TemplateSectionId}");
            }

            var parentClientTemplateSectionResponse = (await unitOfWork.ClientTemplateSectionResponses.GetAsync())
                .FirstOrDefault(x => x.TemplateSectionId == parentSectionId && x.ClientTemplateId == clientTemplate.Id);

            var associatedResponses = from cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync()
                                      join ts in await unitOfWork.TemplateSections.GetAsync() on cts.TemplateSectionId equals ts.Id
                                      where ts.ParentSectionId == parentSectionId && cts.ClientTemplateId == clientTemplate.Id
                                      select cts;

            if (associatedResponses == null)
            {
                logger.LogError(
                    "{ClassName} - No ClientTemplateSectionResponse found for TemplateSectionId: {TemplateSectionId}",
                    ClassName, parentSectionId);
                throw new KeyNotFoundException(
                    "No ClientTemplateSectionResponse found for TemplateSectionId: " + parentSectionId);
            }
            if (parentClientTemplateSectionResponse == null)
            {
                logger.LogError(
                    "{ClassName} - Parent ClientTemplateSectionResponse not found for TemplateSectionId: {TemplateSectionId}",
                    ClassName, parentSectionId);
                throw new KeyNotFoundException(
                    "Parent ClientTemplateSectionResponse not found for TemplateSectionId: " + parentSectionId);
            }

            var totalParentSectionQuestions = (await unitOfWork.ClientQuestionnaireResponses
                .GetAsync()).Where(x => x.ClientTemplateSectionResponseId != clientTemplateSection.Id &&
                associatedResponses.Select(c => c.Id).Contains(x.ClientTemplateSectionResponseId));

            var associatedResponseScore = totalParentSectionQuestions
                .Where(x => x.Response != null).Sum(x => x.Score);
            var totalParentSectionQuestionsCount = totalParentSectionQuestions.Count(x => x.Response != null);
            totalParentSectionQuestionsCount =
                totalParentSectionQuestionsCount == 0 ? 1 : totalParentSectionQuestionsCount; // Avoid division by zero

            var associatedCompletedCount =
                associatedResponses.Count(x => x.StatusId == 3);

            parentClientTemplateSectionResponse.Score = associatedResponseScore + clientTemplateSection.Score;
            parentClientTemplateSectionResponse.Percentage =
                ((int)associatedResponseScore * 100) / totalParentSectionQuestionsCount;

            parentClientTemplateSectionResponse.StatusId =
                associatedCompletedCount + 1 >= associatedResponses.Count() ? 3 : 2; // Assuming 2 is InProgress and 3 is Completed
            userContext.SetDomainDefaults(clientTemplate, DataModes.Edit);
            await unitOfWork.ClientTemplateSectionResponses.UpdateAsync(parentClientTemplateSectionResponse.Id,
                parentClientTemplateSectionResponse);

            var completedCount =
                (await unitOfWork.ClientTemplateSectionResponses.GetAsync()).Count(x => x.StatusId == 3);

            clientTemplate.StatusId = completedCount + 1 == completedCount ? 3 : 2; // Assuming 2 is InProgress and 3 is Completed
            userContext.SetDomainDefaults(clientTemplate, DataModes.Edit);
            await unitOfWork.ClientTemplates.UpdateAsync(clientTemplate.Id, clientTemplate);

            var response = await unitOfWork.SaveChangesAsync();

            return response;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - An error occurred in SaveSync method", ClassName);
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - SaveSync method executed", ClassName);
        }
    }
}