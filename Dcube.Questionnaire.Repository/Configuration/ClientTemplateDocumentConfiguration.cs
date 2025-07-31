using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="ClientTemplateDocument"/>,
/// including table name, property constraints, and column types for the ClientTemplateDocument table.
/// </summary>
public class ClientTemplateDocumentConfiguration : IEntityTypeConfiguration<ClientTemplateDocument>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientTemplateDocument"/>.
    /// Sets up property requirements, constraints, and column types.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientTemplateDocument> builder)
    {
        builder.BaseConfiguration("ClientTemplateDocument");
        builder.Property(x => x.ClientTemplateId).IsRequired();
        builder.Property(x => x.DocumentTypeId).IsRequired();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Extension).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Content).IsRequired().HasColumnType("varbinary(max)");
        builder.Property(x => x.Url).HasMaxLength(500);
    }
}