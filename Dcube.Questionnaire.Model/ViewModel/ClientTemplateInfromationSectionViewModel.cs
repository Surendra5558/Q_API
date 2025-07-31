using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents an additional section associated with a client template, including audit and identity information.
/// </summary>
public class ClientTemplateInfromationSectionViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the unique identifier for this additional section view model.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the information section.
    /// </summary>
    public long InformationSectionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the additional section.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the description of the additional section.
    /// </summary>
    public string? Description { get; set; }

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
}