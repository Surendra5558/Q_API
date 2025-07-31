using DCube.Questionnaire.Repository.Common.Constants;
using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration.MetaData;

/// <summary>
/// Configures the <see cref="RenderType"/> entity for Entity Framework Core.
/// Sets up metadata, table mapping, and seed data for various UI render types.
/// </summary>
public class RenderTypeConfiguration : IEntityTypeConfiguration<RenderType>
{
    /// <summary>
    /// Configures the entity type for <see cref="RenderType"/>.
    /// Applies base metadata configuration and seeds initial render type data.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<RenderType> builder)
    {
        builder.BaseMetaDataConfiguration("RenderType");

        builder.HasData(
            new RenderType
            {
                Id = RenderTypes.TextBox,
                Name = nameof(RenderTypes.TextBox),
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.Number,
                Name = nameof(RenderTypes.Number),
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = false
            },
            new RenderType
            {
                Id = RenderTypes.DropDown,
                Name = nameof(RenderTypes.DropDown),
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.MultiSelect,
                Name = nameof(RenderTypes.MultiSelect),
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.DateTimePicker,
                Name = nameof(RenderTypes.DateTimePicker),
                OrderBy = 5,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.CheckBox,
                Name = nameof(RenderTypes.CheckBox),
                OrderBy = 6,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.RadioButton,
                Name = nameof(RenderTypes.RadioButton),
                OrderBy = 7,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new RenderType
            {
                Id = RenderTypes.TextArea,
                Name = nameof(RenderTypes.TextArea),
                OrderBy = 8,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = false
            },
            new RenderType
            {
                Id = RenderTypes.RichTextEditor,
                Name = nameof(RenderTypes.RichTextEditor),
                OrderBy = 9,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = false
            },
            new RenderType
            {
                Id = RenderTypes.AutoSearch,
                Name = nameof(RenderTypes.AutoSearch),
                OrderBy = 10,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = false
            },
            new RenderType
            {
                Id = RenderTypes.FileUpload,
                Name = nameof(RenderTypes.FileUpload),
                OrderBy = 10,
                CreatedBy = 1,
                ModifiedBy = 1,
                IsActive = false
            }
        );
    }
}