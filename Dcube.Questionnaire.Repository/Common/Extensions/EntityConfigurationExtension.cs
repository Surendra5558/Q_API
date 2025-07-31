using DCube.Questionnaire.Repository.Common.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Common.Extensions;

/// <summary>
/// Extension Method to generate default properties
/// </summary>
public static class EntityConfigurationExtension
{
    /// <summary>
    /// Bases the configuration.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="tableName">Name of the table.</param>
    /// <param name="schemaName">Name of the schema.</param>
    public static void BaseConfiguration<T>(this EntityTypeBuilder<T> builder, string tableName, string schemaName = "Dcube")
        where T : BaseDomain
    {
        SetBuilder(builder, tableName, schemaName);
    }

    /// <summary>
    /// Bases the configuration.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="tableName">Name of the table.</param>
    /// <param name="schemaName">Name of the schema.</param>
    public static void BaseMetaDataConfiguration<T>(this EntityTypeBuilder<T> builder, string tableName,
        string schemaName = "MetaData")
        where T : BaseMetaDataDomain
    {
        SetBuilder(builder, tableName, schemaName);
        builder.Property(e => e.Name).HasMaxLength(200).HasColumnOrder(9).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(1000).HasColumnOrder(10);
        builder.Property(e => e.OrderBy).HasColumnOrder(11).IsRequired();
    }

    private static void SetBuilder<T>(EntityTypeBuilder<T> builder, string tableName,
        string schemaName, bool isDeletedFilter = false) where T : BaseDomain
    {
        builder.ToTable(tableName, schemaName);
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnOrder(1).IsRequired();
        builder.Property(e => e.RowId).HasColumnOrder(2).IsRequired();
        builder.Property(e => e.CreatedOn).HasColumnOrder(3).IsRequired();
        builder.Property(e => e.CreatedBy).HasColumnOrder(4).IsRequired();
        builder.Property(e => e.ModifiedOn).HasColumnOrder(5).IsRequired();
        builder.Property(e => e.ModifiedBy).HasColumnOrder(6).IsRequired();
        builder.Property(e => e.IsActive).HasColumnOrder(7).IsRequired();
        builder.Property(e => e.IsDeleted).HasColumnOrder(8).IsRequired();

        builder.HasQueryFilter(e => e.IsDeleted == isDeletedFilter);
    }
}