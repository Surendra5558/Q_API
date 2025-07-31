using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;

/// <summary>
/// Defines repository operations for <see cref="DocumenType"/> metadata entities
/// within the <see cref="QuestionnaireDbContext"/>.
/// Inherits standard CRUD and query operations from <see cref="IRepository{QuestionnaireDbContext, DocumenType}"/>.
/// </summary>
public interface IDocumentTypeRepository : IRepository<QuestionnaireDbContext, DocumenType>
{

}