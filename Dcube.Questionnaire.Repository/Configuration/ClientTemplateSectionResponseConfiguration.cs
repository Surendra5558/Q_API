using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="ClientTemplateSectionResponse"/> entity for Entity Framework Core.
/// Sets up table mapping and base configuration.
/// </summary>
public class ClientTemplateSectionResponseConfiguration : IEntityTypeConfiguration<ClientTemplateSectionResponse>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientTemplateSectionResponse"/>.
    /// Applies base configuration and sets the table name.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientTemplateSectionResponse> builder)
    {
        builder.BaseConfiguration("ClientTemplateSectionResponse");
    }
}