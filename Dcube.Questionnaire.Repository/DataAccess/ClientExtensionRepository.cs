using DCube.Questionnaire.Repository.Common;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.Domain;

namespace DCube.Questionnaire.Repository.DataAccess;

/// <summary>
/// Repository for managing <see cref="ClientExtension"/> entities.
/// Inherits standard CRUD operations from <see cref="GenericRepository{QuestionnaireDbContext, ClientExtension}"/>.
/// </summary>
public class ClientExtensionRepository(QuestionnaireDbContext context)
    : GenericRepository<QuestionnaireDbContext, ClientExtension>(context), IClientExtensionRepository
{
}