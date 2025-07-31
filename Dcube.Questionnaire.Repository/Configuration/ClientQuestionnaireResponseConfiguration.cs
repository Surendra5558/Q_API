using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="ClientQuestionnaireResponse"/> entity for Entity Framework Core.
/// Sets up table mapping, base configuration, and property constraints.
/// </summary>
public class ClientQuestionnaireResponseConfiguration : IEntityTypeConfiguration<ClientQuestionnaireResponse>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientQuestionnaireResponse"/>.
    /// Applies base configuration, sets the table name, and configures the <c>Response</c> property length.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientQuestionnaireResponse> builder)
    {
        builder.BaseConfiguration("ClientQuestionnaireResponse");
        builder.Property(e => e.Response).HasMaxLength(2000);
        builder.Property(e => e.Comments).HasMaxLength(2000);
    }
}