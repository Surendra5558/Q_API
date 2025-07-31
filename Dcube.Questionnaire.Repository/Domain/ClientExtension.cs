using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents additional client details and extension properties for a client entity.
/// </summary>
public class ClientExtension : BaseDomain
{
    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the legal name of the client.
    /// </summary>
    public string LegalName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the address of the client.
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Gets or sets the phone number of the client.
    /// </summary>
    public string? PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the primary contact person for the client.
    /// </summary>
    public string ContactPerson { get; set; } = null!;

    /// <summary>
    /// Gets or sets the email address of the contact person.
    /// </summary>
    public string ContactPersonEmail { get; set; } = null!;

    /// <summary>
    /// Gets or sets the phone number of the contact person.
    /// </summary>
    public string ContactPersonPhone { get; set; } = null!;

    /// <summary>
    /// Gets or sets the number of locations associated with the client.
    /// </summary>
    public int NumberOfLocations { get; set; }

    /// <summary>
    /// Gets or sets the number of employees working for the client.
    /// </summary>
    public int NumberOfEmployees { get; set; }

    /// <summary>
    /// Gets or sets the number of suppliers associated with the client.
    /// </summary>
    public int NumberOfSuppliers { get; set; }

    /// <summary>
    /// Gets or sets the number of external partners associated with the client.
    /// </summary>
    public int NumberOfExternalPartners { get; set; }
}