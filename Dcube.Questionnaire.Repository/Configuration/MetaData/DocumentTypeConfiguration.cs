using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration.MetaData;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="DocumenType"/> metadata entities,
/// including table name, property constraints, and seed data for the DocumentType table.
/// </summary>
public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumenType>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="DocumenType"/>.
    /// Sets up property requirements, constraints, and initial seed data.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<DocumenType> builder)
    {
        builder.BaseMetaDataConfiguration("DocumentType");

        builder.HasData(
            // Seed data for document types
            new DocumenType
            {
                Id = 1,
                Name = "Client Details",
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new DocumenType
            {
                Id = 2,
                Name = "Client Background",
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new DocumenType
            {
                Id = 3,
                Name = "Path to Maturity",
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}