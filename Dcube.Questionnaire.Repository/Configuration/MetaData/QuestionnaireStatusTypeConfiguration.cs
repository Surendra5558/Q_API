using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration.MetaData;

/// <summary>
/// Configures the <see cref="QuestionnaireStatusType"/> entity for Entity Framework Core.
/// Sets up metadata, table mapping, and seed data for questionnaire status types.
/// </summary>
public class QuestionnaireStatusTypeConfiguration : IEntityTypeConfiguration<QuestionnaireStatusType>
{
    /// <summary>
    /// Configures the entity type for <see cref="QuestionnaireStatusType"/>.
    /// Applies base metadata configuration and seeds initial status types.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<QuestionnaireStatusType> builder)
    {
        builder.BaseMetaDataConfiguration("QuestionnaireStatusType");

        builder.HasData(
            new QuestionnaireStatusType
            {
                Id = 1,
                Name = "Not Initiated",
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new QuestionnaireStatusType
            {
                Id = 2,
                Name = "In Progress",
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new QuestionnaireStatusType
            {
                Id = 3,
                Name = "Completed",
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}