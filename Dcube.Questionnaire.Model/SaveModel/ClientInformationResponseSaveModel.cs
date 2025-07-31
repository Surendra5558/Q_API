using FluentValidation;

namespace DCube.Questionnaire.Model.SaveModel;

public class ClientInformationResponseSaveModel
{
    /// <summary>
    /// Gets or sets the identifier of the client questionnaire response (if updating an existing response).
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the response value provided by the client.
    /// </summary>
    public string? Response { get; set; }

}

/// <summary>
/// Validator for <see cref="ClientQuestionnaireResponseSaveModel"/> list. Ensures required fields and valid questionnaire responses for each item.
/// </summary>
public class ClientInformationResponseSaveModelValidator : AbstractValidator<List<ClientInformationResponseSaveModel>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientQuestionnaireSaveModelValidator"/> class.
    /// </summary>
    public ClientInformationResponseSaveModelValidator()
    {
        RuleFor(x => x)
            .NotEmpty().WithMessage("At least one questionnaire response is required.");

        RuleForEach(x => x).SetValidator(new ClientInformationResponseSaveModelValidatorRow());
    }
}

/// <summary>
/// Validator for <see cref="ClientQuestionnaireResponseSaveModel"/>. Ensures required fields and valid questionnaire responses.
/// </summary>
public class ClientInformationResponseSaveModelValidatorRow : AbstractValidator<ClientInformationResponseSaveModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientQuestionnaireResponseSaveModelValidator"/> class.
    /// </summary>
    public ClientInformationResponseSaveModelValidatorRow()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Client Questionnaire Response ID must be greater than 0.");
        RuleFor(x => x.Response)
            .NotEmpty().WithMessage("Response cannot be empty.")
            .MaximumLength(500).WithMessage("Response cannot exceed 500 characters.");
    }
}