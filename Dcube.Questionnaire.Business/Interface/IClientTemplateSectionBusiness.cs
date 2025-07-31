using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for retrieving client template section information.
/// </summary>
public interface IClientTemplateSectionBusiness
{
    /// <summary>
    /// Asynchronously retrieves the collection of section view models for a given client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{ClientTemplateSectionViewModel}"/>
    /// representing the sections associated with the specified client template.
    /// </returns>
    Task<IQueryable<ClientTemplateSectionViewModel>> GetAsync(long clientTemplateId);
}