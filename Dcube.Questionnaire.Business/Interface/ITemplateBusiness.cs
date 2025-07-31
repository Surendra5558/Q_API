using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for managing templates, including retrieval of template information.
/// </summary>
public interface ITemplateBusiness
{
    /// <summary>
    /// Retrieves a queryable collection of all templates, including their details and audit information.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{TemplateViewModel}"/>
    /// representing all templates.
    /// </returns>
    Task<IQueryable<TemplateViewModel>> GetAsync();
}