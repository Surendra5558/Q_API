using DCube.Questionnaire.Model.Authentication;

namespace DCube.Questionnaire.Business.Common;

/// <summary>
/// Provides business operations for user authentication and login validation.
/// </summary>
public interface IUserLoginBusiness
{
    /// <summary>
    /// Validates the user credentials provided in the <see cref="TokenRequest"/> and returns user login details if authentication is successful.
    /// </summary>
    /// <param name="loginViewModel">The login request containing the username, password, and grant type.</param>
    /// <returns>
    /// A <see cref="UserLoginViewModel"/> containing user information such as ID, name, email, role, and client details if validation is successful; otherwise, returns null or throws an exception on failure.
    /// </returns>
    public Task<UserLoginViewModel> ValidateUserAsync(TokenRequest loginViewModel);
}