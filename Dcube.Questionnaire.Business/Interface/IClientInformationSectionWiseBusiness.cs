using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Defines business operations for retrieving and saving client questionnaire responses grouped by information section.
/// </summary>
public interface IClientInformationSectionWiseBusiness
{
    /// <summary>
    /// Retrieves all client questionnaire responses grouped by section for the specified client template information section.
    /// </summary>
    /// <param name="clientTemplateInfromationSectionId">The unique identifier of the client template information section.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientInformationSectionWiseViewModel"/> representing the responses for the specified section.
    /// </returns>
    public Task<IQueryable<ClientInformationSectionWiseViewModel>> GetAsync(long clientTemplateInfromationSectionId);

    /// <summary>
    /// Saves a list of client questionnaire responses for information sections.
    /// </summary>
    /// <param name="clientInformationResponses">The list of client information response models to save.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public Task<int> SaveAsync(List<ClientInformationResponseSaveModel> clientInformationResponses);
}