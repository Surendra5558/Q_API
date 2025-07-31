using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Provides data access operations for <see cref="Information"/> entities
/// using the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="GenericRepository{QuestionnaireDbContext, Information}"/>.
/// </summary>
public class InformationRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, Information>(context), IInformationRepository
{

}