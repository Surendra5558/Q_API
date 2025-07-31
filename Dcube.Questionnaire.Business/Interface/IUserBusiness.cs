using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for managing users, including retrieval, creation, update, and deletion.
/// </summary>
public interface IUserBusiness
{
    /// <summary>
    /// Asynchronously retrieves all users as a queryable collection of view models.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{UserViewModel}"/>
    /// representing all users.
    /// </returns>
    Task<IQueryable<UserViewModel>> GetAsync();

    /// <summary>
    /// Asynchronously retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="UserViewModel"/>
    /// with the user's details.
    /// </returns>
    Task<UserViewModel> GetByIdAsync(long id);

    /// <summary>
    /// Asynchronously creates a new user with the specified information.
    /// </summary>
    /// <param name="model">The model containing the user's creation details.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    Task<int> CreateAsync(UserCreateModel model);

    /// <summary>
    /// Asynchronously updates an existing user.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    Task<int> UpdateAsync();

    /// <summary>
    /// Asynchronously deletes a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the number of records affected.
    /// </returns>
    Task<int> DeleteAsync(long id);
}