using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="ClientTemplateInformationSection"/>,
/// including table name and base property configuration.
/// </summary>
public class ClientTemplateInformationSectionConfiguration : IEntityTypeConfiguration<ClientTemplateInformationSection>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientTemplateInformationSection"/>.
    /// Sets up the table name and applies base configuration.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientTemplateInformationSection> builder)
    {
        builder.BaseConfiguration("ClientTemplateInformationSection");
    }
}