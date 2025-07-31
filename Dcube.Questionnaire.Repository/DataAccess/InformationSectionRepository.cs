using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Provides data access operations for <see cref="InformationSection"/> entities
/// using the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="GenericRepository{QuestionnaireDbContext, InformationSection}"/>.
/// </summary>
public class InformationSectionRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, InformationSection>(context), IInformationSectionRepository
{

}