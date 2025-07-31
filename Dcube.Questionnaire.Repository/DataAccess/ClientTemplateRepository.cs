using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="ClientTemplate"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, ClientQuestionnaire}"/>.
/// </summary>
public class ClientTemplateRepository(QuestionnaireDbContext dbContext)
    : GenericRepository<QuestionnaireDbContext, ClientTemplate>(dbContext), IClientTemplateRepository
{
}