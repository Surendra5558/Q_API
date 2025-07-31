using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;

/// <summary>
/// Provides data access operations for <see cref="QuestionResponseWeightageType"/> entities.
/// Inherits standard repository operations such as retrieval, creation, update, and deletion
/// from <see cref="IRepository{QuestionnaireDbContext, QuestionResponseWeightageType}"/>.
/// </summary>
public interface IQuestionResponseWeightageTypeRepository : IRepository<QuestionnaireDbContext, QuestionResponseWeightageType>
{

}