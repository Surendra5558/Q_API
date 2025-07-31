using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a response provided by a client to a specific question within a questionnaire section.
/// </summary>
public class ClientQuestionnaireResponse : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the related client template section response.
    /// </summary>
    public long ClientTemplateSectionResponseId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the question being answered.
    /// </summary>
    public long QuestionnaireId { get; set; }

    /// <summary>
    /// Gets or sets the response provided by the client for the question.
    /// </summary>
    public string? Response { get; set; }

    /// <summary>
    /// Gets or sets any additional comments provided by the client for this question.
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// Gets or sets the score assigned to this section response.
    /// </summary>
    public decimal Score { get; set; } = 0;
}