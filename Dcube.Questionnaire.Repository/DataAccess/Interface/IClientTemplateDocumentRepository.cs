using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess.Interface;

/// <summary>
/// Defines repository operations for <see cref="ClientTemplateDocument"/> entities
/// within the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="IRepository{QuestionnaireDbContext, ClientTemplateDocument}"/>.
/// </summary>
public interface IClientTemplateDocumentRepository : IRepository<QuestionnaireDbContext, ClientTemplateDocument>
{

}