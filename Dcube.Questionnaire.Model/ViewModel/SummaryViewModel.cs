using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents a summary view model containing overall score, client summary, and resilience summary information.
/// </summary>
public class SummaryViewModel : IBaseViewModel
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
    /// Gets or sets the summary information for the client.
    /// </summary>
    public ClientSummary ClientSummary { get; set; } = new();

    /// <summary>
    /// Gets or sets the summary information for resilience.
    /// </summary>
    public List<ResilienceSummary> ResilienceSummaries { get; set; } = [];

    /// <summary>
    /// Gets or sets the overall score.
    /// </summary>
    public decimal Score { get; set; }
}

/// <summary>
/// Represents a summary of client information, including contact and organizational details.
/// </summary>
public class ClientSummary : IBaseViewModel
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

/// <summary>
/// Represents a summary of resilience information, including section name, score, percentage, and response type counts.
/// </summary>
public class ResilienceSummary : IBaseViewModel
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
    /// Gets or sets the name of the section.
    /// </summary>
    public string SectionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the score for the section.
    /// </summary>
    public decimal Score { get; set; }

    /// <summary>
    /// Gets or sets the percentage value for the section.
    /// </summary>
    public int Percentage { get; set; }

    /// <summary>
    /// Gets or sets the list of response type counts for the section.
    /// </summary>
    public List<ResponseTypeCount> ResponseTypeCounts { get; set; } = [];
}

/// <summary>
/// Represents the count of a specific response type.
/// </summary>
public class ResponseTypeCount
{
    /// <summary>
    /// Gets or sets the name of the response type.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the count of responses of this type.
    /// </summary>
    public int Count { get; set; }
}