using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the maturity path details for a client template, including identified gaps and recommended improvements
/// across technology, process, and people dimensions, as well as audit information.
/// </summary>
public class ClientTemplateMaturityPathViewModel : IBaseViewModel
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
    /// Gets or sets the unique identifier of the associated client template.
    /// </summary>
    public long ClientTemplateId { get; set; }

    /// <summary>
    /// Gets or sets the identified gaps in the client's current maturity state.
    /// </summary>
    public string? Gaps { get; set; }

    /// <summary>
    /// Gets or sets the recommended remediation points to address the identified gaps.
    /// </summary>
    public string? RemediationPoints { get; set; }

    /// <summary>
    /// Gets or sets the technology-related recommendations or observations.
    /// </summary>
    public string? Technology { get; set; }

    /// <summary>
    /// Gets or sets the process-related recommendations or observations.
    /// </summary>
    public string? Process { get; set; }

    /// <summary>
    /// Gets or sets the people-related recommendations or observations.
    /// </summary>
    public string? People { get; set; }

    /// <summary>
    /// Gets or sets the details regarding endpoint detection and response capabilities.
    /// </summary>
    public string? EndPointDectionResponse { get; set; }

    /// <summary>
    /// Gets or sets the details regarding multi-factor authentication implementation.
    /// </summary>
    public string? MultiFactorAutentication { get; set; }

    /// <summary>
    /// Gets or sets the details regarding managed detection and response services.
    /// </summary>
    public string? ManagedDetectionResponse { get; set; }
}