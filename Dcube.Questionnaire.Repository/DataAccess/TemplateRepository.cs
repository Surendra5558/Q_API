using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="Template"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, Template}"/>.
/// </summary>
public class TemplateRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, Template>(context), ITemplateRepository
{
}