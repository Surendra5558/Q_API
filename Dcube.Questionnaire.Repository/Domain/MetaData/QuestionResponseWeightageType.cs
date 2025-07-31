using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain.MetaData;

/// <summary>
/// Represents a type of weightage that can be assigned to a question response.
/// Inherits metadata properties such as name, description, and order from <see cref="BaseMetaDataDomain"/>.
/// </summary>
public class QuestionResponseWeightageType : BaseMetaDataDomain
{
    /// <summary>
    /// Gets or sets the weight value associated with this response type.
    /// This value is used to determine the significance or impact of a particular response.
    /// </summary>
    public decimal Weight { get; set; }
}