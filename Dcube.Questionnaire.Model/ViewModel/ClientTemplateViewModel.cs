using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the view model for a user's client template assignment, including client, template, status, and completion information.
/// </summary>
public class ClientTemplateViewModel : IBaseViewModel
{
    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = string.Empty;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string ClientName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the template.
    /// </summary>
    public long TemplateId { get; set; }

    /// <summary>
    /// Gets or sets the name of the template.
    /// </summary>
    public string TemplateName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the status identifier of the client template assignment.
    /// </summary>
    public long StatusId { get; set; }

    /// <summary>
    /// Gets or sets the status name of the client template assignment.
    /// </summary>
    public string StatusName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the percentage of completion for the template by the user or client.
    /// </summary>
    public int PercentageCompleted { get; set; }
}