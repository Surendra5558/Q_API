using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the view model for client questionnaire responses grouped by section,
/// including section details, status, and a collection of questionnaire responses.
/// </summary>
public class ClientQuestionnaireResponseSectionWiseViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the status identifier for the client questionnaire section.
    /// </summary>
    public long ClientQuestionnaireSectionStatusId { get; set; }

    /// <summary>
    /// Gets or sets the status name for the client questionnaire section.
    /// </summary>
    public string ClientQuestionnaireSectionStatusName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the section.
    /// </summary>
    public long ParentSectionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the section.
    /// </summary>
    public string ParentSectionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the section.
    /// </summary>
    public long SectionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the section.
    /// </summary>
    public string SectionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the parent section description.
    /// </summary>
    public string? SectionDescription { get; set; }

    /// <summary>
    /// Gets or sets the collection of questionnaire responses for this section.
    /// </summary>
    public List<QuestionnaireResponse> QuestionnaireResponses { get; set; } = new List<QuestionnaireResponse>();

    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = string.Empty;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = string.Empty;
}

/// <summary>
/// Represents a single questionnaire response within a section, including question details and user response.
/// </summary>
public class QuestionnaireResponse : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the section description.
    /// </summary>
    public string? SectionDescription { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the client questionnaire response.
    /// </summary>
    public long? ClientQuestionnaireResponseId { get; set; }

    /// <summary>
    /// Gets or sets the response value provided by the client.
    /// </summary>
    public string? Response { get; set; }

    /// <summary>
    /// Gets or sets the comments.
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the questionnaire.
    /// </summary>
    public long QuestionnaireId { get; set; }

    /// <summary>
    /// Gets or sets the description of the questionnaire.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the render type identifier.
    /// </summary>
    public long RenderTypeId { get; set; }

    /// <summary>
    /// Gets or sets the name of the render type.
    /// </summary>
    public string RenderTypeName { get; set; } = null!;

    /// <summary>
    /// Gets or sets a value indicating whether this question is mandatory.
    /// </summary>
    public bool IsMandatory { get; set; }

    /// <summary>
    /// Gets or sets the options for the questionnaire response.
    /// </summary>
    public string? Options { get; set; }

    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = string.Empty;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = string.Empty;
}