using DCube.Questionnaire.Repository.Common.Interface;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;

/// <summary>
/// Repository interface for accessing and managing <see cref="RenderType"/> metadata entities.
/// Inherits standard repository operations from <see cref="IRepository{QuestionnaireDbContext, RenderType}"/>.
/// </summary>
public interface IRenderTypeRepository : IRepository<QuestionnaireDbContext, RenderType>
{
}