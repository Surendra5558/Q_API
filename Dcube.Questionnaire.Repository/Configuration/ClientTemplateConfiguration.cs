using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="ClientTemplate"/> entity for Entity Framework Core,
/// including table mapping and base configuration.
/// </summary>
public class ClientTemplateConfiguration : IEntityTypeConfiguration<ClientTemplate>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientTemplate"/>.
    /// Applies base configuration and sets the table name.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientTemplate> builder)
    {
        builder.BaseConfiguration("ClientTemplate");
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);
    }
}