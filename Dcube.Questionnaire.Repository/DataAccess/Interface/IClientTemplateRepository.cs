using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Repository interface for managing <see cref="ClientTemplate"/> entities.
/// Inherits standard CRUD operations from <see cref="IRepository{TContext, TEntity}"/>.
/// </summary>
public interface IClientTemplateRepository : IRepository<QuestionnaireDbContext, ClientTemplate>
{
}