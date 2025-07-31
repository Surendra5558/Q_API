using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a document associated with a client template, including metadata and content.
/// Inherits audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class ClientTemplateDocument : BaseDomain
{
    /// <summary>
    /// Gets or sets the unique identifier of the related client template.
    /// </summary>
    public long ClientTemplateId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the document type (e.g., PDF, Word, Excel).
    /// </summary>
    public long DocumentTypeId { get; set; }

    /// <summary>
    /// Gets or sets the name of the document.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the file extension of the document (e.g., ".pdf", ".docx").
    /// </summary>
    public string Extension { get; set; } = null!;

    /// <summary>
    /// Gets or sets the binary content of the document.
    /// </summary>
    public byte[] Content { get; set; } = null!;

    /// <summary>
    /// Gets or sets the URL where the document is stored, if applicable.
    /// </summary>
    public string? Url { get; set; }
}