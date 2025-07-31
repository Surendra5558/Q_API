using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="User"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, User}"/>.
/// </summary>
public class UserRepository(QuestionnaireDbContext dbContext)
    : GenericRepository<QuestionnaireDbContext, User>(dbContext), IUserRepository
{
}