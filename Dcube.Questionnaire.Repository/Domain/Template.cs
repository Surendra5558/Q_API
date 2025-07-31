using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a template entity.
/// Inherits common audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class Template : BaseDomain
{
    /// <summary>
    /// Gets or sets the name of the template.
    /// </summary>
    public string Name { get; set; } = null!;
}