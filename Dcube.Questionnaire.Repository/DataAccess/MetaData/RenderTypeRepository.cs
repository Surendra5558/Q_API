using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using DCube.Questionnaire.Repository.Domain.MetaData;

namespace DCube.Questionnaire.Repository.DataAccess.MetaData;

/// <summary>
/// Provides data access operations for <see cref="RenderType"/> entities
/// using the <see cref="QuestionnaireDbContext"/> context.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, RenderType}"/>.
/// </summary>
public class RenderTypeRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, RenderType>(context), IRenderTypeRepository
{
}