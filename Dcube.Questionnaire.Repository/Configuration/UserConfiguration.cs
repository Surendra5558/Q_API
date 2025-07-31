using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="User"/> entity for Entity Framework Core.
/// Sets up table mapping and applies base configuration for users.
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="User"/>.
    /// Applies base configuration, sets the table name, and configures property constraints.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.BaseConfiguration("User");
        builder.Property(e => e.UserName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Password).HasMaxLength(200).IsRequired();
        builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.PhoneNumber).HasMaxLength(20);
        builder.Property(e => e.Address).HasMaxLength(500);

        builder.HasIndex(e => e.UserName).IsUnique().HasDatabaseName("IX_User_UserName");

        builder.HasData(

            new User
            {
                Id = 1,
                UserName = "kkona@konaai.com",
                Password = "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y",
                FirstName = "Krishna Chaitanya",
                LastName = "Kona",
                PhoneNumber = "1234567890",
                Address = "123 Main St, City, Country",
                ClientId = 1,
                RoleId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new User
            {
                Id = 2,
                UserName = "kkona@dcubedata.com",
                Password = "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y",
                FirstName = "Krishna",
                LastName = "Kona",
                PhoneNumber = "1134457890",
                Address = "123 Main St, City, Country",
                ClientId = 1,
                RoleId = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new User
            {
                Id = 3,
                UserName = "chaitanya.kona@covasant.com",
                Password = "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y",
                FirstName = "Chaitanya",
                LastName = "Kona",
                PhoneNumber = "4444567890",
                Address = "123 Main St, City, Country",
                ClientId = 2,
                RoleId = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new User
            {
                Id = 4,
                UserName = "konachaitanya@gmail.com",
                Password = "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y",
                FirstName = "Hima Bindu",
                LastName = "Kona",
                PhoneNumber = "1234560000",
                Address = "123 Main St, City, Country",
                ClientId = 2,
                RoleId = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new User
            {
                Id = 5,
                UserName = "konachaitanya@hotmail.com",
                Password = "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y",
                FirstName = "Kevin",
                LastName = "Williams",
                PhoneNumber = "6444553789",
                Address = "123 Main St, City, Country",
                ClientId = 3,
                RoleId = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}