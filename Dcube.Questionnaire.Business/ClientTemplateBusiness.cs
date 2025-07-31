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
/// Provides business operations for managing client-template associations.
/// </summary>
public class ClientTemplateBusiness(ILogger<ClientTemplateBusiness> logger, IUserContext userContext,
    IUnitOfWork unitOfWork)
    : IClientTemplateBusiness
{
    private const string ClassName = nameof(ClientTemplateBusiness);

    /// <summary>
    /// Asynchronously retrieves all user client template view models, filtered by user role if necessary,
    /// and calculates the percentage of completed template sections for each client template.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{UserClientTemplateViewModel}"/>
    /// representing all user client template associations with completion percentages.
    /// </returns>
    public async Task<IQueryable<ClientTemplateViewModel>> GetAsync()
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(GetAsync));
            var userId = userContext.UserContextValue.EmployeeId;
            var clientId = userContext.UserContextValue.ClientId;
            var roleId = userContext.UserContextValue.RoleId;

            var clientTemplateSection = from cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync()
                                        group cts by cts.ClientTemplateId
                into g
                                        select new
                                        {
                                            ClientTemplateId = g.Key,
                                            TotalCount = g.Count(),
                                            CompletedCount = g.Count(x => x.StatusId == 3) // Assuming 3 is the status for completed
                                        };


            var result = from c in await unitOfWork.Clients.GetAsync()
                         join ct in await unitOfWork.ClientTemplates.GetAsync() on c.Id equals ct.ClientId
                         join t in await unitOfWork.Templates.GetAsync() on ct.TemplateId equals t.Id
                         join s in await unitOfWork.QuestionnaireStatusTypes.GetAsync() on ct.StatusId equals s.Id
                         join uc in await unitOfWork.Users.GetAsync() on c.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on c.ModifiedBy equals um.Id
                         join cs in clientTemplateSection on ct.Id equals cs.ClientTemplateId
                         orderby ct.ModifiedOn descending
                         select new ClientTemplateViewModel
                         {
                             Id = ct.Id,
                             ClientId = c.Id,
                             ClientName = c.Name,
                             TemplateId = t.Id,
                             TemplateName = t.Name,
                             PercentageCompleted = cs.CompletedCount * 100 / cs.TotalCount, // Calculate percentage completed
                             StatusId = s.Id,
                             StatusName = s.Name,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = c.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = c.ModifiedOn
                         };

            if (roleId != 1)
            {
                result = result.Where(x => x.ClientId == clientId);
            }

            foreach (var r in result)
            {
                var data = (await unitOfWork.ClientTemplateSectionResponses.GetAsync())
                    .Where(x => x.ClientTemplateId == r.Id);
                var totalCount = data.Count();
                var completedCount = data.Count(x => x.StatusId == 3); // Assuming 2 is the status for completed
                r.PercentageCompleted = totalCount > 0 ? (completedCount * 100) / totalCount : 0;
            }

            return result.OrderBy(x => x.ClientName).ThenBy(x => x.TemplateName);
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
    /// Creates a new client-template association.
    /// </summary>
    /// <param name="model">The data required to create the association.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of state entries written to the database.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the specified client or template does not exist.
    /// </exception>
    /// <exception cref="Exception">
    /// Thrown when an unexpected error occurs during the operation.
    /// </exception>
    public async Task<int> CreateAsync(ClientTemplateCreateModel model)
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(CreateAsync));

            var client = await unitOfWork.Clients.GetByIdAsync(model.ClientId);
            if (client == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client not found for ID: {ClientId}", ClassName,
                    nameof(CreateAsync), model.ClientId);
                throw new ArgumentException($"Client with ID {model.ClientId} does not exist.");
            }

            var template = await unitOfWork.Templates.GetByIdAsync(model.TemplateId);
            if (template == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Template not found for ID: {TemplateId}", ClassName,
                    nameof(CreateAsync), model.TemplateId);
                throw new ArgumentException($"Template with ID {model.TemplateId} does not exist.");
            }

            var result = 0;

            await unitOfWork.ExecuteAsync(async () =>
            {

                // Create a new ClientTemplate
                var clientTemplate = new ClientTemplate
                {
                    Name = string.Concat(client.Name, "-", template.Name, "-", DateTime.UtcNow.ToFileTime()),
                    ClientId = model.ClientId,
                    TemplateId = model.TemplateId,
                    StatusId = 1
                };
                userContext.SetDomainDefaults(clientTemplate, DataModes.Add);
                await unitOfWork.ClientTemplates.AddAsync(clientTemplate);
                _ = await unitOfWork.SaveChangesAsync();

                // Create ClientTemplateSectionResponses for each TemplateSection in the Template
                var templateSections = (await unitOfWork.TemplateSections.GetAsync())
                    .Where(x => x.TemplateId == model.TemplateId);
                var clientTemplateSectionResponses = new List<ClientTemplateSectionResponse>();
                foreach (var templateSection in templateSections)
                {
                    var clientTemplateSectionResponse = new ClientTemplateSectionResponse
                    {
                        ClientTemplateId = clientTemplate.Id,
                        TemplateSectionId = templateSection.Id,
                        StatusId = 1 // Assuming default status is active
                    };
                    userContext.SetDomainDefaults(clientTemplateSectionResponse, DataModes.Add);
                    clientTemplateSectionResponses.Add(clientTemplateSectionResponse);
                }

                await unitOfWork.ClientTemplateSectionResponses.AddRangeAsync(clientTemplateSectionResponses);
                result += await unitOfWork.SaveChangesAsync();

                // Create ClientTemplateSectionSolutions for each TemplateSectionResponse
                var clientTemplateSectionSolutions = (from cts in clientTemplateSectionResponses
                                                      join ts in await unitOfWork.TemplateSections.GetAsync() on cts.TemplateSectionId equals ts.Id
                                                      where ts.ParentSectionId == null
                                                      select
                                                          new ClientTemplateSectionSolution
                                                          {
                                                              ClientTemplateSectionId = cts.Id
                                                          }).ToList();
                userContext.SetDomainDefaults(clientTemplateSectionSolutions, DataModes.Add);
                await unitOfWork.ClientTemplateSectionSolutions.AddRangeAsync(clientTemplateSectionSolutions);
                result += await unitOfWork.SaveChangesAsync();

                // Create Questionnaire responses for each TemplateSection
                var questionnaires = (from q in await unitOfWork.Questionnaires.GetAsync()
                                      join cts in await unitOfWork.ClientTemplateSectionResponses.GetAsync() on q.TemplateSectionId equals
                                          cts.TemplateSectionId
                                      where cts.ClientTemplateId == clientTemplate.Id
                                      select new ClientQuestionnaireResponse
                                      {
                                          ClientTemplateSectionResponseId = cts.Id,
                                          QuestionnaireId = q.Id,
                                      }).ToList();
                userContext.SetDomainDefaults(questionnaires, DataModes.Add);
                await unitOfWork.ClientQuestionnaireResponses.AddRangeAsync(questionnaires);
                result += await unitOfWork.SaveChangesAsync();

                // Handle additional questionnaire sections
                var informationSections = (await unitOfWork.InformationSections.GetAsync()).ToList();
                var clientTemplateInformationSections = new List<ClientTemplateInformationSection>();
                foreach (var informationSection in informationSections.Select(section =>
                             new ClientTemplateInformationSection
                             {
                                 ClientTemplateId = clientTemplate.Id,
                                 InformationSectionId = section.Id,
                             }))
                {
                    userContext.SetDomainDefaults(informationSection, DataModes.Add);
                    clientTemplateInformationSections.Add(informationSection);
                }

                await unitOfWork.ClientTemplateInformationSections.AddRangeAsync(clientTemplateInformationSections);
                result += await unitOfWork.SaveChangesAsync();

                // Now create ClientTemplateAddQuestionnaireResponses for each additional section
                var informationQuestions = (await unitOfWork.Informations.GetAsync()).ToList();
                var cleintInformations = new List<ClientInformation>();
                foreach (var informationQuestionResponse in from addSectionResponse in clientTemplateInformationSections
                                                            from questionnaire in informationQuestions.Where(q =>
                                                                q.InformationSectionId == addSectionResponse.InformationSectionId)
                                                            select new ClientInformation
                                                            {
                                                                ClientTemplateInformationSectionId = addSectionResponse.Id,
                                                                InformationId = questionnaire.Id
                                                            })
                {
                    userContext.SetDomainDefaults(informationQuestionResponse, DataModes.Add);
                    cleintInformations.Add(informationQuestionResponse);
                }

                if (cleintInformations.Count > 0)
                {
                    await unitOfWork.ClientInformations.AddRangeAsync(
                        cleintInformations);
                    result += await unitOfWork.SaveChangesAsync();
                }
            });
            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - {MethodName} - Error", ClassName, nameof(CreateAsync));
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - {MethodName} - End", ClassName, nameof(CreateAsync));
        }
    }

    /// <summary>
    /// Updates an existing client-template association.
    /// </summary>
    /// <param name="model">The data required to update the association.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of state entries written to the database.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the specified client-template, client, or template does not exist.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the client-template is not in a valid state for update.
    /// </exception>
    /// <exception cref="Exception">
    /// Thrown when an unexpected error occurs during the operation.
    /// </exception>
    public async Task<int> UpdateAsync(ClientTemplateUpdateModel model)
    {
        try
        {
            logger.LogInformation("{ClassName} - {MethodName} - Start", ClassName, nameof(UpdateAsync));

            var clientTemplate = await unitOfWork.ClientTemplates.GetByIdAsync(model.Id);
            if (clientTemplate == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client Template not found for ID: {Id}", ClassName,
                    nameof(UpdateAsync), model.Id);
                throw new ArgumentException($"Client Template with ID {model.Id} does not exist.");
            }

            var client = await unitOfWork.Clients.GetByIdAsync(model.ClientId);
            if (client == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Client not found for ID: {ClientId}", ClassName,
                    nameof(CreateAsync), model.ClientId);
                throw new ArgumentException($"Client with ID {model.ClientId} does not exist.");
            }

            var template = await unitOfWork.Templates.GetByIdAsync(model.TemplateId);
            if (template == null)
            {
                logger.LogError("{ClassName} - {MethodName} - Template not found for ID: {TemplateId}", ClassName,
                    nameof(CreateAsync), model.TemplateId);
                throw new ArgumentException($"Template with ID {model.TemplateId} does not exist.");
            }

            if (clientTemplate.StatusId > 1)
            {
                logger.LogError(
                    "{ClassName} - {MethodName} - Client Template with ID: {Id} cannot be updated as it is not in a valid state.",
                    ClassName, nameof(UpdateAsync), model.Id);
                throw new InvalidOperationException(
                    $"Client Template with ID {model.Id} cannot be updated as it is not in a valid state.");
            }

            clientTemplate.ClientId = model.ClientId;
            clientTemplate.TemplateId = model.TemplateId;

            userContext.SetDomainDefaults(clientTemplate, DataModes.Edit);
            await unitOfWork.ClientTemplates.UpdateAsync(model.Id, clientTemplate);
            var result = await unitOfWork.SaveChangesAsync();

            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - {MethodName} - Error", ClassName, nameof(UpdateAsync));
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - {MethodName} - End", ClassName, nameof(UpdateAsync));
        }
    }
}