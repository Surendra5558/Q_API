using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents a solution or resolution for a specific client template section,
/// including audit information, section details, score, percentage, and any identified variance.
/// </summary>
public class ClientTemplateSectionSolutionViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the unique identifier for this section solution view model.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time when this entity was created (UTC).
    /// </summary>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets the date and time when this entity was last modified (UTC).
    /// </summary>
    public DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets the username or identifier of the creator.
    /// </summary>
    public string CreatedBy { get; set; } = null!;

    /// <summary>
    /// Gets or sets the username or identifier of the last modifier.
    /// </summary>
    public string ModifiedBy { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the related template section.
    /// </summary>
    public long TemplateSectionId { get; set; }

    /// <summary>
    /// Gets or sets the score assigned to this section solution.
    /// </summary>
    public decimal Score { get; set; }

    /// <summary>
    /// Gets or sets the percentage value representing the completion or evaluation of the section solution.
    /// </summary>
    public int Percentage { get; set; }

    /// <summary>
    /// Gets or sets the name of the related template section.
    /// </summary>
    public string TemplateSectionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the description of any variance identified in the section.
    /// </summary>
    public string? Variance { get; set; }

    /// <summary>
    /// Gets or sets the resolution or solution provided for the section.
    /// </summary>
    public string? Resolution { get; set; }
}