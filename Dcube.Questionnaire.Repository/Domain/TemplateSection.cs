using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a section within a template, supporting hierarchical structure and description.
/// Inherits common audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class TemplateSection : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the associated template.
    /// </summary>
    public long TemplateId { get; set; }

    /// <summary>
    /// Gets or sets the name of the template section.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the parent section, if this section is a child.
    /// </summary>
    public long? ParentSectionId { get; set; }

    /// <summary>
    /// Gets or sets the description of the section.
    /// </summary>
    public string? Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the order by.
    /// </summary>
    public int OrderBy { get; set; }
}