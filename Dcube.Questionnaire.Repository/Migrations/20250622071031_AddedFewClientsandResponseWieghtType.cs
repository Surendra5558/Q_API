using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedFewClientsandResponseWieghtType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "QuestionResponseWeightageType",
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
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResponseWeightageType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5259), new Guid("465d84f0-0379-4429-9267-da88d4aaaa28") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Client",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "RowId" },
                values: new object[,]
                {
                    { 2L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5666), true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5667), "KonaAI", new Guid("591acafb-4647-4962-a9d6-d8639abcc322") },
                    { 3L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5668), true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5668), "BCCI", new Guid("df226c38-5577-40cb-a4e5-f7de563f703e") }
                });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "ClientExtension",
                columns: new[] { "Id", "Address", "ClientId", "ContactPerson", "ContactPersonEmail", "ContactPersonPhone", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "LegalName", "ModifiedBy", "ModifiedOn", "NumberOfEmployees", "NumberOfExternalPartners", "NumberOfLocations", "NumberOfSuppliers", "PhoneNumber", "RowId" },
                values: new object[,]
                {
                    { 1L, "Hitech City", 1L, "Krishna Chaitanya Kona", "kkona@konaai.com", "4012020000", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4122), true, false, "Dcube Pvt Ltd", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4122), 50, 0, 0, 0, "4012020000", new Guid("1f4e1092-ab04-4754-a483-3ef67f99d975") },
                    { 2L, "Deloitte Drive Hitech City", 2L, "Chaitanya Alluri", "calluri@konaai.com", "3012020000", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4819), true, false, "Kona AI LLP", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4820), 100, 0, 0, 0, "3012020000", new Guid("042b851a-386f-4f4b-acb2-058a941a412a") },
                    { 3L, "Wankandi Stadium Mumbai", 3L, "Jay Shah", "jshah@bccicontrollertest.com", "2012020000", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4823), true, false, "Board of Cricket for Controller in India", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4823), 10000, 54, 50, 401, "2012020000", new Guid("df0dbc06-861c-4e45-a81d-b0f815877561") }
                });

            migrationBuilder.InsertData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId", "Weight" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5437), null, true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5437), "Yes", 1, new Guid("57b39e48-371d-40ce-8764-41bbe4acc386"), 1m },
                    { 2L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5568), null, true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5569), "InProgress", 2, new Guid("aad57fb5-3632-4bc8-a2a7-999d5a7fcb32"), 0.5m },
                    { 3L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5612), null, true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5612), "No", 3, new Guid("67f9c584-f5d8-429d-96f8-4e5b1a43e484"), 0m },
                    { 4L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5614), null, true, false, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5614), "NA", 3, new Guid("cdc5d377-e830-4a59-b3c2-f27d6ceb5886"), 1m }
                });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7068), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7069), "[YES,Inprogress,NO,NA]", new Guid("19c1b03c-3846-49fc-91ce-e0a34013913f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7517), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7517), "[YES,Inprogress,NO,NA]", new Guid("4d4712ff-4168-45fc-8cbb-c7eab376753c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7519), "[YES,Inprogress,NO,NA]", new Guid("4c7cbd34-a937-49cd-b45f-b4eaaf1f40f4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7521), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7522), "[YES,Inprogress,NO,NA]", new Guid("944a1b6a-de3f-4917-a59d-c119d3efce5a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7523), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7523), "[YES,Inprogress,NO,NA]", new Guid("ab7cb426-8807-420c-91c6-a76fff9d7d07") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7525), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7525), "[YES,Inprogress,NO,NA]", new Guid("cdfc93bc-22e6-4ffd-a886-33754a90036f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7526), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7527), "[YES,Inprogress,NO,NA]", new Guid("c1c98215-a50e-48fb-b275-4c2f02fb6e47") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7540), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7540), "[YES,Inprogress,NO,NA]", new Guid("c5c2a306-9217-442a-8eda-029a2fd5fd93") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7546), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7547), "[YES,Inprogress,NO,NA]", new Guid("491f9231-1732-4d5a-bbf5-ffdb80a22209") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7548), "[YES,Inprogress,NO,NA]", new Guid("a0e6996b-4aa6-46fb-b051-cd36311c1c76") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7557), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7557), "[YES,Inprogress,NO,NA]", new Guid("7746bd1c-2280-4e5a-982b-7089d1bea5b3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7559), "[YES,Inprogress,NO,NA]", new Guid("2dcba2a2-8e55-4657-aeb4-81b99c8f0db1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7561), "[YES,Inprogress,NO,NA]", new Guid("4a799701-9b93-476d-b880-17d9c33a2a40") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7562), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7562), "[YES,Inprogress,NO,NA]", new Guid("3723f7b3-e1a1-42be-82ad-3f775adbf86e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7565), "[YES,Inprogress,NO,NA]", new Guid("1cf8bbc7-9ccf-43c7-80d2-4d4bc5eabbe4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7568), "[YES,Inprogress,NO,NA]", new Guid("52fe275d-9446-46e8-b683-2b14c43d809d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7570), "[YES,Inprogress,NO,NA]", new Guid("a6a99a3c-1b51-4d85-9c47-c5f4483f20eb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7572), "[YES,Inprogress,NO,NA]", new Guid("e008251a-e4ed-4a4b-a662-7d80d92410c2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7573), "[YES,Inprogress,NO,NA]", new Guid("9524ce60-74a2-482c-95b7-bff8ad14c8dc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7575), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7575), "[YES,Inprogress,NO,NA]", new Guid("6dabf280-d3bf-4c93-94ec-ae9bb645d0a0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7577), "[YES,Inprogress,NO,NA]", new Guid("ae9a0985-40d0-48fb-98e6-d6f6e480c298") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7579), "[YES,Inprogress,NO,NA]", new Guid("45858771-482b-483c-b0cf-8484c32bbab6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7585), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7585), "[YES,Inprogress,NO,NA]", new Guid("11467b44-f4af-4e43-9d8c-3519550184b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7588), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7589), "[YES,Inprogress,NO,NA]", new Guid("1f5291ac-fab8-49ae-a7be-5267c72619b7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7590), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7590), "[YES,Inprogress,NO,NA]", new Guid("baad262e-ab15-4656-96d4-32949a53de7c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7592), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7592), "[YES,Inprogress,NO,NA]", new Guid("85d6c83a-938b-4b47-b1b3-4a47d060743d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7593), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7593), "[YES,Inprogress,NO,NA]", new Guid("3caa9a1f-01e3-4d87-8f57-36d08a069aa5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7595), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7596), "[YES,Inprogress,NO,NA]", new Guid("2f676853-d372-455a-a8eb-f001b625e6c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7598), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7598), "[YES,Inprogress,NO,NA]", new Guid("b2e71a38-623c-4d93-a928-df6cc3c76997") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7599), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7600), "[YES,Inprogress,NO,NA]", new Guid("57ba7f6f-03a0-4f09-a798-9666be7fb105") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7601), "[YES,Inprogress,NO,NA]", new Guid("609f7d1b-0876-478d-991e-361c8a186875") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7604), "[YES,Inprogress,NO,NA]", new Guid("4e199cac-2379-4063-802c-e8725d0bc950") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7606), "[YES,Inprogress,NO,NA]", new Guid("2dca2eaf-d143-4038-9808-50f6b8204a7f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7607), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7607), "[YES,Inprogress,NO,NA]", new Guid("4c3d2f30-133a-4270-8905-16c81a115d55") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7610), "[YES,Inprogress,NO,NA]", new Guid("22e9ff06-f95d-4263-bdf1-6f9a2616c8a5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7615), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7616), "[YES,Inprogress,NO,NA]", new Guid("d9513688-3015-44ad-b88c-725948189575") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7618), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7618), "[YES,Inprogress,NO,NA]", new Guid("7c35233a-d98a-4897-a8f0-7711bbd60935") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7619), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7620), "[YES,Inprogress,NO,NA]", new Guid("ac8d841d-670c-422f-9516-9045b93b5ca0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7621), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7622), "[YES,Inprogress,NO,NA]", new Guid("8301980b-41a5-4390-83f6-629536159df4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7625), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7625), "[YES,Inprogress,NO,NA]", new Guid("8d3daf09-7e2a-498d-a749-faad35450aff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7626), "[YES,Inprogress,NO,NA]", new Guid("0fe903fe-577a-42a7-8d33-d32c8c83e592") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7628), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7628), "[YES,Inprogress,NO,NA]", new Guid("dee65e6d-92c9-4767-bc27-c65ccde11297") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7629), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7630), "[YES,Inprogress,NO,NA]", new Guid("1895f947-0dc2-4a29-b5ae-bfff35e4bdeb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7632), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7632), "[YES,Inprogress,NO,NA]", new Guid("2f69b0da-3c2b-4d63-a14a-8ac7c806e269") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7634), "[YES,Inprogress,NO,NA]", new Guid("19b37d4b-09a7-45c0-a5ba-7d65ab53f7ce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7635), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7636), "[YES,Inprogress,NO,NA]", new Guid("827bf40c-1002-4d8b-8c3c-ea575441bcc5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7637), "[YES,Inprogress,NO,NA]", new Guid("8b6935fc-6035-4aa0-9080-0233a3388a2b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7645), "[YES,Inprogress,NO,NA]", new Guid("c4d07790-5c18-40f6-86d2-1902f718d39d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7647), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7647), "[YES,Inprogress,NO,NA]", new Guid("8886c5f3-6d15-4184-82f3-a50765849f5f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7649), "[YES,Inprogress,NO,NA]", new Guid("3558b02a-bccb-46d0-96f3-00685048fc52") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7650), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7651), "[YES,Inprogress,NO,NA]", new Guid("3b27d23f-a6d9-418a-b59c-fd12c8ec6fb4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7652), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7653), "[YES,Inprogress,NO,NA]", new Guid("12ba4c97-a26d-44df-8f6a-85ac894c7676") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7654), "[YES,Inprogress,NO,NA]", new Guid("20c53110-8e69-452a-ba8d-e2202e988aa3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7656), "[YES,Inprogress,NO,NA]", new Guid("fc4dc1e2-0ab7-4f59-9f5c-b1d8abdb08f6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7657), "[YES,Inprogress,NO,NA]", new Guid("d7ac303a-c736-4052-9e7f-7f5db775b50b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7661), "[YES,Inprogress,NO,NA]", new Guid("494fd77a-4bd5-4ce8-8f94-044f4327a0f4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7664), "[YES,Inprogress,NO,NA]", new Guid("46917bcd-0655-4bea-9f46-08e6fdc10f4d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7665), "[YES,Inprogress,NO,NA]", new Guid("9c692551-a66a-4870-873b-dbd6790e456b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7667), "[YES,Inprogress,NO,NA]", new Guid("2a64ac08-20ad-4c0d-9618-b92a8ae6a13e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7668), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7669), "[YES,Inprogress,NO,NA]", new Guid("f944ca33-fab0-4a1d-be20-b0bf561a0bb6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7676), "[YES,Inprogress,NO,NA]", new Guid("0c94d258-db4e-47bc-b133-c777713e0a78") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7677), "[YES,Inprogress,NO,NA]", new Guid("efc7cf56-3125-4e8a-b1dd-4c1f88398c72") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7679), "[YES,Inprogress,NO,NA]", new Guid("ef162c89-42ec-4cc8-ab35-c07ad9f29e81") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7682), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7682), "[YES,Inprogress,NO,NA]", new Guid("fa9f5095-74e0-4ed7-85fe-8fb5cc8ed0ba") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7684), "[YES,Inprogress,NO,NA]", new Guid("efd52da5-b62f-4832-bdf7-a46db0df9ce8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7686), "[YES,Inprogress,NO,NA]", new Guid("c13d0f94-432c-4d08-acf2-6e26e2e82d62") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7688), "[YES,Inprogress,NO,NA]", new Guid("f805d1f7-e982-4204-942a-ba9b02a1b24f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7690), "[YES,Inprogress,NO,NA]", new Guid("41128fff-6d39-41cb-bce5-4c67e1eb14ac") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7691), "[YES,Inprogress,NO,NA]", new Guid("cca2e120-7dfb-46a2-9d3f-55fc76f4c424") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7693), "[YES,Inprogress,NO,NA]", new Guid("289ca14d-2353-4966-846e-6555b39d1276") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7695), "[YES,Inprogress,NO,NA]", new Guid("e274f5f1-4877-40c3-8d90-0662d25297de") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7698), "[YES,Inprogress,NO,NA]", new Guid("60b1d347-f811-4d7e-a096-2bce28368a07") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7700), "[YES,Inprogress,NO,NA]", new Guid("99def0b2-f4c5-4ef8-b2d2-6c27150a39ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7707), "[YES,Inprogress,NO,NA]", new Guid("dab8644d-b8be-4871-bf0c-e7f1e2b1ae86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7709), "[YES,Inprogress,NO,NA]", new Guid("7a37f2b2-ac40-46f1-a3c1-634705ed9460") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7711), "[YES,Inprogress,NO,NA]", new Guid("3d36aeeb-2115-4cbe-a6c8-c190b4d949f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7712), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7712), "[YES,Inprogress,NO,NA]", new Guid("ca192cfe-de5c-41f1-9727-5ffbd04ad04d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7715), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7716), "[YES,Inprogress,NO,NA]", new Guid("d18eed71-20d1-4c92-b134-6edba201d122") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7718), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7718), "[YES,Inprogress,NO,NA]", new Guid("dafb7769-7b9c-4bc6-90f9-83955da0112e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7721), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7722), "[YES,Inprogress,NO,NA]", new Guid("09c654b8-9464-414f-84a5-f6806ef7ec36") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7723), "[YES,Inprogress,NO,NA]", new Guid("b986562d-c850-4713-911f-316c2e2978a8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7726), "[YES,Inprogress,NO,NA]", new Guid("056f040d-b8a1-433a-ad35-d37071602ed1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7727), "[YES,Inprogress,NO,NA]", new Guid("a69fcaab-aa57-419b-81be-fc975829860c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7729), "[YES,Inprogress,NO,NA]", new Guid("af86195c-4c70-4578-b615-b8b4b167d263") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7731), "[YES,Inprogress,NO,NA]", new Guid("b2b1eb23-f348-416d-b0d1-3761e2914e89") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7737), "[YES,Inprogress,NO,NA]", new Guid("0713470e-2e36-433f-858d-4f5ff536a854") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7739), "[YES,Inprogress,NO,NA]", new Guid("f054d4ed-7be5-4dbc-8ce4-cc0d1ad11f27") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7742), "[YES,Inprogress,NO,NA]", new Guid("81adb5bc-1e58-4037-9b37-9f4f651d046b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7744), "[YES,Inprogress,NO,NA]", new Guid("58195b52-a5f5-4d9e-b803-c53e4f4a1815") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7746), "[YES,Inprogress,NO,NA]", new Guid("c064de78-60c0-4107-b825-b221de0d94af") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7748), "[YES,Inprogress,NO,NA]", new Guid("797c8edd-af23-4939-af39-f0d639a43726") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7750), "[YES,Inprogress,NO,NA]", new Guid("d2638c27-d532-4127-9def-5781651e82b6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7751), "[YES,Inprogress,NO,NA]", new Guid("c7f2f6b6-4506-4622-9435-d279ff26e730") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7753), "[YES,Inprogress,NO,NA]", new Guid("25367aaf-568f-43da-909e-f64b7c268742") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7755), "[YES,Inprogress,NO,NA]", new Guid("67e5fdf3-fe6e-44f4-b4a5-04e999320335") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7757), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7758), "[YES,Inprogress,NO,NA]", new Guid("af80d43a-b382-412a-a6bd-a54419bfe92f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7760), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7761), "[YES,Inprogress,NO,NA]", new Guid("38587954-503b-46b9-9fe2-c2530352d692") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7762), "[YES,Inprogress,NO,NA]", new Guid("3d812982-9eb8-4c7a-b795-6beac1f2e7db") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7764), "[YES,Inprogress,NO,NA]", new Guid("3b8e0e20-9efa-4091-930d-0fb6c0b5df6c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7765), "[YES,Inprogress,NO,NA]", new Guid("071e11e6-4f8e-4ebe-ae55-1dca69fa3c63") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7767), "[YES,Inprogress,NO,NA]", new Guid("75a12820-6495-4a34-b58a-5e752d8f0259") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7769), "[YES,Inprogress,NO,NA]", new Guid("55a833d0-03fe-4f69-b9eb-77ebeafbbfe6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7771), "[YES,Inprogress,NO,NA]", new Guid("e0085714-a613-4b94-a258-f70be067c07e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7775), "[YES,Inprogress,NO,NA]", new Guid("be78acb1-5e15-4974-ac5b-484a8ee72c1c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7776), "[YES,Inprogress,NO,NA]", new Guid("af4cfe19-c090-4f9a-a27e-132ec8332c59") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7778), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7778), "[YES,Inprogress,NO,NA]", new Guid("62a8723d-04cd-41f8-81cd-08756042a3b5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7780), "[YES,Inprogress,NO,NA]", new Guid("1e72070e-8b96-4c1e-a6a9-b301a6ab2944") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7782), "[YES,Inprogress,NO,NA]", new Guid("a5573b09-2aed-4d26-a6cc-d0bc9d6bd3ab") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9686), new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9687), new Guid("1176e86c-ad92-4224-88c4-002c93fe538b") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9875), "In Progress", new Guid("f5242cd4-2477-41ef-8d85-395c3ebfc897") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9876), "Completed", new Guid("5df828f4-7ad7-42d3-a859-4a7e2ae78678") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(295), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(296), new Guid("1864485c-5a0d-4075-adf3-2f75dad0d376") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(299), new Guid("299df84a-bd36-405a-a4fd-0ee0d85014d0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(404), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(404), new Guid("6670b2e7-fbcc-4fba-a47d-48f80a848ea1") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(406), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(407), new Guid("2caa4c75-7792-4c0c-9d8e-5d17cf0622b4") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(411), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(411), new Guid("5cca9a08-f272-4cd8-ab7f-9f5e0e935729") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(413), new Guid("71f19f2d-7b31-4fe5-88a1-d42979ac4ff0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(415), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(415), new Guid("620d8db0-9244-444b-9e11-492c3c6a1cf5") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(417), new Guid("e8b5cb69-89dd-4286-88aa-56172e34ed7b") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(418), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(418), new Guid("210fbaae-ccea-4725-b8a5-bf19b341acde") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(420), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(421), new Guid("4b686096-4177-4f13-a579-2eabeca29a28") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(423), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(423), new Guid("a38fd50f-7df0-4d4d-9b63-7f4720d3a8f2") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(3617), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(3618), new Guid("2e603cc3-10d7-4bff-a3f6-8682112c021a") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(3625), new DateTime(2025, 6, 22, 7, 10, 31, 32, DateTimeKind.Utc).AddTicks(3626), new Guid("2f440e97-dcee-45af-bc68-cecb9567ee00") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 37, DateTimeKind.Utc).AddTicks(3940), new DateTime(2025, 6, 22, 7, 10, 31, 37, DateTimeKind.Utc).AddTicks(3940), new Guid("fdc1253a-a78e-46b9-af33-466b023452d5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7426), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7426), new Guid("18580f99-5c8f-4099-941b-2fc89c72f1b4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7870), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7870), new Guid("ab70af56-c1b7-4834-8b3c-d12fc9f6616e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7882), new Guid("425af809-b9b3-4fdd-98a4-ae7a6b8e52dc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7885), new Guid("42e49d05-2d25-4aff-a309-bd8b08ccb225") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7887), new Guid("c12f76ad-c6ff-4545-a89d-d9b2305ad148") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7889), new Guid("2be4706e-3f70-4d3a-9be9-e0e8c6f36fbb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7890), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7891), new Guid("ab5e4904-bc7c-4694-a90c-1cfb51618e94") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7900), new Guid("c149f159-e06e-44ce-8a84-439bd0df9cc5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7901), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7902), new Guid("b65438ec-2b83-4eb8-837e-b95908b628c9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7904), new Guid("98d2184f-b07c-405e-80c7-3aa6f4500a5d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7907), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7907), new Guid("5f8ce319-53c8-4cdb-990d-15f5afb3a6f5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7909), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7910), new Guid("dc39c14b-130c-418e-bc6b-b3cca38e6a6a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7912), new Guid("cd1cb39d-ce21-4c50-ba95-01f7cc95856b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7914), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7914), new Guid("3793e461-5b53-443c-b7f0-164c791539bb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7916), new Guid("31b4f94b-6b70-405a-81cd-8eb57247db78") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7918), new Guid("52d91489-ced6-497d-9bf3-91eed54193dd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7925), new Guid("31bb6123-2352-4c2f-b7ab-b7307f37ec5f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7926), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7927), new Guid("4657caeb-c97e-47a0-a2ee-911fa5d2be8f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7931), new Guid("6f4f32b7-f0bd-4f6f-8bb6-81f039e20ae2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7932), new Guid("47d3212e-5b77-4194-ba0b-1b5d2a6ea625") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7935), new Guid("d8346aa1-0a2e-4f6d-b91b-dafc0e25f0ef") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7937), new Guid("c7f1e86c-a7cc-42a6-90ad-4f4b9e34a38d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7939), new Guid("558f797e-7ce1-4fd6-951f-224dc72a6137") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7941), new Guid("0a445178-7129-48b9-baa9-1f5d5170a87f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7943), new Guid("ce8274a0-c9c9-48d4-bda5-5b1650c2d43b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7945), new Guid("4ed39137-4fb9-40fe-9f33-33ab07b97536") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7949), new Guid("e17badcb-c7ae-44f1-adcf-ca0531b65d46") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7951), new DateTime(2025, 6, 22, 7, 10, 31, 38, DateTimeKind.Utc).AddTicks(7951), new Guid("04375fef-3bce-44ef-9a38-ea236d1752c9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5129), new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5129), new Guid("57f23b15-e298-45c3-bd22-6e25f7e760b3") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "User",
                columns: new[] { "Id", "Address", "ClientId", "CreatedBy", "CreatedOn", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedBy", "ModifiedOn", "Password", "PhoneNumber", "RoleId", "RowId", "UserName" },
                values: new object[,]
                {
                    { 2L, "123 Main St, City, Country", 1L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5741), "Krishna", true, false, "Kona", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5742), "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y", "1134457890", 2L, new Guid("9fe9ba69-c936-4eb5-851a-b6cfc7a418ed"), "kkona@dcubedata.com" },
                    { 3L, "123 Main St, City, Country", 2L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5744), "Chaitanya", true, false, "Kona", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5744), "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y", "4444567890", 2L, new Guid("a051a101-8a0a-427a-a567-bf7423c24023"), "chaitanya.kona@covasant.com" },
                    { 4L, "123 Main St, City, Country", 2L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5747), "Hima Bindu", true, false, "Kona", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5747), "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y", "1234560000", 2L, new Guid("31d82aac-1bf0-4ccb-aa35-2cd2ed2e5128"), "konachaitanya@gmail.com" },
                    { 5L, "123 Main St, City, Country", 3L, 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5749), "Kevin", true, false, "Williams", 1L, new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5750), "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y", "6444553789", 2L, new Guid("e6048b94-3829-4efc-85f8-dc91ffda469e"), "konachaitanya@hotmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionResponseWeightageType",
                schema: "MetaData");

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "Score",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse");

            migrationBuilder.DropColumn(
                name: "Score",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse");

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 239, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 6, 7, 15, 31, 1, 239, DateTimeKind.Utc).AddTicks(7571), new Guid("72095872-1cb5-4204-a43d-0de9698431d6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(6807), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(6810), "[YES,NO,NA]", new Guid("ebc30155-f984-445c-8667-a5af97d94f57") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8200), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8201), "[YES,NO,NA]", new Guid("156b116b-24ac-4013-b7ed-ca5da5eeb1e4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8206), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8206), "[YES,NO,NA]", new Guid("a02d8a80-fe93-4b31-9891-122db333ca45") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8209), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8209), "[YES,NO,NA]", new Guid("7b01e7d1-a2d4-46cc-94b5-55ec1d6a6d9c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8213), "[YES,NO,NA]", new Guid("bfbb0ed7-6e63-499c-8772-ad1adb7eb4e5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8216), "[YES,NO,NA]", new Guid("04c21e20-3d7d-4272-bb9a-493c38a4094b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8227), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8228), "[YES,NO,NA]", new Guid("5714bed2-07be-4d7d-a613-1f55ebf93aee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8242), "[YES,NO,NA]", new Guid("e088f67d-80d2-4fa5-82ee-78c0228d5f38") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8245), "[YES,NO,NA]", new Guid("e1f21a41-074c-4859-8b68-f3c94bc86741") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8284), "[YES,NO,NA]", new Guid("8f5b3af3-0c3f-4bba-b521-0f38daf31a77") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8287), "[YES,NO,NA]", new Guid("4485340c-eaa2-4509-b32f-499165587a46") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8289), "[YES,NO,NA]", new Guid("e2044009-3d07-402a-a348-81027652acc1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8292), "[YES,NO,NA]", new Guid("5fff0047-c840-42e3-b634-38268933837e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8295), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8295), "[YES,NO,NA]", new Guid("5cc0ec30-fd2f-4e27-af18-663b887e719b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8301), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8301), "[YES,NO,NA]", new Guid("6f924b84-c08c-4941-a6f2-3f79f17d05f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8304), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8304), "[YES,NO,NA]", new Guid("2ba71881-05f9-4a29-9bd7-cf7981cd80b4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8307), "[YES,NO,NA]", new Guid("44432ef7-f5fd-4a9d-accf-5d13a7370e9c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8310), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8310), "[YES,NO,NA]", new Guid("fb0560f2-46e4-4e05-a362-ff98285d5142") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8313), "[YES,NO,NA]", new Guid("3f84667f-c664-44a4-9318-2810f9438425") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8316), "[YES,NO,NA]", new Guid("201fe7d2-1855-4c30-8210-f7d0d68370bc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8318), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8319), "[YES,NO,NA]", new Guid("19ee793c-c2e9-417f-b853-1a5f7ea58e3c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8321), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8321), "[YES,NO,NA]", new Guid("bb7d9d02-0786-4717-a63c-724dabdee886") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8326), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8326), "[YES,NO,NA]", new Guid("b31db060-261a-4883-a2ef-826da0e48620") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8329), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8329), "[YES,NO,NA]", new Guid("e48d60bd-0552-4b37-a6be-2253106710cc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8331), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8332), "[YES,NO,NA]", new Guid("42e51698-48a0-4381-b959-299fee4b9599") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8334), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8334), "[YES,NO,NA]", new Guid("8552042d-51b4-4858-88e5-d504a03e815a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8337), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8337), "[YES,NO,NA]", new Guid("b9e22e6b-30cc-40a1-99db-9a19cb4d41c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8356), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8356), "[YES,NO,NA]", new Guid("20780009-c451-4c82-9559-be61e2d31007") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8360), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8360), "[YES,NO,NA]", new Guid("20dd2ccd-b94c-46ee-96de-5fcac8ed9ba3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8363), "[YES,NO,NA]", new Guid("2409e4c4-ef10-4a3a-8a51-1fe6e015b8df") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8369), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8370), "[YES,NO,NA]", new Guid("fdf8cbab-2c76-461c-b0cb-26c01bb52aab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8373), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8373), "[YES,NO,NA]", new Guid("ea90ff85-e5a1-4855-bf32-9ed01f96fa89") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8376), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8376), "[YES,NO,NA]", new Guid("41876e09-65aa-4110-a8a7-d6d968d29a9b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8379), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8379), "[YES,NO,NA]", new Guid("2fa4e110-b732-4f3c-aaf6-c627bc2efc95") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8382), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8383), "[YES,NO,NA]", new Guid("69e0473b-d548-47fc-a3f0-0a330d2dc2c5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8385), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8386), "[YES,NO,NA]", new Guid("1dc01a94-cc50-4d2a-b9a3-c51239d762cb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8388), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8389), "[YES,NO,NA]", new Guid("a84b1077-e050-4c19-b581-63137bd1d7c5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8391), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8392), "[YES,NO,NA]", new Guid("5216fef8-183e-4de4-9ccd-5ba665d5615e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8473), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8473), "[YES,NO,NA]", new Guid("1dacd1d7-5ad0-4101-8f30-2389868f69e8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8476), "[YES,NO,NA]", new Guid("4323b273-69b4-4866-89a9-fee18bf30ade") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8479), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8479), "[YES,NO,NA]", new Guid("05893633-f181-4e4b-9310-f4a07e6e38ba") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8482), "[YES,NO,NA]", new Guid("d256f494-f1f2-41aa-9cb5-3872d0fb1abc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8485), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8485), "[YES,NO,NA]", new Guid("c7a66d33-1a85-418b-a9b6-59a0e28caf7e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8488), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8488), "[YES,NO,NA]", new Guid("1c00bcc7-57d2-427d-85f5-6158b63702ce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8490), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8491), "[YES,NO,NA]", new Guid("15346d34-d5a4-42fa-b37e-dc7e4a090104") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8493), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8493), "[YES,NO,NA]", new Guid("c8c9f822-fc7b-40c2-b1e6-01984cc6aa83") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8519), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8520), "[YES,NO,NA]", new Guid("49c5bdb6-c30d-43d4-a82e-86cea96481c3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8522), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8522), "[YES,NO,NA]", new Guid("5b6bb6bf-6256-4b94-9dc6-387fa04e819d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8524), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8525), "[YES,NO,NA]", new Guid("41834b0c-b15c-4611-8f08-db86439cadc6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8527), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8527), "[YES,NO,NA]", new Guid("807facd3-417b-417f-8f1b-de9748ee28c8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8529), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8529), "[YES,NO,NA]", new Guid("3f29e1ce-5953-4a0e-930a-39b22ecccb7a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8531), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8531), "[YES,NO,NA]", new Guid("2c48f98c-27cc-4307-8a4e-392dd5088047") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8533), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8534), "[YES,NO,NA]", new Guid("4bd2dcc9-0d5f-42ad-a621-b7da8e166da9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8536), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8536), "[YES,NO,NA]", new Guid("9cca69b1-cf0a-45ae-ba8f-9c16340ffe75") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8541), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8541), "[YES,NO,NA]", new Guid("03df0d07-9a94-4e71-8ed1-013a020c9d37") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8543), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8543), "[YES,NO,NA]", new Guid("522e08bd-43b5-453b-8472-89270f79df11") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8545), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8546), "[YES,NO,NA]", new Guid("1d6f89c3-ed52-4dae-b622-fd15a019740f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8548), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8548), "[YES,NO,NA]", new Guid("617693c9-a78e-4757-ace5-c9d1aae3b182") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8550), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8550), "[YES,NO,NA]", new Guid("4256a1b7-4aad-4084-ac81-f10e634feba5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8552), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8552), "[YES,NO,NA]", new Guid("ef2d4e0b-a5a8-4d7b-8e71-043945ab401a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8554), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8555), "[YES,NO,NA]", new Guid("bd978096-6918-41c9-82f9-6e839ce05554") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8557), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8557), "[YES,NO,NA]", new Guid("a00cc19b-f96d-4ef8-828e-812504a00b7a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8561), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8561), "[YES,NO,NA]", new Guid("32de123c-5288-4287-b2c8-f7d7815e3e84") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8563), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8563), "[YES,NO,NA]", new Guid("c6630b2b-827d-4cbb-801c-58b79347e054") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8578), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8579), "[YES,NO,NA]", new Guid("af4e278e-8add-4577-99af-92ecf928708e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8581), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8581), "[YES,NO,NA]", new Guid("a094167c-29e4-47ce-af36-e1234f5f5ff8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8583), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8584), "[YES,NO,NA]", new Guid("9a5ef5d3-3881-484a-9ff4-3a6a0e862fb6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8586), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8586), "[YES,NO,NA]", new Guid("8ebce80b-b00d-4261-b823-24b652908d86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8588), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8589), "[YES,NO,NA]", new Guid("d9fcab1e-a06b-4270-936b-92a186a85a56") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8591), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8591), "[YES,NO,NA]", new Guid("f9c0252a-b32f-4a21-b682-efd2caea60ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8595), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8595), "[YES,NO,NA]", new Guid("2ed9c789-5f01-491a-ab4c-fcd8e586f828") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8597), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8598), "[YES,NO,NA]", new Guid("3ac2f607-83db-4f2c-8963-6ae80f07f367") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8600), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8600), "[YES,NO,NA]", new Guid("de30c320-66b0-4512-bfa0-90be4e592fc6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8602), "[YES,NO,NA]", new Guid("dc74e161-afa9-4189-9044-55b088fd33c9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8604), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8604), "[YES,NO,NA]", new Guid("b1041309-af27-4f9c-8367-7000866dd061") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8606), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8607), "[YES,NO,NA]", new Guid("864935c5-21d7-4cef-9890-8c42bbb2ce18") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8609), "[YES,NO,NA]", new Guid("b69fcf1f-967d-4f33-a70a-c3db7c30fe93") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8611), "[YES,NO,NA]", new Guid("f075864a-c254-4cbb-b8d1-bae642cbc455") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8616), "[YES,NO,NA]", new Guid("d51df018-91a7-4ad6-bdd2-eb8c21c4b76c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8618), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8618), "[YES,NO,NA]", new Guid("99f265c1-f9b6-4da2-a861-1ee4fe0fb572") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8620), "[YES,NO,NA]", new Guid("8648bfa7-7d19-4b26-8104-b1f92d75396c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8622), "[YES,NO,NA]", new Guid("4c2876f7-21c3-4ae1-b4fb-02814011d140") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8637), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8638), "[YES,NO,NA]", new Guid("cabbcd97-b666-465c-b03c-b77162e7f2e4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8640), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8640), "[YES,NO,NA]", new Guid("d61cb65a-0fa1-4433-93cb-6b175adbaf54") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8642), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8643), "[YES,NO,NA]", new Guid("a86f4b3a-e7bd-4f9c-9fea-26a518fe0514") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8645), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8645), "[YES,NO,NA]", new Guid("d333a87a-d61f-4867-b569-e0c29bc9d168") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8649), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8649), "[YES,NO,NA]", new Guid("0159a6e0-79f4-44fb-97f6-0b6aacc57b5e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8651), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8652), "[YES,NO,NA]", new Guid("25d5b908-06ad-4ea8-b4e5-59ac91e86617") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8654), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8654), "[YES,NO,NA]", new Guid("c52ab3e3-a45e-4ff1-9963-acc86cf80f6e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8656), "[YES,NO,NA]", new Guid("134b9698-3d93-4c34-aeb6-c7c4308b10ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8658), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8658), "[YES,NO,NA]", new Guid("81f4d6f6-9219-45e4-ac59-d5d50283b637") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8661), "[YES,NO,NA]", new Guid("e5f5f9e8-5bf7-4401-b878-07ff057e25a6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8663), "[YES,NO,NA]", new Guid("e763a7b8-bad8-450b-b470-5c0cc4278755") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8665), "[YES,NO,NA]", new Guid("a07fcb6b-6d8a-4c1e-badf-b66cbb96b927") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8669), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8670), "[YES,NO,NA]", new Guid("3ec172a3-9844-4453-b7b0-0c0e0bd4e567") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8672), "[YES,NO,NA]", new Guid("ee2d25bb-d1eb-4e3a-b29e-e83df13e08f5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8674), "[YES,NO,NA]", new Guid("24f9c6a5-0288-4bc7-bb32-208b151e8f25") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8677), "[YES,NO,NA]", new Guid("6d390707-1550-47f1-af57-84ef4964e339") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8679), "[YES,NO,NA]", new Guid("0279ccce-1546-4879-9c98-c750e7a0da7a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8681), "[YES,NO,NA]", new Guid("2b96425e-46d7-412a-9549-b71272b0b980") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8683), "[YES,NO,NA]", new Guid("83e9f4b5-5a39-44ab-a6cf-5a363e6bd027") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8685), "[YES,NO,NA]", new Guid("c1526cb0-9420-4e10-81bc-7148713e464b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8690), "[YES,NO,NA]", new Guid("cd5c9c7d-5a9c-4af3-b28e-38ae1d8e04ed") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8692), "[YES,NO,NA]", new Guid("610b846d-e8ee-48a7-abde-d1d90a340964") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8694), "[YES,NO,NA]", new Guid("64a133f6-6e23-4412-ae89-3fa85c8af4c9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8696), "[YES,NO,NA]", new Guid("e6f928d5-c4f9-4a94-ace8-3402400461c2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8698), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8699), "[YES,NO,NA]", new Guid("f4477962-5e1d-458a-ab4c-22834afddaab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Options", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8735), "[YES,NO,NA]", new Guid("66f47bb2-98c4-4eb2-8e7e-04b604366d17") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(1572), new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(1574), new Guid("d03a52cd-e949-4661-91c7-8ba0cf2fd201") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2109), new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2110), "Draft", new Guid("49142602-289d-4994-9fb0-2157f10fce0e") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2113), new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2113), "Published", new Guid("a767399b-3da1-4054-acda-0184516af1bf") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2877), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2878), new Guid("85f38460-3685-4e66-8b12-894cc599a7d8") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2882), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2883), new Guid("da866054-9588-4a54-91e9-f63c140472ee") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3198), new Guid("2ec95c3f-eb9f-4278-b650-144be87f7657") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3217), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3217), new Guid("75966d74-9338-486b-9362-65c8e04a2c24") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3220), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3220), new Guid("367c9502-9776-4844-8586-1eded15d6f54") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3222), new Guid("6ed2cc56-a64d-4712-91c8-ab33db012794") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3224), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3225), new Guid("72645f51-61ba-49f1-a2d4-f8ed3b54f7bf") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3227), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3227), new Guid("dc0d1000-c855-4681-8ee0-c881d1b6d173") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3230), new Guid("4736df78-8d55-479b-a2cb-2f8829ca27dd") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3232), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3232), new Guid("329865a1-ebfd-408e-9a3f-6504e0ec9080") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3235), new Guid("cb38403c-7692-4763-b0db-c35585e455e0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(719), new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(720), new Guid("8ff92cf5-2ca2-4508-a1b9-514448746b4c") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(725), new Guid("f87bdfef-07ae-4f40-82c9-3d0bd1e808fa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 255, DateTimeKind.Utc).AddTicks(9125), new DateTime(2025, 6, 7, 15, 31, 1, 255, DateTimeKind.Utc).AddTicks(9126), new Guid("21174592-7409-4554-8f68-1156853e48e6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(3008), new Guid("09cf2f6e-9420-4420-9703-1770a0e3a10f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4232), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4233), new Guid("82645d8b-71f1-415b-a6c5-ca064c3d78b0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4257), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4257), new Guid("c00a05f5-2970-469a-a774-cf149f24907a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4261), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4261), new Guid("e51cfa1d-b517-44d0-8d2f-4e309618c3d2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4264), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4264), new Guid("13136e7d-7b68-4476-94f9-ef0b5267c77e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4267), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4267), new Guid("e94dd25b-7fd1-4cb0-9e53-54418e6f9a29") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4270), new Guid("38a6851d-7dd8-4239-a6ea-4bf2459584ca") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4273), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4273), new Guid("ecc82d53-9816-435c-bb99-1d91809506ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4276), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4276), new Guid("692a4967-632c-4818-a8f6-d16d8cc0f326") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4281), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4282), new Guid("0909ca27-3721-4e63-9fe5-fbd512c96669") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4284), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4285), new Guid("3b0dfba8-6ec0-49b0-b11e-3868917563ab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4287), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4287), new Guid("aad3d341-f219-4b64-bdd3-429324fa873b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4290), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4290), new Guid("300a2075-03f5-44af-91d1-fc05958fe9d2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4293), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4293), new Guid("6769c64b-9101-4f87-8252-dc50fc538440") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4309), new Guid("cd68dace-bd40-42c5-b485-ec76f8baf96b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4311), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4311), new Guid("d12ee893-0323-43d1-a819-3c4622cb2265") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4314), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4314), new Guid("d7bf89c5-e374-4a1f-9c92-76e4b6fc2972") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4319), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4320), new Guid("9f8e1f3f-1f63-4b1b-84c8-016ff61c8b63") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4323), new Guid("48871ef7-80c7-446f-a301-37d310972ade") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4326), new Guid("4cd6db7f-2b71-4780-8f07-cc4c65c357d6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4328), new Guid("17ab1e69-adeb-4f4d-939b-3ed219e58894") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4331), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4332), new Guid("0598eda2-b439-49af-a3a9-9fc05a72f3fb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4334), new Guid("98108b71-a5ba-492c-b407-1c1b7961eb08") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4337), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4337), new Guid("06cc5cdf-5f2f-4a4a-9b7b-9348469ac12e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4340), new Guid("7af3efc5-f9cc-4238-b1ef-e1004c3aa247") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4345), new Guid("2bb1c7c4-33df-47e6-9877-dbffec4240d7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4348), new Guid("25c8b905-8c1f-4145-9a88-fa2f57d47756") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4351), new Guid("8029b11a-f7a3-4250-a226-5029636ec61d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 31, 1, 259, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 6, 7, 15, 31, 1, 259, DateTimeKind.Utc).AddTicks(7636), new Guid("1a3880d8-b3c9-494e-9516-3dcac0f0e65f") });
        }
    }
}
