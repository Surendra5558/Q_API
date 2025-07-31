using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Provides data access operations for <see cref="Domain.ClientTemplateSectionSolution"/> entities
/// using the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="GenericRepository{QuestionnaireDbContext, Domain.ClientTemplateSectionSolution}"/>.
/// </summary>
public class ClientTemplateSectionSolutionRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, Domain.ClientTemplateSectionSolution>(context), IClientTemplateSectionSolutionRepository
{

}