using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedDocumntsSolutionAndDocumentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTemplateMaturityPath",
                schema: "Dcube");

            migrationBuilder.CreateTable(
                name: "ClientTemplateDocument",
                schema: "Dcube",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ClientTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplateDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTemplateSectionSolution",
                schema: "Dcube",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ClientTemplateSectionId = table.Column<long>(type: "bigint", nullable: false),
                    Variance = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Resolution = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplateSectionSolution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                schema: "MetaData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(8574), new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(8580), new Guid("73df9f86-5731-42a6-861f-fb1884ccd8f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(9752), new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(9754), new Guid("a6b023e3-b526-4ea9-9dc9-d5ac8b0a926c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(9758), new DateTime(2025, 7, 18, 5, 24, 34, 315, DateTimeKind.Utc).AddTicks(9760), new Guid("87a49b41-e17a-4720-9a3a-bc728556512e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(293), new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(294), new Guid("4473bdf5-c335-4f8e-8e75-969c7d3096ed") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(952), new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(953), new Guid("628d7d3b-67d9-4a0e-992d-a20af9f59eaf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(955), new DateTime(2025, 7, 18, 5, 24, 34, 317, DateTimeKind.Utc).AddTicks(956), new Guid("6979d943-52ba-4b6e-9f2b-70d74678ba2c") });

            migrationBuilder.InsertData(
                schema: "MetaData",
                table: "DocumentType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(405), null, true, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(407), "Client Details", 3, new Guid("860d6d43-5fac-4304-bdc1-027ddd4ffdd4") },
                    { 2L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(640), null, true, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(640), "Client Background", 2, new Guid("58b9516f-66b3-4c0b-aaca-4fb237097fe3") },
                    { 3L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(641), null, true, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(642), "Path to Maturity", 1, new Guid("cb6529c7-961c-4e05-a693-a1066abd555e") }
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2444), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2444), new Guid("747df2fe-59c8-4ee0-81a2-d191b683607a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2941), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2941), new Guid("da1455b3-ec0f-4f88-8e30-91dbf304df77") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RenderTypeId", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(2944), "['Microsoft','Google','Apple','Other']", 6, new Guid("759f8d4d-cfc5-46a5-8966-4ea31f2f2009") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3033), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3033), new Guid("c4321149-85f9-4a08-bf84-8015cf51d1c0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3041), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3041), new Guid("d5feaf07-c950-465b-bf31-3f42ae69c29e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3060), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3060), new Guid("79b1df97-16cc-4acc-ada6-b6b5bd6f712d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3062), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3063), new Guid("6e5532d9-b9f7-4850-8563-6fff8715e623") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3064), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3065), new Guid("9e280423-08ee-4bf2-86c3-2e42f538b3a4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3073), new Guid("6444f768-a511-4a03-bcbf-f5554d5736e5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3074), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3075), new Guid("36d6f9dd-941a-490e-a1c2-98b1e4082667") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3077), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3077), new Guid("4014ee47-dd8a-4427-879a-2780a507f0d5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3079), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3079), new Guid("9364a22d-28c7-4658-88fe-a1cbee7885f1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3081), new Guid("8bb33097-c7bb-417e-91fd-bade8f8d4294") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3085), new Guid("bb4b9004-e6ff-4c37-a78d-fb373b377064") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3087), new Guid("3e85d641-4437-4145-9aef-c909a6ecf805") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3089), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3089), new Guid("b4fa3a32-f9d5-46e3-9a5b-5ca32cae378a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3091), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3091), new Guid("233bf4b6-1642-4846-9541-8b77b8c15a11") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "Options", "RenderTypeId", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3093), "What SIEM solution do you currently use for ingesting and correlating security data?", new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3093), "['SentinalOne','Crowd Strike','None','Other']", 6, new Guid("fbf27a08-0def-4b6d-b790-a32c24a9477a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3100), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3100), new Guid("58a67db8-4f3d-4e06-935f-4f9d38292ca5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3102), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3102), new Guid("1f438e54-55ce-45a3-bde6-5c849a7d06d6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3104), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3104), new Guid("8ba53578-c54c-4c2e-a9f1-c3d10caaf7e4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3107), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3108), new Guid("7003680d-caaf-4ff3-98cc-d11ed1fadcbd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3110), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3110), new Guid("ce0f0278-6ebc-46c0-ad7c-f56f5901fc47") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3112), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3112), 8, new Guid("0f7f0611-08a6-46ed-9c88-25134ed975a9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3113), 9, new Guid("75b4b54b-d738-43dc-aa0d-2ae40c974035") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3115), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3116), 10, new Guid("db83715d-8552-4507-99ec-3ca6d6e32649") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3117), new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3118), 11, new Guid("ec17c3c2-c555-4054-89e1-7aadb2ace233") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Information",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "InformationSectionId", "IsActive", "IsDeleted", "IsMandatory", "ModifiedBy", "ModifiedOn", "Options", "OrderBy", "RenderTypeId", "RowId" },
                values: new object[,]
                {
                    { 28L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3119), "Have you Previously Conducted Penetration Testing? If yes, please mention the date.", 1L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3119), null, 5, 8, new Guid("e53e1d01-6e51-42c2-bd40-bf7b7d11e4e1") },
                    { 29L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3121), "What regulatory do you complain with?", 5L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3121), "['HIPPA','GDPR','PCIDSS','SOX','ISO/IEC 27001','NIST','CCPA','FERPA','FISMA','Other']", 5, 6, new Guid("a82bcbb0-3bfa-4722-bfac-c407856baf67") },
                    { 30L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3124), "What regulatory do you need to comply with for log data?", 6L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3125), null, 7, 8, new Guid("5828c72a-8d8e-41f2-a0a0-60cb1e745b68") },
                    { 31L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3127), "Do you currently have Cyber Insurance coverage?", 7L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3127), null, 1, 8, new Guid("8cf66f0e-09cd-44f8-a2aa-5b9c3b11ab5d") },
                    { 32L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3129), "Do you have an Established Incident response [IR] plan?", 7L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3129), null, 2, 8, new Guid("c12e67ca-90d5-435d-bfb1-874dacfb816c") },
                    { 33L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3130), "Who is your cyber insurance broker or provider?", 7L, true, false, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 326, DateTimeKind.Utc).AddTicks(3130), null, 3, 8, new Guid("b4d6adde-7e07-41d0-9bb4-d4286ee1f8dd") }
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6101), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6102), new Guid("e959fce9-d78d-4013-85c1-ca3daec18895") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6303), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6303), new Guid("86dd7ac2-f885-47ce-b2f0-4599f3c2a992") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6305), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6305), new Guid("5a642ce0-bbc6-415b-a238-f2469c5da01f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6307), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6307), new Guid("060eb584-3074-4e2b-bfd6-a6d486e2451f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6314), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6315), new Guid("49871114-87db-4861-89aa-005e14ef3141") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6316), new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6316), new Guid("479ca209-fefd-419b-b5e4-ae9abda1b140") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "InformationSection",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[] { 7L, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6318), null, true, false, 1L, new DateTime(2025, 7, 18, 5, 24, 34, 327, DateTimeKind.Utc).AddTicks(6318), "Cyber Insurance", 7, new Guid("58cfd1d1-436d-40fb-9efa-e0850a29b60a") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5669), new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5669), new Guid("61b8d7d0-b7eb-4d63-bf72-f304ae489e09") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5813), new Guid("536720bb-173f-4142-872f-8f9fbf6fbf03") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5851), new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5852), new Guid("8153b510-9338-4fa1-92a6-0ec9607fdd41") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5853), new DateTime(2025, 7, 18, 5, 24, 34, 330, DateTimeKind.Utc).AddTicks(5854), new Guid("26367f71-372c-4a4a-b5a3-4af8ddd578f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(4644), new Guid("a7475556-d7d7-4f1b-8ce1-0ae298f40e3a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5094), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5094), new Guid("8cf9f2dc-cdd0-41f7-b2a4-928541620730") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5096), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5097), new Guid("ac131aa6-9556-410e-bb37-ea276d84e14b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5099), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5099), new Guid("38320922-6d5a-406b-93bd-00f9722d42a2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5101), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5101), new Guid("ff2b9f76-3ef8-45b4-bb9e-309002882922") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5102), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5103), new Guid("fe856e9f-0cc5-4ee8-b521-7071a7f38fff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5125), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5126), new Guid("498e0b61-1fd8-4b31-919c-7a2d63fdcf1f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5127), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5127), new Guid("9f56a9e6-86ab-4910-bb33-5db2752cdb5d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5129), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5129), new Guid("2c7741c7-99bd-4000-aa44-924d003dd683") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5130), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5131), new Guid("868517c5-5404-4b66-a955-1408311be9de") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5133), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5133), new Guid("e3d3e5d6-7fb7-4880-9e93-3af51937edcb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5135), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5135), new Guid("cf231d15-1370-4ced-a20d-b38ea5f52be1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5137), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5137), new Guid("afcfa3aa-89bf-495a-8bde-fadc3fd0d664") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5138), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5138), new Guid("1ac17894-e29f-4442-969e-5f1527617171") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5141), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5141), new Guid("65a91d47-fcb7-448c-98b0-9762565ac574") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5143), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5144), new Guid("ad8d6d94-b357-47d2-a5e9-02de1b264f83") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5145), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5145), new Guid("a397e7bf-6c09-4a8a-8f59-ffb8872cfaa6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5147), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5148), new Guid("fe3387e6-d429-4bbe-85af-ba5fac20b186") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5149), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5149), new Guid("81e70b3a-7373-4d09-9699-568be0def3d4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5155), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5155), new Guid("dd054525-a35e-400a-b51b-7e4ca862bd5b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5157), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5157), new Guid("babee1d6-bc4e-4b0a-baf3-5e2d846cdb80") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5158), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5160), new Guid("82934cfd-9309-448a-9ff7-2c2d66320fe3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5162), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5163), new Guid("66b9db38-6ba3-460e-a669-37e8fd05a6f2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5164), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5165), new Guid("d732ced7-6139-4079-85e3-794c6b3156d7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5166), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5166), new Guid("98205c46-aa12-457d-b55c-8815527a2922") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5168), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5168), new Guid("de4fa784-5edd-4125-bf13-bb735167e69d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5169), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5169), new Guid("e4d3f946-00b9-4dfe-983d-f768aa9e6f23") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5171), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5172), new Guid("d570639b-f86f-4653-ac78-33ace16aef93") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5173), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5174), new Guid("6c2522c5-fd76-41df-9ab6-0f83c05d531c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5175), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5176), new Guid("0789c0fa-03a4-4408-8cf9-6623e6a9a569") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5178), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5179), new Guid("b385956e-936f-447f-8a8e-477f577dd206") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5185), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5185), new Guid("192dcb33-84e7-4f47-87ac-45b84bea4352") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5187), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5187), new Guid("a54bf57e-1f59-492c-8c49-2cfeb4522b35") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5188), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5188), new Guid("6242de16-5bf0-47fe-9d45-38299f36a814") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5190), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5191), new Guid("2c240d03-0e91-4ee3-b2d3-43c61c7f0eab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5192), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5192), new Guid("d7cbd35c-9e38-4f6b-aa4b-07fd7c20c2e5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5194), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5194), new Guid("e6f1f17c-3a6e-425b-ba89-062eb8268944") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5196), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5196), new Guid("8a2165db-c012-423d-a296-f0d6086dde7f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5203), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5203), new Guid("e5750d7b-5415-4296-8c30-9dd33cc93794") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5205), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5205), new Guid("06ed7aa2-0278-49c8-b3db-5caa847eff76") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5206), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5207), new Guid("6e552b50-6a45-48b7-91f9-8a25c3f4e8ab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5208), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5208), new Guid("f7265e7c-3dce-48a6-91f7-394b48cd653d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5210), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5210), new Guid("f3f8c180-35c9-4b46-b3ba-f95027a9f741") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5212), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5213), new Guid("2182043f-4b72-4e25-8295-452ebbf2384b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5218), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5219), new Guid("32f4dc6b-9d17-40f8-92a0-559587cefc8a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5220), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5221), new Guid("2dc41fcc-9618-4f35-9498-8bf215732f71") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5224), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5224), new Guid("fa1f6142-5c5d-4110-9f95-834e0598c196") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5226), new Guid("f3a2a6d1-2d67-4fcd-b042-29d71354eb2e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5227), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5227), new Guid("84e8c900-bc6a-48be-ab74-bbdbd2e6556f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5229), new Guid("c2e8aa9d-43b1-4f07-bc9b-a30f67b274d9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5230), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5231), new Guid("42fb912a-2aef-45ad-a574-8937a94cad90") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5233), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5233), new Guid("8cc8d689-973a-4a3d-b630-a5dd5cd1a684") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5235), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5235), new Guid("92086163-b183-4de2-8a24-52dfcdec44a9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5237), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5237), new Guid("b801783a-7bcf-4fce-8cb7-d41e111b81ab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5240), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5240), new Guid("bc505bf1-affd-4d09-b783-3d205c9a3a40") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5241), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5241), new Guid("fa61a1ea-f881-48f5-ba5c-1e8e3e092af6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5244), new Guid("d49de25e-4e88-4021-88b6-4140abce910a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5249), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5250), new Guid("0f27a110-0c6a-4690-9b99-fe68751b263c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5252), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5252), new Guid("997abe0e-8ed3-4eed-9343-35bcae5da9f0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5253), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5254), new Guid("99a56cb2-e284-4df3-94d4-2459d0acf572") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5255), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5255), new Guid("0d5d28d2-e937-43d4-9891-485facabbdfd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5257), new Guid("60a73766-01ad-4f17-a93c-915328d0ce92") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5260), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5260), new Guid("9add6e25-aedf-4d00-b46b-2237802f94d9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5263), new Guid("966501c6-f0cf-4868-8414-20ff2da6f90a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5264), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5264), new Guid("7c182ab9-a1e1-46e6-b0ff-c0c9e73fe605") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5266), new Guid("91ca3d65-5032-41da-8c15-ed8f7a25995f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5267), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5268), new Guid("d80bf782-bd52-49bf-b465-afffdd3c7c2c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5269), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5269), new Guid("a7a68c85-d765-4e75-b766-f61d2a8da99b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5271), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5271), new Guid("809fc63b-3a76-43e7-809b-fd57503c3995") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5277), new Guid("fad2eed2-5738-4d7c-b4df-07345a20dd05") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5280), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5281), new Guid("72ea1035-bbfa-48e0-9999-4dd57bd1c960") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5282), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5283), new Guid("af509134-cfbe-4a2d-ba56-89b6218dcb6c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5285), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5285), new Guid("c0dc9db2-816b-4e8d-8d26-9894e80db29f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5287), new Guid("cbd68cf1-3237-49c3-ac38-7718cf23d01c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5288), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5288), new Guid("2742d675-2dc4-4683-8d89-769ae5950000") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5290), new Guid("ddecc86b-adc7-4399-acf8-2b18e5920417") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5292), new Guid("607697e2-1841-44f8-8596-acd38bcca2fb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5294), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5294), new Guid("e36f8067-d43b-4f72-928f-7c90846ac976") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5298), new Guid("e169ecbf-9ca2-499f-8537-67771e93a67a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5300), new Guid("4a63261f-ba1f-4bf3-9116-3c966e6ce5b9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5302), new Guid("f7afb265-6571-4a8c-a724-e43946fc7a98") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5303), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5304), new Guid("b91694cf-a90e-4f83-bd6e-2bb269b84c1f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5310), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5310), new Guid("baa0238c-67e4-4fe3-9e3c-a4eea7cbf593") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5312), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5312), new Guid("b5ad2974-2259-4899-a4c9-e2c24132d183") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5313), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5313), new Guid("8b64b94c-5382-4e04-899c-91d46d2fe0d5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5315), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5316), new Guid("7ce26e02-b50e-434a-abde-368997c0020c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5318), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5319), new Guid("d048966e-860d-4d17-a03d-0305c37a752a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5320), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5320), new Guid("c4bdfbf6-ada6-4a3b-b07c-72690edf9215") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5322), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5323), new Guid("e6255281-e47c-4829-aad9-2d7b47bf10ae") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5324), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5324), new Guid("2543a6c1-4f07-414a-9fe1-ce84de5dd1ab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5326), new Guid("694a1fff-82fb-43ba-be2e-4e91809f23f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5329), new Guid("9af1ca31-bec1-4ae2-a633-42b3e3227c04") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5330), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5330), new Guid("fc81db5e-5e25-42d8-9148-ea0ef4905211") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5332), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5332), new Guid("b7d3f704-3d39-4a23-9698-6ff6da101b26") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5340), new Guid("9c780957-cd4b-4dfe-8d42-2d51ecb9d7fb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5341), new Guid("918e6d01-4a8b-4985-aaab-54634ae91b6e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5344), new Guid("b1d40f5b-71f4-42c2-ba14-047f3d4ce805") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5345), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5345), new Guid("0c9f3c02-7629-4bd1-88f6-a86a89445340") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5347), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5348), new Guid("a3e5b283-9d6f-4cb0-8e12-324865c9a925") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5349), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5349), new Guid("35124d87-5674-4585-a12c-03a3cfd27c75") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5351), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5351), new Guid("b3d7b61d-4fd0-434e-97f5-6fd33e2a7d86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5352), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5352), new Guid("ca3c3f4e-cbc6-4cbb-9c4f-d8be70328601") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5355), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5356), new Guid("e03d87be-487c-4bbf-9cbc-cebc79ec6bdd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5357), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5358), new Guid("d9ba4e87-ea10-4f3b-b910-ff0d5fcde88c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5360), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5360), new Guid("b266753a-d13b-4097-a779-55e17060f6f0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5361), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5362), new Guid("6d514995-b000-4899-a61e-5aaac43eb90f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5366), new Guid("96b7d06b-8c71-48e8-9905-8f0d4ba19904") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5367), new DateTime(2025, 7, 18, 5, 24, 34, 335, DateTimeKind.Utc).AddTicks(5367), new Guid("eb3149da-5e80-442a-ad0a-26d3c00c4c22") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4110), new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4110), new Guid("fd34a9b2-26db-48df-8f1d-1aa4abc6fc9e") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4113), new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4113), new Guid("793a6d03-585a-4afe-ba56-40aada50bec9") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4119), new DateTime(2025, 7, 18, 5, 24, 34, 329, DateTimeKind.Utc).AddTicks(4119), new Guid("0341c87c-3aa9-4823-b116-5035d98a7201") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1026), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1027), new Guid("0ef4db5e-e987-43a2-b329-bf15c000a777") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1029), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1030), new Guid("0da6be4e-a770-454e-94e4-fde55ea7fc00") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1135), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1136), new Guid("bbe45e9e-c6e3-4836-8772-02b918aab657") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1141), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1141), new Guid("51124c42-4327-4a9d-935e-6d5a31ea8147") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1143), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1143), new Guid("7d7da920-6ebc-41b1-a986-4cd3084bb372") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1144), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1145), new Guid("ede69a61-880c-4094-97ed-f6257389572b") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1147), new Guid("f731b936-75d1-44e0-8059-be579cc883ac") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1149), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1149), new Guid("2dffec13-2a70-4178-858d-f831910656f0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1151), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1151), new Guid("9c86d267-4884-4bcd-be45-0e52e58d21b2") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1152), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1153), new Guid("0ee99b31-e533-491b-ab8a-600ef5867613") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1155), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(1155), new Guid("2d31a1a0-7849-4d18-a5f8-c1d7b390cb50") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(4288), new Guid("7f461a0b-bebb-4590-957e-831593b85aef") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(4291), new DateTime(2025, 7, 18, 5, 24, 34, 331, DateTimeKind.Utc).AddTicks(4291), new Guid("6f9b015d-afec-4539-b1af-51dcfeb7de80") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 336, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 7, 18, 5, 24, 34, 336, DateTimeKind.Utc).AddTicks(244), new Guid("138b87c2-bf0f-4dde-afbf-93fa52d10f53") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2440), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2441), "IDENTITY (ID)", new Guid("b6dded12-55cb-4912-b36e-2636ecf32f76") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2893), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2893), new Guid("7a46c9ef-7b9f-4420-97f7-99d11a58fae3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2899), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2899), new Guid("53ec5ef5-42a4-4980-8071-da229a0a2d78") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2901), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2902), new Guid("7b8d4625-e90c-4175-86eb-2e4e622f9ed3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2904), new Guid("aff0fae0-94e2-4abe-91c6-041ba7f3da0d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2905), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2906), new Guid("98e44937-8476-4ea0-9206-1158c457182b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2908), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2908), new Guid("d2ffd61e-b845-4958-8512-7d759299ee89") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2916), new Guid("e7a027b1-ecad-4a7a-bcf5-a976d4f4550f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2918), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2919), new Guid("8d92e4bb-edb4-4cc0-8aba-94d210139184") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2922), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2923), new Guid("5178a855-b562-404d-bcee-c7b578bbdd98") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2924), new Guid("9e4d4a1b-c3ed-469c-923a-b606b5005823") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2927), new Guid("70a16142-25e5-4cfb-be12-ff4e5db7f2c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2928), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2929), new Guid("f9c3d90b-e288-448d-a9d0-dad2a2c2f2a1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2930), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2930), new Guid("489a7417-3b7a-4a12-af64-6d55e97a3157") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2933), new Guid("900a0e1a-4236-4581-b04d-2339c74b1b31") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2935), new Guid("6beb7806-7913-4030-b401-f898c3c2f887") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2941), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2941), new Guid("a0e9d514-8ee3-453a-af94-32f0f34c709b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2944), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2944), new Guid("a06ffac6-c5d7-4deb-a0ef-776629d8fd3c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2947), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2947), new Guid("f8038c55-1f3e-4b9b-be2e-524a01c5fb92") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2949), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2949), new Guid("57f28936-a1c8-41a7-80e3-9c4399af76e2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2951), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2951), new Guid("15dc9131-6a31-4a5f-ac0c-235b7adf78ac") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2953), new Guid("1673534a-b95e-48ad-9f39-9abc39013430") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2955), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2955), new Guid("1e5f750f-7c1c-42bf-aff5-66acf14f6d46") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2957), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2957), new Guid("7c9a27b8-3272-4c9d-860e-487e7977242a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2958), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2960), new Guid("5fd5946f-08cd-4076-b63b-3e23bd5a7987") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2963), new Guid("e95d65b1-13f4-4b11-b2ee-71d7f2d7c891") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2965), new Guid("c890e165-8555-4179-b98d-f7aa31228416") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2966), new DateTime(2025, 7, 18, 5, 24, 34, 337, DateTimeKind.Utc).AddTicks(2967), new Guid("e5703b72-d026-4782-aeb1-bbc8ca462adb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1210), new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1211), new Guid("0f08c205-2e4e-4591-a4ed-5895aace3004") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1829), new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1830), new Guid("a5fe087c-484c-4690-b509-987ced55d4d4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1833), new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1833), new Guid("02647125-e070-4c50-91cc-d9982849cbc9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1837), new Guid("5ab05795-2e53-429a-84ea-fb985451c96a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1838), new DateTime(2025, 7, 18, 5, 24, 34, 338, DateTimeKind.Utc).AddTicks(1838), new Guid("6c4c036b-1edf-4e57-9349-6666b9ccd0ed") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTemplateDocument",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientTemplateSectionSolution",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "DocumentType",
                schema: "MetaData");

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.CreateTable(
                name: "ClientTemplateMaturityPath",
                schema: "Dcube",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ClientTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    EndPointDectionResponse = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Gaps = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ManagedDetectionResponse = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    MultiFactorAutentication = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    People = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Process = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RemediationPoints = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplateMaturityPath", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(3685), new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(3688), new Guid("6e0c4b63-e9b1-45c6-a76f-3e1ca1174a26") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(4089), new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(4090), new Guid("083a6c4b-fb76-45ab-a113-facdc1807587") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(4091), new DateTime(2025, 7, 7, 3, 47, 57, 141, DateTimeKind.Utc).AddTicks(4092), new Guid("76759cc7-257f-4bb8-a780-5e83390d7027") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(4495), new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(4496), new Guid("12f3033c-91d0-4c2b-9586-b8e63ddc3f27") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(5164), new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(5165), new Guid("5f7eb52a-1cff-419e-8f23-cd713bd6839f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(5167), new DateTime(2025, 7, 7, 3, 47, 57, 142, DateTimeKind.Utc).AddTicks(5168), new Guid("ec989639-7d97-40f4-8b66-84473bd1358e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(2595), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(2597), new Guid("63b73803-e190-45f2-be95-afe7df66597b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3093), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3094), new Guid("b39bc872-5fa6-47fe-b725-c512e1aa3cd0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RenderTypeId", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3096), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3096), null, 8, new Guid("93ba463e-6b25-4f75-abe9-2dd1d089f8c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3097), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3099), new Guid("0cfb88fa-7b9c-4de7-a107-5d59dc3bbbd1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3108), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3108), new Guid("902bbb68-c643-43ee-9e14-b861d69da53e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3110), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3110), new Guid("623a1442-86ba-4d43-af11-6c7179c83bca") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3113), new Guid("16623193-a273-4c20-939e-31e05f05635b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3115), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3116), new Guid("397bbb34-2c7e-43af-be1f-eb83f3146a00") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3117), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3117), new Guid("602c780e-be71-4e3d-a4d1-369bf5608f29") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3127), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3127), new Guid("040b1bc0-7db6-4326-b024-8d7fb6f521df") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3129), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3130), new Guid("0c5d81d4-dbe8-4f34-8fc0-f26d2aff5ea9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3131), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3132), new Guid("95e11a0c-620a-49b0-a0dd-c17274af0765") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3133), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3133), new Guid("d9d6dbe4-553e-4f30-b892-bf2fc8c9f2d3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3135), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3135), new Guid("bcc0682d-6265-4f65-808d-8bc7f717ac7b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3138), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3138), new Guid("4efeacec-8987-491a-b319-dc5a2ee20447") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3139), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3140), new Guid("5d23bd87-6cca-407c-b79b-f82467ba0f07") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3142), new Guid("447e0dec-b6ec-4700-b46c-6a264e5d7654") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "Description", "ModifiedOn", "Options", "RenderTypeId", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3146), "Do you currently utilize a SIEM solution for ingesting and correlating security data?", new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3146), null, 8, new Guid("087dd2ea-7185-4f3c-bad2-ae806c057cf5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3147), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3149), new Guid("3de78f0c-a281-454c-93b6-fc75458a1336") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3150), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3151), new Guid("3ca85743-cf3d-4182-b656-a36b1caf8dec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3152), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3152), new Guid("976c78f8-e19e-473f-939a-44f210d1241b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3155), new Guid("0df22c7a-10ad-46cc-8201-e4e0fdfbca99") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3156), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3156), new Guid("3fdd0397-eda1-44b2-bc79-df84c01666c2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3158), 7, new Guid("c2ddf3d0-bd7f-4f1b-b87c-30a7f8c46951") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3161), 8, new Guid("a459d5dc-bfd9-4322-b837-ec0ac950e8d2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3164), 9, new Guid("70c2fffc-5ee5-42cb-b472-c5a1084ec651") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "OrderBy", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3167), 10, new Guid("f703eb3b-8d3b-4616-95ee-37d7c099d296") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(6991), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(6992), new Guid("aefe7a67-d1a3-4a86-919f-ace533a8d4d4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7201), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7201), new Guid("3c4f24e9-7cef-4e9b-af01-509008852fde") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7202), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7203), new Guid("63f95ffe-cd08-4447-96f2-17d0e6b22f99") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7205), new Guid("ee23a6da-4523-41ec-9054-7d3e62b88966") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7207), new Guid("f58ea272-86fe-441e-b22b-d9219f608be0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 7, 7, 3, 47, 57, 153, DateTimeKind.Utc).AddTicks(7208), new Guid("7380b36f-c307-479b-8371-66f4417e7e2d") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8306), new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8309), new Guid("868d3f8b-5270-4121-bdab-63f99c6dc2d0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8624), new Guid("66d310eb-8f53-40fb-929e-5448eff7c346") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8752), new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8753), new Guid("700c9f71-ae7d-4e65-8f8d-310f1ce4e958") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8755), new DateTime(2025, 7, 7, 3, 47, 57, 156, DateTimeKind.Utc).AddTicks(8755), new Guid("4b0a548d-81f6-4045-b08c-a270f94ab684") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3271), new Guid("59ecd8fa-ce94-4371-a522-96f24303a970") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3817), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3818), new Guid("37ce5b9d-1741-4acc-9a39-d7da7135ac64") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3820), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3820), new Guid("59389f11-8fed-406e-b34a-d0d4046db19f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3822), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3822), new Guid("bc352149-841c-4972-a44e-596148655016") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3824), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3825), new Guid("2546f745-5c3b-4256-8497-9fc522a0d8d8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3826), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3826), new Guid("c6285d71-c5cf-4912-a826-c76a02b55a46") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3828), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3828), new Guid("e62f6e87-9f15-4f09-a527-f71a1d1d1d51") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3849), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3850), new Guid("1278251c-494c-4bf6-bb37-466227fb78a0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3851), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3852), new Guid("c84c2645-1eb2-4e80-a410-d30cb5e06392") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3853), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3853), new Guid("c25a831d-d012-4145-8d63-941d1c3278fc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3855), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3855), new Guid("ce2ec44e-408b-403a-8f15-d2e6fd5c9005") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3856), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3857), new Guid("0be1340a-6753-4426-850a-ffa3990adc41") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3859), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3859), new Guid("f23d02ba-a484-447f-b67e-2729e9b30504") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3861), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3861), new Guid("5365a0e4-571b-4ca3-8ed4-fd788010f9d7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3863), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3864), new Guid("2a3813ca-e7de-4721-95ff-68d2089f056d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3867), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3867), new Guid("cb08a4c4-83ea-4f67-9a65-444f73558d3d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3868), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3869), new Guid("60009f36-4fd5-49b9-adb3-6378acf1a381") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3870), new Guid("e8c29c87-a4c5-432c-8303-7e8894a93336") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3872), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3873), new Guid("93cb8964-fc79-4006-b5b7-5ddc15e03973") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3879), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3880), new Guid("369275cd-7268-4b98-b9bf-69616f2cd69f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3881), new Guid("ebcc9f1c-ea30-4357-bf26-9f66e0e2e91f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3883), new Guid("0b1bf4be-c65d-4aef-b724-edd59a69382c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3884), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3884), new Guid("b0062d58-5648-4029-85da-e1dea5539d9b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3888), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3889), new Guid("50a9d426-9469-48fa-baad-d520b0ad6722") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3890), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3890), new Guid("77a79378-2d68-434c-b959-1853ea7be049") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3892), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3892), new Guid("a3e9cc9c-70fa-4bcb-8c47-48ad666cfe23") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3894), new Guid("62b9371b-7d85-4543-b551-838d8bd55ce6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3895), new Guid("7bfb9e16-3a8c-4c3a-a45c-57d142ecf0a7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3897), new Guid("a4eb0548-c430-4f0b-8bfd-5d63e4591757") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3899), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3900), new Guid("72a3baba-f6bf-43c9-9b1c-a573703c8a8a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3901), new Guid("fc4744c6-c5ea-4990-89fa-97875bc68328") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3905), new Guid("25efdeb2-20d5-4600-b034-91694204664f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3911), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3911), new Guid("9b05b189-7162-49ea-8716-0d6773d49f6f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3913), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3913), new Guid("fd106836-ca10-4b6d-aa33-dae5ccf0cf98") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3914), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3914), new Guid("a7f48cd6-9d90-4aa5-ac47-ae0f07047976") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3916), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3917), new Guid("0eff7190-4963-4bde-a457-78f34982d44d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3918), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3918), new Guid("4578b60c-3ce7-4d0c-b7aa-8e88fcfdc532") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3920), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3920), new Guid("d6b96604-1db2-4793-a4da-e2f7f9c37650") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3921), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3922), new Guid("1458d415-0dc5-4f71-a17c-692c516db80f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3929), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3929), new Guid("9063b5a3-1aa7-47e9-9815-61f9d07cabd5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3932), new Guid("b8941295-73aa-4ffb-b69d-6973c42419e8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3934), new Guid("047f2134-2123-4abf-9232-bc5a51a1325e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3935), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3935), new Guid("2b1ab577-af7d-406a-83bd-00223ce9c325") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3937), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3938), new Guid("e3dd0e7f-f25c-4be5-89e4-b0d25ef46453") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3939), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3939), new Guid("0cdd40c4-15d7-4d61-89da-3b2531c49454") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3947), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3948), new Guid("7b622547-c41e-4922-ad45-3caac25a579e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3949), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3950), new Guid("c464dfcf-2bc5-43ed-9b91-d27c9734bd8d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3953), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3953), new Guid("8f594095-548f-4518-8672-365eaf361996") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3954), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3955), new Guid("57ba2a13-e44c-4424-9701-87bdf9324447") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3956), new Guid("edcabea6-8695-47f4-a615-cb86e46a9d3f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3958), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3958), new Guid("745cf6ea-8520-47b8-97f0-ae9f9f03378f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3959), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3959), new Guid("b53edd36-2890-4acb-9ebe-0c3e933d9a1d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3961), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3962), new Guid("c1623938-5b22-4bef-8a1a-055deccedc89") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3964), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3964), new Guid("1d30e339-861a-46cc-86c0-b782bcbfd329") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3966), new Guid("556487a7-4230-460a-8d7c-f051d5fecbc6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3969), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3969), new Guid("4dce77d6-d9a0-42c8-bbb2-ce5a0a7726d5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3970), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3971), new Guid("c5708a3f-33a7-462a-b67a-6fe8ccf93407") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3978), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3978), new Guid("90d301bf-29ee-4817-9792-b55d669fbfaf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3980), new Guid("9ec244f4-8d6a-4101-8f1f-47b68302cbf1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3981), new Guid("8267a101-a397-4c9b-925f-551cee92f927") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3983), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3983), new Guid("826596bc-b589-4e90-a302-44d97e46c277") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3984), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3985), new Guid("b7d32834-7679-48a7-8e01-77f72b6a1fa4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3987), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3987), new Guid("3c2c93da-242a-4559-a68a-4a0fe9bb62f1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3990), new Guid("664fee97-468e-4c1b-943f-ea9382ab781d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3992), new Guid("6397ff87-3c44-4697-adf5-cba2a9c669c2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3994), new Guid("1f6d508c-5e4b-44a3-8cb6-8c12463d04bc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3995), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3995), new Guid("64d75342-214d-4bc0-b6b0-2ade03c99f4d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3997), new Guid("82b4b3dd-2de0-4f28-b359-e09ef61e886c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4000), new Guid("885b8f72-cc52-480f-8a95-295bdd0cdbef") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4001), new Guid("577b11d9-b3b5-482d-b8fd-36ecadf81f23") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4007), new Guid("8c0996cb-a537-4617-abfc-5ef7edd7c5d8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4011), new Guid("7d35fe76-9c41-4af6-8960-4a90a8a3dc93") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4013), new Guid("372a82ed-f50a-4fad-ba6b-d5142df1b3cf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4014), new Guid("4240d331-d8af-4387-84d9-689334bef072") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4016), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4016), new Guid("73541ae0-c24d-45c6-ada9-b9e9f17a810c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4018), new Guid("eb0eaa70-265b-4bbf-81b9-045f4a0dfedd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4020), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4020), new Guid("89d35b14-cecf-45fc-a97b-358f2c568f17") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4022), new Guid("95e2285a-0ef8-4aeb-805d-5aaf265420af") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4024), new Guid("fc0998ce-80d5-44fd-9edd-953eac743553") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4027), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4027), new Guid("5ec8a5f5-0727-42a8-b65b-258711c97e79") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4028), new Guid("b7153fdd-e564-4c11-a16b-ae010065bdb7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4031), new Guid("44547da2-16e7-4228-b340-af39ea3a64ae") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4037), new Guid("9c677dde-0388-44d2-894c-32a79f4b580d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4039), new Guid("cf468401-896d-4a77-89be-c608dc898a57") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4041), new Guid("850d5dd0-9f5b-4299-bcf3-2001b3bba0b5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4042), new Guid("77625650-abc5-4edf-b7e0-496d2b0ebb29") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4044), new Guid("bc33ae1a-1799-423b-a565-ad031ae86024") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4047), new Guid("55018929-2ae8-42b5-8099-a679e55a698e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4050), new Guid("9d1b9e7f-39cb-427e-9f48-d0d47bf39a7c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4051), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4051), new Guid("2360720b-9776-4f7e-a9d8-c5c0b86353b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4053), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4053), new Guid("b637b449-db93-41f1-b29e-02666907e4ff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4055), new Guid("5adfe460-2ad7-44c8-874d-a3f6dbb0dfbd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4056), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4056), new Guid("67ebefbf-52c1-4699-ae7e-9874bf7652cc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4058), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4058), new Guid("61d6c084-be8c-4d09-ba81-16d5b633cc69") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4059), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4059), new Guid("56b4babb-3d47-41ad-9b19-5ffbffa29b7e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4069), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4069), new Guid("adf50add-9d13-4856-b526-4577cae82627") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4070), new Guid("9699f744-f550-4ea2-a8f5-f9ed475e36ce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4072), new Guid("4d780075-e26b-4c7a-aa94-bb6b01567293") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4075), new Guid("79fd7ce6-0f61-4026-aed1-1ffcf41adcc2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4076), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4076), new Guid("133869c3-7cf3-49a6-98aa-519ea43de935") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4078), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4078), new Guid("e7d77f9b-9e0c-4601-b55b-108bed488394") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4079), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4080), new Guid("6abc9034-fb3b-4b47-ba2b-41957285a656") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4081), new Guid("255a9d45-6201-4035-8f4c-0008720ae4ca") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4084), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4084), new Guid("8a5805e3-5876-4c6c-bc3b-f94c6eb2f402") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4088), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4088), new Guid("3e343eba-f9ac-4757-90de-efdf46b7273a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4089), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4089), new Guid("aa02c82f-bd7b-4f34-93c0-6c25c1e70fbf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4092), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4092), new Guid("5a8d6a3a-554a-4fb3-9aac-cfd7a6cecfde") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4095), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(4095), new Guid("ec584e09-6c12-4fca-bc4b-ad0126b74dd8") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9138), new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9139), new Guid("f8838517-f856-4af3-9ff4-675fcaeb5807") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9791), new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9793), new Guid("c1d36b6f-188a-453c-b4a9-166eb2b34174") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9795), new DateTime(2025, 7, 7, 3, 47, 57, 154, DateTimeKind.Utc).AddTicks(9796), new Guid("ddf18d70-9f9f-4ef0-adc4-f4b012811249") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5702), new Guid("f0043675-7227-4e2f-8dc1-cfe3bda969c3") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5703), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5704), new Guid("08bd40dc-8e5b-42d2-bdc8-5f17b57faf57") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5875), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5876), new Guid("4df6fa54-10fa-4137-850c-80cb8f427f54") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5879), new Guid("e463a6eb-3fec-4001-b87a-aaaad6130096") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5891), new Guid("4b15a5d1-053d-44f3-ade3-bfaa756f4431") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5893), new Guid("a55e6a8f-b4f6-4dc2-ba49-330dc4d20114") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5895), new Guid("2e4f9451-bbce-498d-b767-e3294ebcdd54") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5897), new Guid("e3c980b2-8c50-4018-9374-354a855ec594") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5899), new Guid("bc8fac54-6326-4c3f-af8f-157136180489") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5901), new Guid("00378b1e-35a1-469c-8c8e-cdf4b6a81911") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5903), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(5903), new Guid("83569ba6-ebfd-47cd-acf7-224ea5aba948") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(9398), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(9399), new Guid("9887ddf7-86e7-44d5-b441-a355655182bc") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(9408), new DateTime(2025, 7, 7, 3, 47, 57, 157, DateTimeKind.Utc).AddTicks(9409), new Guid("ef6f9809-03df-4dca-a67b-a359da6a2b19") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(9592), new DateTime(2025, 7, 7, 3, 47, 57, 161, DateTimeKind.Utc).AddTicks(9592), new Guid("27d29feb-5929-4340-ad2c-12f6e40344fa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4061), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4062), "IDENTIFY (ID)", new Guid("6a753fdc-b446-46d2-9950-a0ce1c13134a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4548), new Guid("c9e1302b-55ab-46e4-8867-21a6dfc6fc34") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4563), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4563), new Guid("9c90f173-7a75-49f2-a2ab-7be40847be98") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4566), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4566), new Guid("a6616351-9209-4122-bbcf-107f8e114dec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4568), new Guid("505f86a9-d412-44c7-b7ec-1903de84e695") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4570), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4570), new Guid("b445ba51-15fa-441a-9283-492e697d7a82") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4573), new Guid("430763f9-08f5-4be0-9e74-043abd304728") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4583), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4584), new Guid("70291434-fe85-4bf7-92b3-dc29e4965da9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4586), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4586), new Guid("536daaf8-9cab-4778-bd89-b241eb2896b7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4588), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4589), new Guid("105fe5b8-d855-4285-9953-a3e726f1a76f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4592), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4592), new Guid("2bd37e59-67a4-43d7-8620-5337d774173a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4594), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4594), new Guid("fcc204e9-00e4-43ce-a5ee-889954ca76f2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4595), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4596), new Guid("cafb296e-2838-4385-a98f-b2dd79362978") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4598), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4599), new Guid("5c19e7e8-7d57-4493-8cbc-1a654ce1553c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4600), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4600), new Guid("c1fb5c51-6dd8-4cc0-9efd-cc207f77cf3b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4603), new Guid("6f5a396a-86f1-42df-b6c6-68b61db749cf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4605), new Guid("172ce43a-06e4-42f5-a3df-36c6710c02da") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4613), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4613), new Guid("53f1af17-e45a-4313-9e16-635594b11227") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4616), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4617), new Guid("597e9ed2-dc1e-4390-8c52-5efbda8a1719") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4619), new Guid("70747d4b-537f-435b-9ca7-3101448e7a12") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4620), new Guid("83b7649d-3e3f-4aa9-8610-636683cb5422") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4623), new Guid("73cb1ac4-dc6a-4d2f-aec4-7b033f46cb38") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4625), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4625), new Guid("b947511e-f618-4672-89e9-d58fd3506cbd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4627), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4627), new Guid("cd8734f7-46bf-45a6-88e4-e165428536bb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4629), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4629), new Guid("6f67bd05-573b-4051-a242-6821df6963ab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4631), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4631), new Guid("61277b2d-ae56-47cf-8d37-5b51d0928815") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4634), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4634), new Guid("80ca2aca-1c88-4df9-9c8c-085d95fb04dc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4637), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4637), new Guid("91425ebf-f496-4c11-a3f0-bd9178476caa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(2826), new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(2827), new Guid("100d08e3-5470-46ab-8b6d-ad195a21838a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3524), new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3524), new Guid("de48cf12-63c9-484c-a212-988d3467ae90") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3528), new Guid("47c70a92-6ff8-48cb-85d7-d936bbe4a3dc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3531), new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3531), new Guid("387b16c4-5834-40cf-a561-60953b573c4a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3534), new DateTime(2025, 7, 7, 3, 47, 57, 164, DateTimeKind.Utc).AddTicks(3534), new Guid("1c7f0554-d19c-4924-b95e-e5e996c0001f") });
        }
    }
}
