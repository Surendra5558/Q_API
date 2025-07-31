namespace DCube.Questionnaire.Model.Authentication;

/// <summary>
/// Represents the view model for user login information, including user, role, and client details.
/// </summary>
public class UserLoginViewModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the user.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the user's role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Gets or sets the name of the user's role.
    /// </summary>
    public string RoleName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string ClientName { get; set; } = null!;
}