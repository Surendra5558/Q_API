using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents a user with client, role, and personal information for view operations.
/// Inherits common audit and identity properties from <see cref="IBaseViewModel"/>.
/// </summary>
public class UserViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the identifier of the associated client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string ClientName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the user's role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Gets or sets the name of the role.
    /// </summary>
    public string RoleName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the email for authentication.
    /// </summary>
    public string Email { get; set; } = null!;

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

    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = null!;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = null!;
}