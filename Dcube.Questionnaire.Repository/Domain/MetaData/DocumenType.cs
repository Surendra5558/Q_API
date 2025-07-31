using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Repository.Domain.MetaData;

/// <summary>
/// Represents a document type metadata entity, such as PDF, Word, or Excel.
/// Inherits common metadata, audit, and identity properties from <see cref="BaseMetaDataDomain"/>.
/// </summary>
public class DocumenType : BaseMetaDataDomain
{
    // All properties are inherited from BaseMetaDataDomain:
    // - Name, Description, OrderBy
    // - Id, RowId, CreatedBy, CreatedOn, ModifiedBy, ModifiedOn, IsActive, IsDeleted
}