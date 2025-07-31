using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration
{
    /// <summary>
    /// Entity Framework configuration for the <see cref="Client"/> entity.
    /// </summary>
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        /// <summary>
        /// Configures the <see cref="Client"/> entity properties and relationships.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.BaseConfiguration("Client");
            builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
            builder.HasIndex(e => e.Name).IsUnique().HasDatabaseName("IX_Client_Name");

            builder.HasData(
                new Client
                {
                    Id = 1,
                    Name = "Dcube DataSciences",
                    CreatedBy = 1,
                    ModifiedBy = 1
                },
                new Client
                {
                    Id = 2,
                    Name = "KonaAI",
                    CreatedBy = 1,
                    ModifiedBy = 1
                },
                new Client
                {
                    Id = 3,
                    Name = "BCCI",
                    CreatedBy = 1,
                    ModifiedBy = 1
                }
            );
        }
    }
}