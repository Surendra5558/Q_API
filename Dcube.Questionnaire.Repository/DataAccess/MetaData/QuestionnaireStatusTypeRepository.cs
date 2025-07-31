using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.MetaData;

/// <summary>
/// Provides data access operations for <see cref="QuestionnaireStatusType"/> entities
/// using the <see cref="QuestionnaireDbContext"/> context.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, QuestionnaireStatusType}"/>.
/// </summary>
public class QuestionnaireStatusTypeRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, QuestionnaireStatusType>(context), IQuestionnaireStatusTypeRepository
{
}