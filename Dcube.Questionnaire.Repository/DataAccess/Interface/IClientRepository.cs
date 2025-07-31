using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Defines repository operations for <see cref="Client"/> entities
/// within the <see cref="QuestionnaireDbContext"/> context.
/// Inherits standard CRUD operations from <see cref="IRepository{QuestionnaireDbContext, Client}"/>.
/// </summary>
public interface IClientRepository : IRepository<QuestionnaireDbContext, Client>
{
}