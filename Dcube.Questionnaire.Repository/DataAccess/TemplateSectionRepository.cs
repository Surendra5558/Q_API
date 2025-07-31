using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="TemplateSection"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, TemplateSection}"/>.
/// </summary>
public class TemplateSectionRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, TemplateSection>(context), ITemplateSectionRepository
{
}