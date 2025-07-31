using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

/// <summary>
/// Represents the model used to create a new user, including client, role, and personal details.
/// </summary>
public class UserCreateModel
{
    /// <summary>
    /// Gets or sets the identifier of the associated client.
    /// </summary>
    public long ClientId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user's role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Gets or sets the password for the user.
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Gets or sets the email address for authentication.
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's first name.
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's last name.
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the user's phone number.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the user's address.
    /// </summary>
    public string? Address { get; set; }
}

/// <summary>
/// Validator for <see cref="UserCreateModel"/>. Ensures required fields and valid values for user creation.
/// </summary>
public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCreateModelValidator"/> class.
    /// Defines validation rules for the <see cref="UserCreateModel"/> properties.
    /// </summary>
    public UserCreateModelValidator()
    {
        RuleFor(x => x.ClientId).NotEmpty().GreaterThan(0).WithMessage("ClientId must be greater than 0.");
        RuleFor(x => x.RoleId).NotEmpty().GreaterThan(0).WithMessage("RoleId must be greater than 0.");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required.");
        RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("A valid Email is required.");
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required.");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required.");
    }
}