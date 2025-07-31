using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="ClientTemplateSectionSolution"/>,
/// including table name, property constraints, and column types for the ClientTemplateSectionSolution table.
/// </summary>
public class ClientTemplateSectionSolutionConfiguration : IEntityTypeConfiguration<ClientTemplateSectionSolution>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientTemplateSectionSolution"/>.
    /// Sets up property requirements, constraints, and column types.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientTemplateSectionSolution> builder)
    {
        builder.BaseConfiguration("ClientTemplateSectionSolution");
        builder.Property(x => x.ClientTemplateSectionId).IsRequired();
        builder.Property(x => x.Variance).HasMaxLength(4000);
        builder.Property(x => x.Resolution).HasMaxLength(4000);
    }
}