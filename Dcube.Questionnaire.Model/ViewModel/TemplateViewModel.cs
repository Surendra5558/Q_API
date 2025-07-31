using DCube.Questionnaire.Model.Common;

namespace DCube.Questionnaire.Model.ViewModel;

/// <summary>
/// Represents the view model for a template, including its name and audit information.
/// </summary>
public class TemplateViewModel : IBaseViewModel
{
    /// <summary>
    /// Gets or sets the name of the template.
    /// </summary>
    public string Name { get; set; } = null!;

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