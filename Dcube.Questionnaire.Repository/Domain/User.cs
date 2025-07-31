using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a user entity with authentication, contact, and profile information.
/// Inherits common audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class User : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the associated client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user's role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Gets or sets the username for authentication.
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the password for authentication.
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's first name.
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's last name.
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's phone number.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the user's address.
    /// </summary>
    public string? Address { get; set; }
}