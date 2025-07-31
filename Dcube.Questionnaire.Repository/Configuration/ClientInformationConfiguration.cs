using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="ClientInformation"/>,
/// including table name, property constraints, and base property configuration.
/// </summary>
public class ClientInformationConfiguration : IEntityTypeConfiguration<ClientInformation>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="ClientInformation"/>.
    /// Sets up the table name, property requirements, and maximum length constraints.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<ClientInformation> builder)
    {
        builder.BaseConfiguration("ClientInformation");
        builder.Property(e => e.Response).HasMaxLength(2000);
    }
}