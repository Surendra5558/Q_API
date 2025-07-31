using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Defines business operations for managing client-template associations.
/// </summary>
public interface IClientTemplateBusiness
{
    /// <summary>
    /// Asynchronously retrieves all user client template view models.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{UserClientTemplateViewModel}"/>
    /// representing all user client template associations.
    /// </returns>
    Task<IQueryable<ClientTemplateViewModel>> GetAsync();

    /// <summary>
    /// Creates a new client-template association.
    /// </summary>
    /// <param name="model">The data required to create the association.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the identifier of the created association.
    /// </returns>
    Task<int> CreateAsync(ClientTemplateCreateModel model);

    /// <summary>
    /// Updates an existing client-template association.
    /// </summary>
    /// <param name="model">The data required to update the association.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the identifier of the updated association.
    /// </returns>
    Task<int> UpdateAsync(ClientTemplateUpdateModel model);
}