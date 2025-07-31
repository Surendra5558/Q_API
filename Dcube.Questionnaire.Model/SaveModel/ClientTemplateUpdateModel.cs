using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the data required to update a client-template association.
/// </summary>
public class ClientTemplateUpdateModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the client-template association.
    /// </summary>
    public long Id { get; set; }

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
/// Validator for <see cref="ClientTemplateUpdateModel"/>.
/// Ensures that Id, ClientId, and TemplateId are provided and greater than zero.
/// </summary>
public class ClientTemplateUpdateModelValidator : AbstractValidator<ClientTemplateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientTemplateUpdateModelValidator"/> class.
    /// </summary>
    public ClientTemplateUpdateModelValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("ID is required.")
            .GreaterThan(0).WithMessage("ID must be greater than zero.");
        RuleFor(x => x.ClientId)
            .NotEmpty().WithMessage("Client ID is required.")
            .GreaterThan(0).WithMessage("Client ID must be greater than zero.");
        RuleFor(x => x.TemplateId)
            .NotEmpty().WithMessage("Template ID is required.")
            .GreaterThan(0).WithMessage("Template ID must be greater than zero.");
    }
}