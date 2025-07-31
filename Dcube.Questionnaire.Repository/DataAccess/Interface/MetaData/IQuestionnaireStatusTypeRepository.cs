using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;

/// <summary>
/// Repository interface for accessing and managing <see cref="QuestionnaireStatusType"/> metadata entities.
/// Inherits standard repository operations from <see cref="IRepository{QuestionnaireDbContext, QuestionnaireStatusType}"/>.
/// </summary>
public interface IQuestionnaireStatusTypeRepository : IRepository<QuestionnaireDbContext, QuestionnaireStatusType>
{
}