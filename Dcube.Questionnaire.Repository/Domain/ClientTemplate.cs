using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents the association between a client and a questionnaire template,
/// including the current status of the questionnaire for the client.
/// Inherits common audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class ClientTemplate : BaseDomain
{
    /// <summary>
    /// Gets or sets the name of the client template association.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique identifier of the client associated with this questionnaire.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the questionnaire template assigned to the client.
    /// </summary>
    public long TemplateId { get; set; }

    /// <summary>
    /// Gets or sets the status identifier representing the current state of the questionnaire for the client.
    /// </summary>
    public long StatusId { get; set; }
}