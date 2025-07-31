using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="Template"/> entity for Entity Framework Core.
/// Sets up table mapping and applies base configuration for templates.
/// </summary>
public class TemplateConfiguration : IEntityTypeConfiguration<Template>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="Template"/>.
    /// Applies base configuration and sets the table name.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Template> builder)
    {
        builder.BaseConfiguration("Template");
        builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
        builder.HasIndex(e => e.Name).IsUnique().HasDatabaseName("IX_Template_Name");

        builder.HasData(
            new Template
            {
                Id = 1,
                Name = "Cybersecurity Default Template",
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}