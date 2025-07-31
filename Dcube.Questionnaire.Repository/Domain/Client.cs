using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain;

/// <summary>
/// Represents a customer entity with business and contact information.
/// Inherits common audit and identity properties from <see cref="BaseDomain"/>.
/// </summary>
public class Client : BaseDomain
{
    /// <summary>
    /// Gets or sets the name of the customer.
    /// </summary>
    public string Name { get; set; } = null!;
}