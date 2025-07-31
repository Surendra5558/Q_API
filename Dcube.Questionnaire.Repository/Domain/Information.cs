using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents an additional questionnaire item associated with a template section.
/// Inherits audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class Information : BaseDomain
{
    /// <summary>
    /// Gets or sets the textual description of the questionnaire item.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the order in which the questionnaire item should be displayed.
    /// </summary>
    public int OrderBy { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the render type, which determines how the questionnaire item is presented (e.g., text box, dropdown).
    /// </summary>
    public int RenderTypeId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is mandatory.
    /// </summary>
    public bool IsMandatory { get; set; } = true;

    /// <summary>
    /// Gets or sets the identifier of the section to which this questionnaire item belongs.
    /// </summary>
    public long InformationSectionId { get; set; }

    /// <summary>
    /// Gets or sets the serialized options for the questionnaire item, if applicable (e.g., for multiple choice questions).
    /// </summary>
    public string? Options { get; set; }
}