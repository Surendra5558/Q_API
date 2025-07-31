using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents a template section view model, including section information and audit properties.
/// </summary>
public class TemplateSectionViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the section information for the template section.
    /// </summary>
    public SectionInformation Section { get; set; } = null!;

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
/// Contains information about a section, including its parent and child sections.
/// </summary>
public class SectionInformation
{
    /// <summary>
    /// Gets or sets the parent section of the current section, if any.
    /// </summary>
    public SectionViewModel? ParentSection { get; set; }

    /// <summary>
    /// Gets or sets the collection of child sections under the current section.
    /// </summary>
    public IReadOnlyList<ChildSectionViewModel> ChildSections { get; set; } = new List<ChildSectionViewModel>();
}

/// <summary>
/// Represents a child section view model, including its parent section and associated questionnaires.
/// </summary>
public class ChildSectionViewModel
{
    /// <summary>
    /// Gets or sets the parent section of this child section.
    /// </summary>
    public SectionViewModel ParentSection { get; set; } = new SectionViewModel();

    /// <summary>
    /// Gets or sets the collection of questionnaires associated with this child section.
    /// </summary>
    public IReadOnlyList<QuestionnaireViewModel> Questionnaires { get; set; } = new List<QuestionnaireViewModel>();
}

/// <summary>
/// Represents a questionnaire view model, including description, render type, options, and order.
/// </summary>
public class QuestionnaireViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the description of the questionnaire.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier for the render type.
    /// </summary>
    public int RenderTypeId { get; set; }

    /// <summary>
    /// Gets or sets the name of the render type.
    /// </summary>
    public string RenderTypeName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the options for the questionnaire, if applicable.
    /// </summary>
    public string? Options { get; set; }

    /// <summary>
    /// Gets or sets the order in which the questionnaire should be displayed.
    /// </summary>
    public int OrderBy { get; set; }

    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = null!;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = null!;
}

/// <summary>
/// Represents a section view model, including its description and audit properties.
/// </summary>
public class SectionViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the description of the section.
    /// </summary>
    public string? Description { get; set; }

    /// <inheritdoc/>
    public long Id { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc/>
    public DateTime ModifiedOn { get; set; }

    /// <inheritdoc/>
    public string CreatedBy { get; set; } = null!;

    /// <inheritdoc/>
    public string ModifiedBy { get; set; } = null!;
}