using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="ClientQuestionnaireResponse"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, ClientQuestionnaireResponse}"/>.
/// </summary>
public class ClientQuestionnaireResponseRepository(QuestionnaireDbContext dbContext)
    : GenericRepository<QuestionnaireDbContext, ClientQuestionnaireResponse>(dbContext), IClientQuestionnaireResponseRepository
{
}