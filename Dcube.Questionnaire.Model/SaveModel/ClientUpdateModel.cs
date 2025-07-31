using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the data required to update an existing client.
/// </summary>
public class ClientUpdateModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the client.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
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
/// Provides validation rules for the <see cref="ClientUpdateModel"/> class.
/// </summary>
public class ClientUpdateValidator : AbstractValidator<ClientUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientUpdateValidator"/> class
    /// and defines validation rules for updating a client.
    /// </summary>
    public ClientUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("ClientId is required.")
            .GreaterThan(0).WithMessage("ClientId must be greater than 0.");
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(200).WithMessage("Name cannot exceed 200 characters.");
        RuleFor(x => x.LegalName)
            .NotEmpty().WithMessage("Legal Name is required.")
            .MaximumLength(200).WithMessage("Legal Name cannot exceed 200 characters.");
        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Address is required.")
            .MaximumLength(500).WithMessage("Address cannot exceed 500 characters.");
        RuleFor(x => x.ContactPerson)
            .NotEmpty().WithMessage("Contact Person is required.")
            .MaximumLength(100).WithMessage("Contact Person cannot exceed 100 characters.");
        RuleFor(x => x.ContactPersonEmail)
            .NotEmpty().WithMessage("Contact Person Email is required.")
            .EmailAddress().WithMessage("Invalid email format for Contact Person Email.");
        RuleFor(x => x.ContactPersonPhone)
            .NotEmpty().WithMessage("Contact Person Phone is required.")
            .MaximumLength(15).WithMessage("Contact Person Phone cannot exceed 15 characters.");
    }
}