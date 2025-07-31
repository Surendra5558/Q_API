using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration
{
    /// <summary>
    /// Entity Framework configuration for the <see cref="ClientExtension"/> entity.
    /// Configures property constraints and mappings for the ClientExtension table.
    /// </summary>
    public class ClientExtensionConfiguration : IEntityTypeConfiguration<ClientExtension>
    {
        /// <summary>
        /// Configures the <see cref="ClientExtension"/> entity properties and relationships.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<ClientExtension> builder)
        {
            builder.BaseConfiguration("ClientExtension");
            builder.Property(e => e.LegalName).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(500).IsRequired();
            builder.Property(e => e.PhoneNumber).HasMaxLength(50);
            builder.Property(e => e.ContactPerson).HasMaxLength(100).IsRequired();
            builder.Property(e => e.ContactPersonEmail).HasMaxLength(100).IsRequired();
            builder.Property(e => e.ContactPersonPhone).HasMaxLength(50).IsRequired();

            builder.HasData(
                new ClientExtension
                {
                    Id = 1,
                    ClientId = 1,
                    LegalName = "Dcube Pvt Ltd",
                    Address = "Hitech City",
                    PhoneNumber = "4012020000",
                    ContactPerson = "Krishna Chaitanya Kona",
                    ContactPersonPhone = "4012020000",
                    ContactPersonEmail = "kkona@konaai.com",
                    NumberOfEmployees = 50,
                    CreatedBy = 1,
                    ModifiedBy = 1
                },
                new ClientExtension
                {
                    Id = 2,
                    ClientId = 2,
                    LegalName = "Kona AI LLP",
                    Address = "Deloitte Drive Hitech City",
                    PhoneNumber = "3012020000",
                    ContactPerson = "Chaitanya Alluri",
                    ContactPersonPhone = "3012020000",
                    ContactPersonEmail = "calluri@konaai.com",
                    NumberOfEmployees = 100,
                    CreatedBy = 1,
                    ModifiedBy = 1

                },
                new ClientExtension
                {
                    Id = 3,
                    ClientId = 3,
                    LegalName = "Board of Cricket for Controller in India",
                    Address = "Wankandi Stadium Mumbai",
                    PhoneNumber = "2012020000",
                    ContactPerson = "Jay Shah",
                    ContactPersonPhone = "2012020000",
                    ContactPersonEmail = "jshah@bccicontrollertest.com",
                    NumberOfEmployees = 10000,
                    NumberOfLocations = 50,
                    NumberOfExternalPartners = 54,
                    NumberOfSuppliers = 401,
                    CreatedBy = 1,
                    ModifiedBy = 1

                }
            );
        }
    }
}