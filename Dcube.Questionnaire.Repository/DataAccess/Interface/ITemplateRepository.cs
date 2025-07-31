using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Defines repository operations for <see cref="Template"/> entities
/// within the <see cref="QuestionnaireDbContext"/> context.
/// Inherits standard CRUD operations from <see cref="IRepository{QuestionnaireDbContext, Template}"/>.
/// </summary>
public interface ITemplateRepository : IRepository<QuestionnaireDbContext, Template>
{
}