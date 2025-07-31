using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the view model for a client template section, including section details and audit information.
/// </summary>
public class ClientTemplateSectionViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the template section.
    /// </summary>
    public long TemplateSectionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the template section.
    /// </summary>
    public string TemplateSectionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the description of the template section.
    /// </summary>
    public string? TemplateSectionDescription { get; set; }

    /// <summary>
    /// Gets or sets the parent template section identifier.
    /// </summary>
    public long? ParentTemplateSectionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the parent template section.
    /// </summary>
    public string? ParentTemplateSectionName { get; set; }

    /// <summary>
    /// Gets or sets the parent template section n description.
    /// </summary>
    public string? ParentTemplateSectionNDescription { get; set; }

    /// <summary>
    /// Gets or sets the status identifier for the template section.
    /// </summary>
    public long StatusId { get; set; }

    /// <summary>
    /// Gets or sets the score.
    /// </summary>
    public decimal Score { get; set; } = 0;

    /// <summary>
    /// Gets or sets the percentage.
    /// </summary>
    public int Percentage { get; set; } = 0;

    /// <summary>
    /// Gets or sets the status name for the template section.
    /// </summary>
    public string StatusName { get; set; } = null!;

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
}