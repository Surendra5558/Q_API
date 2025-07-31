using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for managing clients, including retrieval, creation, update, and deletion.
/// </summary>
public interface IClientBusiness
{
    /// <summary>
    /// Retrieves a queryable collection of all clients.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{ClientViewModel}"/>
    /// representing all clients.
    /// </returns>
    Task<IQueryable<ClientViewModel>> GetAsync();

    /// <summary>
    /// Retrieves a client by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the <see cref="ClientViewModel"/> if found; otherwise, <c>null</c>.
    /// </returns>
    Task<ClientViewModel?> GetByIdAsync(long id);

    /// <summary>
    /// Creates a new client using the provided model.
    /// </summary>
    /// <param name="model">The model containing data for the new client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the unique identifier of the created client.
    /// </returns>
    Task<int> CreateAsync(ClientCreateModel model);

    /// <summary>
    /// Updates an existing client using the provided model.
    /// </summary>
    /// <param name="model">The model containing updated data for the client.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    Task<int> UpdateAsync(ClientUpdateModel model);

    /// <summary>
    /// Deletes a client by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client to delete.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    Task<int> DeleteAsync(long id);
}