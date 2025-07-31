using Azure;
using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for retrieving summary information related to a client template,
/// including overall score, client details, and resilience summaries.
/// </summary>
public class SummaryBusiness(ILogger<SummaryBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork,
    IClientBusiness clientBusiness) : ISummaryBusiness
{
    private const string ClassName = nameof(SummaryBusiness);

    /// <summary>
    /// Retrieves the summary information for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="SummaryViewModel"/>
    /// with overall score, client summary, and resilience summary information.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    /// Thrown if the client template or client is not found, or if no parent sections exist for the template.
    /// </exception>
    public async Task<SummaryViewModel> GetByIdAsync(long clientTemplateId)
    {
        const string notAnswered = "Not Answered";
        ;
        var summaryViewModel = new SummaryViewModel
        {
            Id = 1
        };

        try
        {
            logger.LogInformation("{ClassName} - GetByIdAsync started", ClassName);

            var domainClientTemplate = await unitOfWork.ClientTemplates.GetByIdAsync(clientTemplateId);
            if (domainClientTemplate == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client Template not found for ID: {TemplateId}", ClassName,
                    nameof(GetByIdAsync), clientTemplateId);
                throw new KeyNotFoundException($"Client Template with ID {clientTemplateId} does not exist.");
            }

            var client = await clientBusiness.GetByIdAsync(domainClientTemplate.ClientId);
            if (client == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client not found for ID: {ClientId}", ClassName,
                    nameof(GetByIdAsync), domainClientTemplate.ClientId);
                throw new KeyNotFoundException($"Client with ID {domainClientTemplate.ClientId} does not exist.");
            }

            var responseWeightageTypes =
                (await unitOfWork.QuestionResponseWeightageTypes.GetAsync()).Select(x =>
                    new
                    {
                        Response = x.Name,
                        CompareName = x.Name.ToLower()
                    }).ToList();
            responseWeightageTypes.Add(
                new
                {
                    Response = notAnswered,
                    CompareName = notAnswered.ToLower()
                });

            summaryViewModel.ClientSummary = new ClientSummary
            {
                Id = client.Id,
                Name = client.Name,
                LegalName = client.LegalName,
                Address = client.Address,
                PhoneNumber = client.PhoneNumber,
                ContactPerson = client.ContactPerson,
                ContactPersonEmail = client.ContactPersonEmail,
                ContactPersonPhone = client.ContactPersonPhone,
                NumberOfLocations = client.NumberOfLocations,
                NumberOfEmployees = client.NumberOfEmployees,
                NumberOfSuppliers = client.NumberOfSuppliers,
                NumberOfExternalPartners = client.NumberOfExternalPartners,
                CreatedOn = client.CreatedOn,
                ModifiedOn = client.ModifiedOn,
                CreatedBy = client.CreatedBy,
                ModifiedBy = client.ModifiedBy
            };

            var domainClientTemplateSection = from cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync()
                                              join ts in await unitOfWork.TemplateSections.GetAsync()
                                                  on cts.TemplateSectionId equals ts.Id
                                              where cts.ClientTemplateId == clientTemplateId
                                              select new { cts, ts };

            var parentSections = domainClientTemplateSection.Where(x => x.ts.ParentSectionId == null).ToList();

            if (!parentSections.Any())
            {
                logger.LogError("{ClassName} - {MethodName} - No parent sections found for Client Template ID: {TemplateId}",
                    ClassName, nameof(GetByIdAsync), clientTemplateId);
                throw new KeyNotFoundException($"No parent sections found for Client Template with ID {clientTemplateId}.");
            }

            var domainClientQuestionnaireResponses =
                from cqr in await unitOfWork.ClientQuestionnaireResponses.GetAsync()
                join dcts in domainClientTemplateSection on cqr.ClientTemplateSectionResponseId equals dcts.cts.Id
                select new
                {
                    ClientTemplateSectionResponse = dcts.cts,
                    TemplateSection = dcts.ts,
                    QuestionnaireResponse = cqr
                };

            summaryViewModel.Score = parentSections.Sum(x => x.cts.Score);
            foreach (var parentSection in parentSections)
            {
                var resilienceSummary = new ResilienceSummary
                {
                    Id = parentSection.cts.Id,
                    SectionName = parentSection.ts.Name,
                    Score = parentSection.cts.Score,
                    Percentage = parentSection.cts.Percentage
                };

                var parentSectionQuestions =
                    domainClientQuestionnaireResponses.Where(x =>
                        x.TemplateSection.ParentSectionId == parentSection.ts.Id);

                var groupQuestion = (from psq in parentSectionQuestions
                                     group psq by psq.QuestionnaireResponse.Response
                    into g
                                     select new
                                     {
                                         Name = string.IsNullOrWhiteSpace(g.Key) ? notAnswered.ToLower() : g.Key.ToLower(),
                                         Count = g.Count()
                                     }).ToList();

                resilienceSummary.ResponseTypeCounts = (from rwt in responseWeightageTypes
                                                        join gq in groupQuestion on rwt.CompareName equals gq.Name
                                                            into gpGroup
                                                        from gpOuter in gpGroup.DefaultIfEmpty()
                                                        select new ResponseTypeCount
                                                        {
                                                            Name = rwt.Response,
                                                            Count = gpOuter?.Count ?? 0
                                                        }).ToList();

                summaryViewModel.ResilienceSummaries.Add(resilienceSummary);

            }

            return summaryViewModel;

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
}