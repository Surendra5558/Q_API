using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Defines business operations for managing solutions or resolutions for client template sections.
/// </summary>
public interface IClientTemplateSectionSolutionBusiness
{
    /// <summary>
    /// Retrieves all solution or resolution details for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a queryable collection of
    /// <see cref="ClientTemplateSectionSolutionViewModel"/> representing the solutions for the client template sections.
    /// </returns>
    public Task<IQueryable<ClientTemplateSectionSolutionViewModel>> GetAsync(long clientTemplateId);

    /// <summary>
    /// Creates new solutions or resolutions for client template sections using the provided models.
    /// </summary>
    /// <param name="models">A list of models containing data required to create solutions for client template sections.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    public Task<int> SaveAsync(List<ClientTemplateSectionSolutionSaveModel> models);
}