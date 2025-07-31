using DCube.Questionnaire.Repository.DataAccess.Interface;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using Microsoft.EntityFrameworkCore;

namespace DCube.Questionnaire.Repository;

/// <summary>
/// Implements the Unit of Work pattern for managing repository transactions.
/// Provides access to all repositories and coordinates saving changes as a single transaction.
/// </summary>
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly QuestionnaireDbContext _context;

    /// <summary>
    /// Gets the repository for client entities.
    /// </summary>
    public IClientRepository Clients { get; }

    /// <summary>
    /// Gets the repository for client information entities.
    /// </summary>
    public IClientInformationRepository ClientInformations { get; }

    /// <summary>
    /// Gets the repository for client extension entities.
    /// </summary>
    public IClientExtensionRepository ClientExtensions { get; }

    /// <summary>
    /// Gets the repository for client questionnaire response entities.
    /// </summary>
    public IClientQuestionnaireResponseRepository ClientQuestionnaireResponses { get; }

    /// <summary>
    /// Gets the repository for client template document entities.
    /// </summary>
    public IClientTemplateDocumentRepository ClientTemplateDocuments { get; }

    /// <summary>
    /// Gets the repository for client template entities.
    /// </summary>
    public IClientTemplateRepository ClientTemplates { get; }

    /// <summary>
    /// Gets the repository for client template information section entities.
    /// </summary>
    public IClientTemplateInformationSectionRepository ClientTemplateInformationSections { get; }

    /// <summary>
    /// Gets the repository for client template section response entities.
    /// </summary>
    public IClientTemplateSectionResponseRepository ClientTemplateSectionResponses { get; }

    /// <summary>
    /// Gets the repository for client template section solution entities.
    /// </summary>
    public IClientTemplateSectionSolutionRepository ClientTemplateSectionSolutions { get; }

    /// <summary>
    /// Gets the repository for questionnaire entities.
    /// </summary>
    public IQuestionnaireRepository Questionnaires { get; }

    /// <summary>
    /// Gets the repository for template section entities.
    /// </summary>
    public ITemplateSectionRepository TemplateSections { get; }

    /// <summary>
    /// Gets the repository for template entities.
    /// </summary>
    public ITemplateRepository Templates { get; }

    /// <summary>
    /// Gets the repository for information entities.
    /// </summary>
    public IInformationRepository Informations { get; }

    /// <summary>
    /// Gets the repository for information section entities.
    /// </summary>
    public IInformationSectionRepository InformationSections { get; }

    /// <summary>
    /// Gets the repository for user entities.
    /// </summary>
    public IUserRepository Users { get; }

    /// <summary>
    /// Gets the repository for questionnaire status type metadata entities.
    /// </summary>
    public IQuestionnaireStatusTypeRepository QuestionnaireStatusTypes { get; }

    /// <summary>
    /// Gets the repository for question response weightage type metadata entities.
    /// </summary>
    public IQuestionResponseWeightageTypeRepository QuestionResponseWeightageTypes { get; }

    /// <summary>
    /// Gets the repository for role type metadata entities.
    /// </summary>
    public IRoleTypeRepository RoleTypes { get; }

    /// <summary>
    /// Gets the repository for render type metadata entities.
    /// </summary>
    public IRenderTypeRepository RenderTypes { get; }

    /// <summary>
    /// Gets the repository for document type metadata entities.
    /// </summary>
    public IDocumentTypeRepository DocumentTypes { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    /// <param name="context">The database context.</param>
    /// <param name="users">The user repository.</param>
    /// <param name="clients">The client repository.</param>
    /// <param name="clientExtensions">The client extension repository.</param>
    /// <param name="clientQuestionnaireResponses">The client questionnaire response repository.</param>
    /// <param name="clientTemplates">The client template repository.</param>
    /// <param name="clientTemplateSectionResponses">The client template section response repository.</param>   
    /// <param name="questionnaires">The questionnaire repository.</param>
    /// <param name="templateSections">The template section repository.</param>
    /// <param name="templates">The template repository.</param>
    /// <param name="questionnaireStatusTypes">The questionnaire status type repository.</param>
    /// <param name="roleTypes">The role type repository.</param>
    /// <param name="renderTypes">The render type repository.</param>
    /// <param name="questionResponseWeightageTypes">The question response weightage type repository.</param>
    /// <param name="clientInformations">The client information repository.</param>
    /// <param name="clientTemplateInformationSections">The client template information section repository.</param>
    /// <param name="informations">The information repository.</param>
    /// <param name="informationSections">The information section repository.</param>
    /// <param name="clientTemplateDocuments">The client template document repository.</param>
    /// <param name="clientTemplateSectionSolutions">The client template section solution repository.</param>
    /// <param name="documentTypes">The document type repository.</param>
    public UnitOfWork(
        QuestionnaireDbContext context,
        IUserRepository users,
        IClientRepository clients,
        IClientExtensionRepository clientExtensions,
        IClientQuestionnaireResponseRepository clientQuestionnaireResponses,
        IClientTemplateRepository clientTemplates,
        IClientTemplateSectionResponseRepository clientTemplateSectionResponses,
        IQuestionnaireRepository questionnaires,
        ITemplateSectionRepository templateSections,
        ITemplateRepository templates,
        IQuestionnaireStatusTypeRepository questionnaireStatusTypes,
        IRoleTypeRepository roleTypes,
        IRenderTypeRepository renderTypes,
        IQuestionResponseWeightageTypeRepository questionResponseWeightageTypes,
        IClientInformationRepository clientInformations,
        IClientTemplateInformationSectionRepository clientTemplateInformationSections,
        IInformationRepository informations,
        IInformationSectionRepository informationSections,
        IClientTemplateDocumentRepository clientTemplateDocuments,
        IClientTemplateSectionSolutionRepository clientTemplateSectionSolutions,
        IDocumentTypeRepository documentTypes)
    {
        _context = context;
        Users = users;
        Clients = clients;
        ClientExtensions = clientExtensions;
        ClientQuestionnaireResponses = clientQuestionnaireResponses;
        ClientTemplates = clientTemplates;
        ClientTemplateSectionResponses = clientTemplateSectionResponses;
        Questionnaires = questionnaires;
        TemplateSections = templateSections;
        Templates = templates;
        QuestionnaireStatusTypes = questionnaireStatusTypes;
        RoleTypes = roleTypes;
        RenderTypes = renderTypes;
        QuestionResponseWeightageTypes = questionResponseWeightageTypes;
        ClientInformations = clientInformations;
        ClientTemplateInformationSections = clientTemplateInformationSections;
        Informations = informations;
        InformationSections = informationSections;
        ClientTemplateDocuments = clientTemplateDocuments;
        ClientTemplateSectionSolutions = clientTemplateSectionSolutions;
        DocumentTypes = documentTypes;
    }

    /// <summary>
    /// Commits all changes to the database asynchronously.
    /// </summary>
    /// <returns>The number of state entries written to the database.</returns>
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Executes the specified asynchronous action within a transaction and commits changes.
    /// </summary>
    /// <param name="action">The asynchronous action to execute.</param>
    public async Task ExecuteAsync(Func<Task> action)
    {
        var strategy = _context.Database.CreateExecutionStrategy();

        await strategy.ExecuteAsync(async () =>
        {
            // Start a transaction
            await using var transaction = await _context.Database.BeginTransactionAsync();

            await action(); // perform the passed-in logic

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        });
    }

    /// <summary>
    /// Releases all resources used by the <see cref="UnitOfWork"/>.
    /// </summary>
    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}