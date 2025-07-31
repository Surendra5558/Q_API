using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Provides data access operations for <see cref="Client"/> entities
/// using the <see cref="QuestionnaireDbContext"/> context.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, Client}"/>.
/// </summary>
public class ClientRepository(QuestionnaireDbContext dbContext)
    : GenericRepository<QuestionnaireDbContext, Client>(dbContext), IClientRepository
{
}