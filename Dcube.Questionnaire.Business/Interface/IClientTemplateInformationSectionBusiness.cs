using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Defines business operations for retrieving additional sections associated with a client template.
/// </summary>
public interface IClientTemplateInformationSectionBusiness
{
    /// <summary>
    /// Retrieves all additional sections for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientTemplateInfromationSectionViewModel"/> representing the additional sections for the client template.
    /// </returns>
    Task<IQueryable<ClientTemplateInfromationSectionViewModel>> GetAsync(long clientTemplateId);
}