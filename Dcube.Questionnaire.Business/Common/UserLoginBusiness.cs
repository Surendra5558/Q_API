using System.Security.Authentication;
using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business.Common;

/// <summary>
/// Provides business operations for user authentication and login validation.
/// </summary>
public class UserLoginBusiness(ILogger<UserLoginBusiness> logger, IUnitOfWork unitOfWork)
    : IUserLoginBusiness
{
    private const string ClassName = nameof(ClientBusiness);

    /// <summary>
    /// Validates the user credentials provided in the <see cref="TokenRequest"/> and returns user login details if authentication is successful.
    /// </summary>
    /// <param name="loginViewModel">The login request containing the username, password, and grant type.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="UserLoginViewModel"/>
    /// with user information such as ID, name, email, role, and client details if validation is successful.
    /// Throws <see cref="AuthenticationException"/> if the credentials are invalid.
    /// </returns>
    public async Task<UserLoginViewModel> ValidateUserAsync(TokenRequest loginViewModel)
    {
        try
        {
            logger.LogInformation("{ClassName} ValidateUserAsync: Method execution started", ClassName);
            var result = from u in await unitOfWork.Users.GetAsync()
                         join r in await unitOfWork.RoleTypes.GetAsync() on u.RoleId equals r.Id
                         join c in await unitOfWork.Clients.GetAsync() on u.ClientId equals c.Id
                         where u.IsActive == true
                         select new
                         {
                             User = u,
                             Role = r,
                             Client = c
                         };

            var userRecord = result.FirstOrDefault(x =>
                x.User.UserName == loginViewModel.UserName);

            if (userRecord == null ||
                !BCrypt.Net.BCrypt.Verify(loginViewModel.Password, userRecord.User.Password))
            {
                logger.LogWarning("{ClassName}: Invalid login attempt for user {UserName}", ClassName, loginViewModel.UserName);
                throw new AuthenticationException("Invalid username or password.");
            }

            return new UserLoginViewModel
            {
                Id = userRecord.User.Id,
                Name = string.Concat(userRecord.User.FirstName + " " + userRecord.User.LastName),
                Email = userRecord.User.UserName,
                RoleId = userRecord.Role.Id,
                RoleName = userRecord.Role.Name,
                ClientId = userRecord.Client.Id,
                ClientName = userRecord.Client.Name
            };
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} ValidateUserAsync: An error occurred while validating user credentials", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} ValidateUserAsync: Method execution completed", ClassName);
        }
    }
}