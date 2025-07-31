using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the data required to save a solution or resolution for a specific client template section,
/// including any identified variance.
/// </summary>
public class ClientTemplateSectionSolutionSaveModel
{
    /// <summary>
    /// Gets or sets the unique identifier for this section solution save model.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the description of any variance identified in the section.
    /// </summary>
    public string? Variance { get; set; }

    /// <summary>
    /// Gets or sets the resolution or solution provided for the section.
    /// </summary>
    public string? Resolution { get; set; }
}

/// <summary>
/// Provides validation rules for <see cref="ClientTemplateSectionSolutionSaveModel"/>.
/// Ensures that the Id is greater than 0.
/// </summary>
public class ClientTemplateSectionSolutionSaveModelValidator : AbstractValidator<ClientTemplateSectionSolutionSaveModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientTemplateSectionSolutionSaveModelValidator"/> class.
    /// </summary>
    public ClientTemplateSectionSolutionSaveModelValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0)
            .WithMessage("Id must be greater than 0.");
    }
}
