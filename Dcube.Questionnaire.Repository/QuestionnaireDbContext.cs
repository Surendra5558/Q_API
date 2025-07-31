using System.Reflection;
using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DCube.Questionnaire.Repository
{
    /// <summary>
    /// Represents the Entity Framework Core database context for the Questionnaire application.
    /// Manages entity sets for clients, questionnaires, templates, users, and related metadata.
    /// </summary>
    public class QuestionnaireDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireDbContext"/> class.
        /// </summary>
        /// <remarks>
        /// See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see>
        /// for more information and examples.
        /// </remarks>
        public QuestionnaireDbContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireDbContext"/> class using the specified options.
        /// </summary>
        /// <param name="options">The options to be used by the DbContext.</param>
        public QuestionnaireDbContext(DbContextOptions<QuestionnaireDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the clients in the system.
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Gets or sets the additional client details and extension properties.
        /// </summary>
        public DbSet<ClientExtension> ClientExtensions { get; set; }

        /// <summary>
        /// Gets or sets the responses provided by clients to questionnaire questions.
        /// </summary>
        public DbSet<ClientQuestionnaireResponse> ClientQuestionnaireResponses { get; set; }

        /// <summary>
        /// Gets or sets the association between clients and questionnaire templates.
        /// </summary>
        public DbSet<ClientTemplate> ClientTemplates { get; set; }

        /// <summary>
        /// Gets or sets the client template section responses.
        /// </summary>
        public DbSet<ClientTemplateSectionResponse> ClientTemplateSectionResponses { get; set; }

        /// <summary>
        /// Gets or sets the questionnaires in the system.
        /// </summary>
        public DbSet<Domain.Questionnaire> Questionnaires { get; set; }

        /// <summary>
        /// Gets or sets the templates for questionnaires.
        /// </summary>
        public DbSet<Template> Templates { get; set; }

        /// <summary>
        /// Gets or sets the sections within templates.
        /// </summary>
        public DbSet<TemplateSection> TemplateSections { get; set; }

        /// <summary>
        /// Gets or sets the users in the system.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the questionnaire status types metadata.
        /// </summary>
        public DbSet<QuestionnaireStatusType> QuestionnaireStatusTypes { get; set; }

        /// <summary>
        /// Gets or sets the role types metadata.
        /// </summary>
        public DbSet<RoleType> RoleTypes { get; set; }

        /// <summary>
        /// Gets or sets the render types metadata.
        /// </summary>
        public DbSet<RenderType> RenderTypes { get; set; }

        /// <summary>
        /// Configures the database (and other options) for this context.
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var configuration = configBuilder.Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString)
                .ConfigureWarnings(warnings => { warnings.Ignore(RelationalEventId.PendingModelChangesWarning); });
        }

        /// <summary>
        /// Further configures the model that was discovered by convention from the entity types
        /// exposed in <see cref="DbSet{TEntity}"/> properties on your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}