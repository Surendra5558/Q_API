using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="InformationSection"/>,
/// including table name, property constraints, and seed data for the InformationSection table.
/// </summary>
public class InformationSectionConfiguration : IEntityTypeConfiguration<InformationSection>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="InformationSection"/>.
    /// Sets up property requirements, constraints, and initial seed data.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<InformationSection> builder)
    {
        builder.BaseConfiguration("InformationSection");
        builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(1000);
        builder.Property(e => e.OrderBy).IsRequired();

        builder.HasData(
            // Seed data for InformationSection
            new InformationSection
            {
                Id = 1,
                Name = "Environment Overview",
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 2,
                Name = "Endpoint & Device Security",
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 3,
                Name = "Cloud Infrastructure",
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 4,
                Name = "Email & Collaboration Tools",
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 5,
                Name = "Data Protection & Governance",
                OrderBy = 5,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 6,
                Name = "Security Log Ingestion & Storage",
                OrderBy = 6,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new InformationSection
            {
                Id = 7,
                Name = "Cyber Insurance",
                OrderBy = 7,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );

    }
}