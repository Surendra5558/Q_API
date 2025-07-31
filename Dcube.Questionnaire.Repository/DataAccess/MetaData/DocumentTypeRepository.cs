using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.MetaData;

/// <summary>
/// Provides data access operations for <see cref="DocumenType"/> metadata entities
/// using the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="GenericRepository{QuestionnaireDbContext, DocumenType}"/>.
/// </summary>
public class DocumentTypeRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, DocumenType>(context), IDocumentTypeRepository
{

}