namespace DCube.Questionnaire.Model.Authentication;

/// <summary>
/// Represents the response returned after a successful authentication token request.
/// </summary>
public class TokenResponse
{
    /// <summary>
    /// Gets or sets the name of the authenticated user.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the authentication token issued to the user.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    /// Gets or sets the role identifier of the authenticated user.
    /// </summary>
    public long RoleId { get; set; }
}