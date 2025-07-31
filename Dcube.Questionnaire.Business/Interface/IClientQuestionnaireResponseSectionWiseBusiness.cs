using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for handling client questionnaire responses section-wise.
/// </summary>
public interface IClientQuestionnaireResponseSectionWiseBusiness
{
    /// <summary>
    /// Retrieves the section-wise client questionnaire response view model for the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client questionnaire section response.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="ClientQuestionnaireResponseSectionWiseViewModel"/>
    /// with details about the section and its questionnaire responses.
    /// </returns>
    public Task<ClientQuestionnaireResponseSectionWiseViewModel> GetAsync(long id);

    /// <summary>
    /// Saves the client questionnaire responses for a specific section.
    /// </summary>
    /// <param name="clientQuestionnaireResponses">The model containing the client template section response ID and the
    /// questionnaire responses to save.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public Task<int> SaveAsync(List<ClientQuestionnaireResponseSaveModel> clientQuestionnaireResponses);
}