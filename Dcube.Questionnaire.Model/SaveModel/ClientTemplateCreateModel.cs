using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the data required to create a client-template association.
/// </summary>
public class ClientTemplateCreateModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the template.
    /// </summary>
    public long TemplateId { get; set; }
}

/// <summary>
/// Validator for <see cref="ClientTemplateCreateModel"/>.
/// Ensures that both ClientId and TemplateId are provided and greater than zero.
/// </summary>
public class ClientTemplateCreateModelValidator : AbstractValidator<ClientTemplateCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientTemplateCreateModelValidator"/> class.
    /// </summary>
    public ClientTemplateCreateModelValidator()
    {
        RuleFor(x => x.ClientId)
            .NotEmpty().WithMessage("Client ID is required.")
            .GreaterThan(0).WithMessage("Client ID must be greater than zero.");
        RuleFor(x => x.TemplateId)
            .NotEmpty().WithMessage("Template ID is required.")
            .GreaterThan(0).WithMessage("Template ID must be greater than zero.");
    }
}