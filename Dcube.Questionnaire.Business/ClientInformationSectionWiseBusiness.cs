using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for retrieving and saving client questionnaire responses grouped by information section.
/// </summary>
public class ClientInformationSectionWiseBusiness(
    ILogger<ClientBusiness> logger,
    IUserContext userContext,
    IUnitOfWork unitOfWork)
    : IClientInformationSectionWiseBusiness
{
    private const string ClassName = nameof(ClientInformationSectionWiseBusiness);

    /// <summary>
    /// Retrieves all client questionnaire responses grouped by section for the specified client template information section.
    /// </summary>
    /// <param name="clientTemplateInfromationSectionId">The unique identifier of the client template information section.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientInformationSectionWiseViewModel"/> representing the responses for the specified section.
    /// </returns>
    public async Task<IQueryable<ClientInformationSectionWiseViewModel>> GetAsync(long clientTemplateInfromationSectionId)
    {
        try
        {
            logger.LogInformation("{ClassName} - GetAsync started", ClassName);

            var clientinformations = from ci in (await unitOfWork.ClientInformations.GetAsync())
                    .Where(x => x.ClientTemplateInformationSectionId == clientTemplateInfromationSectionId)
                                     join ir in await unitOfWork.Informations.GetAsync() on ci.InformationId equals ir.Id
                                     join rt in await unitOfWork.RenderTypes.GetAsync() on ir.RenderTypeId equals rt.Id
                                     orderby ir.OrderBy
                                     select new InformationResponse
                                     {
                                         Id = ci.Id,
                                         InformationId = ir.Id,
                                         Response = ci.Response,
                                         Description = ir.Description,
                                         IsMandatory = ir.IsMandatory,
                                         Options = ir.Options,
                                         RenderTypeId = rt.Id,
                                         RenderTypeName = rt.Name
                                     };

            var result = from ct in await unitOfWork.ClientTemplateInformationSections.GetAsync()
                         join isc in await unitOfWork.InformationSections.GetAsync() on ct.InformationSectionId equals isc.Id
                         //join st in await unitOfWork.QuestionnaireStatusTypes.GetAsync() on ct.StatusId equals st.Id
                         join uc in await unitOfWork.Users.GetAsync() on ct.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on ct.ModifiedBy equals um.Id
                         orderby isc.OrderBy
                         where ct.Id == clientTemplateInfromationSectionId
                         select new ClientInformationSectionWiseViewModel
                         {
                             Id = ct.Id,
                             InformationSectionId = isc.Id,
                             InformationSectionName = isc.Name,
                             //ClientTemplateInfromationSectionStatusId = st.Id,
                             //ClientTemplateInfromationSectionStatusName = st.Name,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = ct.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = ct.ModifiedOn,
                             InformationResponses = clientinformations.ToList()
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
    /// Saves a list of client questionnaire responses for information sections.
    /// </summary>
    /// <param name="clientInformationResponses">The list of client information response models to save.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if the input list is null or empty.</exception>
    /// <exception cref="KeyNotFoundException">Thrown if no matching client information or section is found for the provided IDs.</exception>
    public async Task<int> SaveAsync(List<ClientInformationResponseSaveModel> clientInformationResponses)
    {
        try
        {
            logger.LogInformation("{ClassName} - SaveSync method started with model: {@Model}", ClassName,
                clientInformationResponses);
            if (clientInformationResponses == null || clientInformationResponses.Count == 0)
            {
                logger.LogError("{ClassName} - SaveSync method received null model", ClassName);
                throw new ArgumentNullException(nameof(clientInformationResponses), "Model cannot be null");
            }

            var clientInformations = (await unitOfWork.ClientInformations.GetAsync())
                .Where(c => clientInformationResponses.Select(x => x.Id).Contains(c.Id));
            if (clientInformations == null || !clientInformations.Any())
            {
                logger.LogError("{ClassName} - No ClientTemplateSectionResponses found for provided IDs", ClassName);
                throw new KeyNotFoundException("No ClientTemplateSectionResponses found for provided IDs");
            }

            var clientTemplateInformationSection = (await unitOfWork.ClientTemplateInformationSections.GetAsync()).FirstOrDefault(x =>
                x.Id == clientInformations.First().ClientTemplateInformationSectionId);

            if (clientTemplateInformationSection == null)
            {
                logger.LogError("{ClassName} - No ClientInformationTemplateSection found for provided IDs", ClassName);
                throw new KeyNotFoundException("No ClientInformationTemplateSection found for provided IDs");
            }

            var updateList = clientInformations.ToList();

            foreach (var info in updateList)
            {
                info.Response = clientInformationResponses
                    .FirstOrDefault(x => x.Id == info.Id)?.Response;
                userContext.SetDomainDefaults(info, DataModes.Edit);
            }

            await unitOfWork.ClientInformations.UpdateRangeAsync(updateList);

            clientTemplateInformationSection.StatusId = 3;
            userContext.SetDomainDefaults(clientTemplateInformationSection, DataModes.Edit);
            await unitOfWork.ClientTemplateInformationSections.UpdateAsync(clientTemplateInformationSection.Id,
                clientTemplateInformationSection);

            var result = await unitOfWork.SaveChangesAsync();
            return result;
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