using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.MetaData;

/// <summary>
/// Repository for performing data access operations on <see cref="QuestionResponseWeightageType"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, QuestionResponseWeightageType}"/>.
/// </summary>
public class QuestionResponseWeightageTypeRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, QuestionResponseWeightageType>(context),
        IQuestionResponseWeightageTypeRepository
{

}