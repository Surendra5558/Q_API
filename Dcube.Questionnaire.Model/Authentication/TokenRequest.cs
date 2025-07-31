using FluentValidation;

namespace DCube.Questionnaire.Model.Authentication;

/// <summary>
/// Represents a request for an authentication token, containing user credentials and grant type.
/// </summary>
public class TokenRequest
{
    /// <summary>
    /// Gets or sets the username of the user requesting authentication.
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the password of the user requesting authentication.
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Gets or sets the OAuth grant type for the authentication request (e.g., "password").
    /// </summary>
    public string GrantType { get; set; } = null!;
}

/// <summary>
/// Validator for <see cref="TokenRequest"/>. Ensures that all required fields are provided and valid.
/// </summary>
public class TokenRequestValidator : AbstractValidator<TokenRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TokenRequestValidator"/> class.
    /// Defines validation rules for the <see cref="TokenRequest"/> properties.
    /// </summary>
    public TokenRequestValidator()
    {
        RuleFor(x => x.UserName).NotNull();
        RuleFor(x => x.Password).NotNull();
        RuleFor(x => x.GrantType).NotNull().Equals("passowrd");
    }
}