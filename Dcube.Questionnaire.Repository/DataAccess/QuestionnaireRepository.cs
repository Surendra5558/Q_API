using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="Questionnaire"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, Questionnaire}"/>.
/// </summary>
public class QuestionnaireRepository(QuestionnaireDbContext dbContext)
    : GenericRepository<QuestionnaireDbContext, Domain.Questionnaire>(dbContext), IQuestionnaireRepository
{
}