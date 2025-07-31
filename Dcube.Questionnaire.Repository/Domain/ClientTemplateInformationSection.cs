using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a response entity for adding a section to a client template.
/// Inherits audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class ClientTemplateInformationSection : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the related client template.
    /// </summary>
    public long ClientTemplateId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the section within the template.
    /// </summary>
    public long InformationSectionId { get; set; }

    /// <summary>   
    /// Gets or sets the status identifier for this section response.
    /// </summary>
    public long StatusId { get; set; }
}