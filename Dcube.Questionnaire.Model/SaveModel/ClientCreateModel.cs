using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the data required to create a new client.
/// </summary>
public class ClientCreateModel
{
    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the legal name of the client.
    /// </summary>
    public string LegalName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the address of the client.
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Gets or sets the phone number of the client.
    /// </summary>
    public string? PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the contact person for the client.
    /// </summary>
    public string ContactPerson { get; set; } = null!;

    /// <summary>
    /// Gets or sets the email address of the contact person.
    /// </summary>
    public string ContactPersonEmail { get; set; } = null!;

    /// <summary>
    /// Gets or sets the phone number of the contact person.
    /// </summary>
    public string ContactPersonPhone { get; set; } = null!;

    /// <summary>
    /// Gets or sets the number of locations associated with the client.
    /// </summary>
    public int NumberOfLocations { get; set; }

    /// <summary>
    /// Gets or sets the number of employees associated with the client.
    /// </summary>
    public int NumberOfEmployees { get; set; }

    /// <summary>
    /// Gets or sets the number of suppliers associated with the client.
    /// </summary>
    public int NumberOfSuppliers { get; set; }

    /// <summary>
    /// Gets or sets the number of external partners associated with the client.
    /// </summary>
    public int NumberOfExternalPartners { get; set; }
}

/// <summary>
/// Provides validation rules for the <see cref="ClientCreateModel"/> class.
/// </summary>
public class ClientValidator : AbstractValidator<ClientCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientValidator"/> class
    /// and defines validation rules for client creation.
    /// </summary>
    public ClientValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(200).WithMessage("Name cannot exceed 200 characters.");

        RuleFor(x => x.LegalName)
            .NotEmpty().WithMessage("Legal Name is required.");
    }
}