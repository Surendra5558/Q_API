using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration.MetaData;

/// <summary>
/// Configures the <see cref="RoleType"/> entity for Entity Framework Core.
/// Applies base metadata configuration and sets the table name for role types.
/// </summary>
public class RoleTypeConfiguration : IEntityTypeConfiguration<RoleType>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="RoleType"/>.
    /// Applies base metadata configuration and sets the table name.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<RoleType> builder)
    {
        builder.BaseMetaDataConfiguration("RoleType");

        builder.HasData(
            new RoleType
            {
                Id = 1,
                Name = "Admin",
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RoleType
            {
                Id = 2,
                Name = "User",
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}