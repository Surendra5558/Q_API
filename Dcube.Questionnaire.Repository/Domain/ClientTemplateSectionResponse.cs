using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a response for a specific section within a client template.
/// </summary>
public class ClientTemplateSectionResponse : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the related client template.
    /// </summary>
    public long ClientTemplateId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the section within the template.
    /// </summary>
    public long TemplateSectionId { get; set; }

    /// <summary>
    /// Gets or sets the status identifier for this section response score.
    /// </summary>
    public decimal Score { get; set; } = 0;

    /// <summary>
    /// Gets or sets the status identifier for this section percentage.
    /// </summary>
    public int Percentage { get; set; } = 0;

    /// <summary>
    /// Gets or sets the status identifier for this section response.
    /// </summary>
    public long StatusId { get; set; }
}