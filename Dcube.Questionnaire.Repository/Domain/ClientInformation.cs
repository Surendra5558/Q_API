using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

public class ClientInformation : BaseDomain
{
    /// <summary>
    /// Gets or sets the identifier of the related client template section response.
    /// </summary>
    public long ClientTemplateInformationSectionId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the question being answered.
    /// </summary>
    public long InformationId { get; set; }

    /// <summary>
    /// Gets or sets the response provided by the client for the question.
    /// </summary>
    public string? Response { get; set; }
}