using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Defines repository operations for <see cref="ClientTemplateSectionResponse"/> entities
/// within the <see cref="QuestionnaireDbContext"/> context.
/// </summary>
public interface IClientTemplateSectionResponseRepository : IRepository<QuestionnaireDbContext, ClientTemplateSectionResponse>
{
}