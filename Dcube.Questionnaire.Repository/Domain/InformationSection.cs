using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

public class InformationSection : BaseDomain
{
    /// <summary>
    /// Gets or sets the name of the template section.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the description of the section.
    /// </summary>
    public string? Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the order by.
    /// </summary>
    public int OrderBy { get; set; }
}