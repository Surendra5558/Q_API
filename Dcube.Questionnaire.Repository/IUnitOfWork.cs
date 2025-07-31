using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;

namespace DCube.Questionnaire.Repository;

/// <summary>
/// Defines the contract for the Unit of Work pattern, coordinating repository operations and database transactions.
/// Provides access to all repositories and a method to commit changes as a single transaction.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    /// <summary>
    /// Gets the repository for client entities.
    /// </summary>
    IClientRepository Clients { get; }

    /// <summary>
    /// Gets the repository for client extension entities.
    /// </summary>
    IClientExtensionRepository ClientExtensions { get; }

    /// <summary>
    /// Gets the repository for client information entities.
    /// </summary>
    IClientInformationRepository ClientInformations { get; }

    /// <summary>
    /// Gets the repository for client questionnaire response entities.
    /// </summary>
    IClientQuestionnaireResponseRepository ClientQuestionnaireResponses { get; }

    /// <summary>
    /// Gets the repository for client template document entities.
    /// </summary>
    IClientTemplateDocumentRepository ClientTemplateDocuments { get; }

    /// <summary>
    /// Gets the repository for client template entities.
    /// </summary>
    IClientTemplateRepository ClientTemplates { get; }

    /// <summary>
    /// Gets the repository for client template information section entities.
    /// </summary>
    IClientTemplateInformationSectionRepository ClientTemplateInformationSections { get; }

    /// <summary>
    /// Gets the repository for client template section response entities.
    /// </summary>
    IClientTemplateSectionResponseRepository ClientTemplateSectionResponses { get; }

    /// <summary>
    /// Gets the repository for client template section solution entities.
    /// </summary>
    IClientTemplateSectionSolutionRepository ClientTemplateSectionSolutions { get; }

    /// <summary>
    /// Gets the repository for information entities.
    /// </summary>
    IInformationRepository Informations { get; }

    /// <summary>
    /// Gets the repository for information section entities.
    /// </summary>
    IInformationSectionRepository InformationSections { get; }

    /// <summary>
    /// Gets the repository for questionnaire entities.
    /// </summary>
    IQuestionnaireRepository Questionnaires { get; }

    /// <summary>
    /// Gets the repository for template section entities.
    /// </summary>
    ITemplateSectionRepository TemplateSections { get; }

    /// <summary>
    /// Gets the repository for template entities.
    /// </summary>
    ITemplateRepository Templates { get; }

    /// <summary>
    /// Gets the repository for user entities.
    /// </summary>
    IUserRepository Users { get; }

    /// <summary>
    /// Gets the repository for questionnaire status type metadata entities.
    /// </summary>
    IQuestionnaireStatusTypeRepository QuestionnaireStatusTypes { get; }

    /// <summary>
    /// Gets the repository for question response weightage type metadata entities.
    /// </summary>
    IQuestionResponseWeightageTypeRepository QuestionResponseWeightageTypes { get; }

    /// <summary>
    /// Gets the repository for role type metadata entities.
    /// </summary>
    IRoleTypeRepository RoleTypes { get; }

    /// <summary>
    /// Gets the repository for render type metadata entities.
    /// </summary>
    IRenderTypeRepository RenderTypes { get; }

    /// <summary>
    /// Gets the repository for document type metadata entities.
    /// </summary>
    IDocumentTypeRepository DocumentTypes { get; }

    /// <summary>
    /// Saves all changes made in this unit of work to the database asynchronously.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.
    /// </returns>
    Task<int> SaveChangesAsync();

    /// <summary>
    /// Executes the specified asynchronous action within the context of the unit of work.
    /// </summary>
    /// <param name="action">The asynchronous action to execute.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// </returns>
    Task ExecuteAsync(Func<Task> action);
}