using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the view model for a client, including details, contact information, and related statistics.
/// </summary>
public class ClientViewModel : IBaseViewModel
{
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

    /// <summary>
    /// Gets or sets the name of the customer.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the legal name of the client.
    /// </summary>
    public string? LegalName { get; set; }

    /// <summary>
    /// Gets or sets the address of the client.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the client.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the primary contact person for the client.
    /// </summary>
    public string? ContactPerson { get; set; }

    /// <summary>
    /// Gets or sets the email address of the contact person.
    /// </summary>
    public string? ContactPersonEmail { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the contact person.
    /// </summary>
    public string? ContactPersonPhone { get; set; }

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