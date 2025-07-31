using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a solution or resolution for a specific client template section, including any identified variance.
/// Inherits audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class ClientTemplateSectionSolution : BaseDomain
{
    /// <summary>
    /// Gets or sets the unique identifier of the related client template section.
    /// </summary>
    public long ClientTemplateSectionId { get; set; }

    /// <summary>
    /// Gets or sets the description of any variance identified in the section.
    /// </summary>
    public string? Variance { get; set; }

    /// <summary>
    /// Gets or sets the resolution or solution provided for the section.
    /// </summary>
    public string? Resolution { get; set; }
}