using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration.MetaData;

public class QuestionResponseWeightageTypeConfiguration : IEntityTypeConfiguration<QuestionResponseWeightageType>
{
    public void Configure(EntityTypeBuilder<QuestionResponseWeightageType> builder)
    {
        builder.BaseMetaDataConfiguration("QuestionResponseWeightageType");

        builder.HasData(
            new QuestionResponseWeightageType
            {
                Id = 1,
                Name = "Yes",
                Weight = 1,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new QuestionResponseWeightageType
            {
                Id = 2,
                Name = "InProgress",
                Weight = 0.5m,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new QuestionResponseWeightageType
            {
                Id = 3,
                Name = "No",
                Weight = 0,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new QuestionResponseWeightageType
            {
                Id = 4,
                Name = "NA",
                Weight = 1,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            }
        );
    }
}