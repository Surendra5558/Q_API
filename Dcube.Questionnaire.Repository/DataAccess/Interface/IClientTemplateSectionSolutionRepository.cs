using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Defines repository operations for <see cref="ClientTemplateSectionSolution"/> entities
/// within the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="IRepository{QuestionnaireDbContext, ClientTemplateSectionSolution}"/>.
/// </summary>
public interface IClientTemplateSectionSolutionRepository : IRepository<QuestionnaireDbContext, ClientTemplateSectionSolution>
{

}