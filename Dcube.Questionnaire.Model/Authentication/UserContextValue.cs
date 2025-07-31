namespace DCube.Questionnaire.Model.Authentication;

/// <summary>
/// Represents user context values extracted from claims.
/// </summary>
public class UserContextValue
{
    /// <summary>
    /// Gets or sets the employee ID.
    /// </summary>
    public long EmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string ClientName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the employee name.
    /// </summary>
    public string EmployeeName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the employee email.
    /// </summary>
    public string EmployeeEmail { get; set; } = null!;

    /// <summary>
    /// Gets or sets the role ID.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Gets or sets the role name.
    /// </summary>
    public string RoleName { get; set; } = null!;
}