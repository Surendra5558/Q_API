using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaturityPathSteps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Gaps = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RemediationPoints = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Process = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    People = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    EndPointDectionResponse = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    MultiFactorAutentication = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ManagedDetectionResponse = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
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
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8189), new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8192), new Guid("42d02fb9-c6a1-4303-807d-23c24ee30171") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8589), new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8590), new Guid("b4b31414-7929-4733-a084-144f4ec095f0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8592), new DateTime(2025, 6, 25, 16, 43, 59, 255, DateTimeKind.Utc).AddTicks(8593), new Guid("0948970f-7a5c-48dc-a072-8a7544a32eda") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(7570), new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(7571), new Guid("ceb42b68-3704-41a0-87d2-b58dd685aadb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(8215), new Guid("31a13ecd-2ec4-4352-937e-fa8d245a0123") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 6, 25, 16, 43, 59, 256, DateTimeKind.Utc).AddTicks(8218), new Guid("10dac462-1fed-497d-a5d2-c89e99dd6eb1") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(8853), new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(8853), new Guid("fe0777fe-9db6-4f47-9528-5a06326b4b71") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(8983), new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(8983), new Guid("bad1fda5-e7f6-4366-aa2a-d820fbc50555") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(9036), new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(9037), new Guid("91ec81b2-5fa6-4001-9099-6efd0adb4a06") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(9039), new DateTime(2025, 6, 25, 16, 43, 59, 261, DateTimeKind.Utc).AddTicks(9039), new Guid("91786152-a186-439d-9696-47f0e7f9293d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8167), new Guid("640d8dd1-f341-48f3-b79b-ec29672b20b9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8646), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8647), new Guid("272184cd-6cd4-425f-ab05-54e07dc0fe1e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8650), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8650), new Guid("15c7d97a-bb98-4cb3-be1a-e71a1707e181") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8651), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8652), new Guid("1f6c8111-4397-4acd-8d90-e8ca90f17cfa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8653), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8653), new Guid("7fe3e4d8-99a5-4755-9f5d-ea9b322f97be") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8655), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8655), new Guid("5bc18177-f762-415d-be69-6cd9f7c2db1c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8658), new Guid("a3df4c51-1510-4706-b454-3615020f501f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8660), new Guid("338e184c-e816-4f53-9a75-a269f8b97a86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8669), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8670), new Guid("6a8051cc-6f3a-4152-8c9c-16fe594bedd2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8674), new Guid("10e2a1fb-24fb-43a5-bfeb-18e67d9666ca") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8676), new Guid("1f9bb5a7-8a97-43f1-af42-28655ce87efd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8677), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8678), new Guid("b1716255-4506-4e08-b5b5-8e8c28a71d27") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8680), new Guid("9eafce2d-82df-4640-916b-594e54c40a9d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8681), new Guid("8b611283-cac6-4b8c-9993-1160f86fdde6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8684), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8685), new Guid("dab38969-d18c-42c7-82b5-0dd08de33b88") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8688), new Guid("5c8aec59-72de-4462-8aa7-463419090c34") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8691), new Guid("a9231a31-ca9c-4ad9-b86e-2126f64a9365") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8694), new Guid("7dfe6e14-89a2-4a34-87be-84a7a1f8ddde") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8696), new Guid("9caecc70-905d-4f6b-a916-dc2b9433520e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8699), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8699), new Guid("c22499d7-285f-4dd5-bfe9-f6a3f7077d77") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8705), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8705), new Guid("420d6900-7c21-4206-9f9e-2a3b411056dd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8706), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8706), new Guid("e120ceed-ad68-4091-b3ca-5a909fb20156") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8708), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8709), new Guid("f438f339-fd72-4643-a8c6-731e831c68f5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8711), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8711), new Guid("a2a3aaa3-7cc9-41a0-83f6-9ac7acd9bf12") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8712), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8713), new Guid("294238bc-ffbb-4493-8379-49f90cfb4cb8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8716), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8716), new Guid("9373f1b0-d2bb-421e-b1df-4ce7f09121d3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8717), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8717), new Guid("6568359d-8547-4dc2-9a31-d81c1b0063ac") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8719), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8720), new Guid("393b18a5-ae57-49e7-b823-0dc4d8ec5573") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8722), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8722), new Guid("0ece0982-e8ce-433b-93d7-1e76722db932") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8723), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8724), new Guid("d31f61c3-21ad-43b7-808e-23c78d0050dd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8725), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8725), new Guid("0d204dd8-e859-4782-ad4f-9359e5bf43c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8727), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8727), new Guid("0afc27f6-8a71-43fd-923c-7bbf0be6d704") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8728), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8729), new Guid("767cf46f-a717-4617-bed0-959a4f434ef0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8738), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8738), new Guid("0b2a83da-2c94-4239-b04c-73fbecacc222") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8741), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8741), new Guid("5a246531-e34b-4de5-991d-41fdf9664466") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8743), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8743), new Guid("fa19fa0d-d7e7-4dca-a0bb-73b6719507db") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8746), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8746), new Guid("046b594d-07b3-4a82-9d90-8d8008487192") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8747), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8747), new Guid("599a043b-f087-416f-9208-712434823201") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8749), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8750), new Guid("f506f0a7-d114-4d52-9598-f83b243593b6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8751), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8751), new Guid("0bd2f2f3-ffc1-401c-9325-56e9ac3485f8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8753), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8753), new Guid("b67f334b-0969-4805-94df-ecf8ac3b79de") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8758), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8758), new Guid("694029e8-9d7c-4fb4-907e-151859ce6cdc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8761), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8761), new Guid("ddb1ac83-6527-48ba-9268-62d1098f38a5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8763), new Guid("8df912bd-a345-4f25-953d-fb19b12b404d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8765), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8765), new Guid("39f7ba92-e926-4a2a-a76e-71e25b9ce5b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8767), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8767), new Guid("fbbdbdbb-36da-47df-a9a3-71f02db95e39") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8774), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8774), new Guid("a19db14f-35e9-44d9-ad83-de0604d0e51a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8775), new Guid("60a95036-13cc-4a53-ab5b-9a954498023e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8777), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8777), new Guid("8e70ca91-3130-41a6-b177-6ea455223d77") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8785), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8785), new Guid("1f764a6b-3451-458c-8a43-2f543ee76b2a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8786), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8787), new Guid("18869980-f064-420f-8a1b-fe301b4244f2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8788), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8789), new Guid("04c50ad4-cd6f-4806-8187-ba2080afe833") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8790), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8791), new Guid("1a2e216e-5eb7-4a88-97b5-13243e0f8d91") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8792), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8792), new Guid("aa3165cd-cc5d-451d-8fbd-0af1f09138d8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8794), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8794), new Guid("022a7847-be2d-4d31-8f2f-4851ea38083a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8797), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8797), new Guid("65187b97-d8a2-4624-9f93-9f188f31ccbd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8799), new Guid("f45eaced-1008-44f9-ae10-5ecf922f2ed0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8802), new Guid("10f3ca31-587f-445d-ae7f-e27f22c50978") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8808), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8809), new Guid("2f02b863-4f8a-4c1c-9e3f-4cc81623e809") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8810), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8811), new Guid("5525f9a1-582a-4f98-ad20-6064079bb7f8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8812), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8813), new Guid("0bc46e1b-6fe5-49b6-a67a-e0971f51a18e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8814), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8814), new Guid("ce24d905-5dd1-45bb-9b12-7f3741a02c09") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8816), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8816), new Guid("60832cdc-6b9d-4988-b011-1f05119695f1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8817), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8817), new Guid("94198abf-4602-47be-a8cc-ec55588522e7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8819), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8820), new Guid("626d47bb-c123-4c5f-93c8-34bb704723ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8822), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8823), new Guid("22c158c1-9540-4cdc-a3a5-d0de6250bcf0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8825), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8825), new Guid("29abdd58-0a06-4edc-bf30-2b14c2de760a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8828), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8828), new Guid("89ac067b-9d42-4591-9535-9f6aa8e1ed64") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8830), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8830), new Guid("58687926-88ce-4abc-9816-83c9fdd302f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8831), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8831), new Guid("39c42725-a975-4df8-85b5-c1e496f65e1a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8833), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8834), new Guid("541ae963-4cf2-459a-a350-0f6c045630ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8839), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8839), new Guid("3a1a4a71-1d0a-416c-806a-c5b1a71a3b31") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8842), new Guid("f4ce47b6-af14-4d76-97f6-9349d6b28552") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8845), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8845), new Guid("9ac74005-712a-42d1-8b8c-37bd092383d1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8847), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8847), new Guid("6140b7b7-27ef-4b6f-a107-b1a6cdf595e4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8849), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8849), new Guid("bf9b86bc-881e-4606-a97a-773e1b69278c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8850), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8850), new Guid("e3fe6668-1e80-4883-b085-e76eec248738") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8852), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8853), new Guid("7f5a882e-86b0-4752-8c0f-047cee64641a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8854), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8854), new Guid("273d88b0-fa0c-46bf-bc57-abcd0ea371c0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8856), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8856), new Guid("695a4bf1-ee62-4571-8a8e-dc0c95690527") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8858), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8858), new Guid("35a8925c-3c31-43a0-9de3-d2f6b6c8f4b7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8861), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8861), new Guid("69b142e9-56c5-4ce0-bb33-1536646065cc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8864), new Guid("ef0de775-202f-4acb-800f-145399ff8038") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8870), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8871), new Guid("0936a86c-1e84-4037-8e95-138087ee5def") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8872), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8873), new Guid("5a1ef3f7-fbdc-43f2-9cc7-79474a58f35c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8875), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8875), new Guid("06a460a3-0831-414d-84a6-fa38b4db06ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8877), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8878), new Guid("2a125b8e-4f47-4df4-bc54-b4d2c9edfa9c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8879), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8879), new Guid("f635bf5f-a0e1-4d5d-bf21-95932d66f615") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8881), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8881), new Guid("92eeca8e-41f1-448e-8816-edf70d059c15") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8885), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8885), new Guid("f4e7c945-30ae-4248-9995-886b7c1dec9c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8886), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8886), new Guid("11a769b3-3dcf-4b4c-94d2-bae6f039aa52") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8889), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8889), new Guid("f50f7348-0348-4427-ba9f-39d2467c542e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8891), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8891), new Guid("5c72d265-a66e-41f3-bafc-1515513992b3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8892), new Guid("f94c7b3a-b18c-40e0-b396-bf49e805cdaf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8894), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8895), new Guid("5259c33a-b24f-4748-a9e7-4a8b2b571858") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8897), new Guid("f82fe29b-aa53-406f-9847-e67cad61cca0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8899), new Guid("4a84a6d4-59c6-4ed1-9834-3d7cb045316e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8903), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8903), new Guid("ca8c8b95-bbc5-4b3e-a9a6-24a57b94abff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8905), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8905), new Guid("8b24734c-8fa3-4567-b540-7a22b4f5e518") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8906), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8906), new Guid("16c7dd14-91af-4804-969d-18f027f015ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8908), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8908), new Guid("305a03c4-eaa9-42b4-a9b3-d4d4ced12d98") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8910), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8911), new Guid("1db413cc-f386-4427-9497-50ce22f34846") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8912), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8913), new Guid("23fb911d-9467-4d84-90fa-ad09dfaffa8b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8914), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8914), new Guid("722ed0bc-7f3a-49b2-86fa-a64d700d3fc8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8916), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8917), new Guid("9a7f3609-5b3e-4f2d-991d-55c78987ba5a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8920), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8920), new Guid("36bf6cc4-02e3-4e80-95e3-b83919f5b36f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8922), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8922), new Guid("69f7e378-742f-44cd-8feb-f6dacfe0cc0f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8924), new DateTime(2025, 6, 25, 16, 43, 59, 267, DateTimeKind.Utc).AddTicks(8924), new Guid("46835e27-584b-4ad2-97c2-c33b29f63c55") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7048), new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7049), new Guid("f8e14092-20d1-4563-8b88-ab8564ded7ce") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7252), new Guid("a7316981-3116-4035-8687-7aef3a312bbd") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7254), new DateTime(2025, 6, 25, 16, 43, 59, 260, DateTimeKind.Utc).AddTicks(7255), new Guid("48433ff7-9d17-44b6-ae1c-d311c22a57ff") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4144), new Guid("e1127e73-9167-4d00-a1ba-2ab5f2f50a14") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4147), new Guid("dd3e00f4-849c-4801-807f-d6a2f905f8a7") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4256), new Guid("6522b597-079d-42f9-9b31-be53901e2b5e") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4258), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4258), new Guid("5cb907df-ee7b-4c83-b7a4-000c1d78877d") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4261), new Guid("35fdd902-3560-40bb-b7f5-0d606ec7b15f") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4262), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4262), new Guid("8e356804-3233-427c-b48d-e4e7879388cd") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4268), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4269), new Guid("93a7b2fc-3385-495d-a105-7cab408b2bb4") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4271), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4271), new Guid("0443df5a-841d-4870-9754-e7e36f83afa0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4273), new Guid("bca7483d-7134-4ebf-ba0f-5a8b73aa9d57") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4278), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4278), new Guid("de62e0d2-ca51-4adf-838b-ebad4c2c1e3d") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4280), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(4280), new Guid("aa321ec0-8949-48a9-8d91-cef777c67cc0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(7297), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(7297), new Guid("6f851eb1-e3ba-4cce-9e70-6b1adbb7ece0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(7299), new DateTime(2025, 6, 25, 16, 43, 59, 262, DateTimeKind.Utc).AddTicks(7299), new Guid("54d6752f-9f78-440e-b80a-7a5637f179b4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 268, DateTimeKind.Utc).AddTicks(4388), new DateTime(2025, 6, 25, 16, 43, 59, 268, DateTimeKind.Utc).AddTicks(4388), new Guid("f2e02761-fbf2-4b48-bff7-295bb46ce5b3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(869), new Guid("66bb6cce-2ba1-4b9c-a60c-fcbb9d81d0f6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2141), new Guid("e3110bc3-d073-4935-a6b1-c8933afdee1d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2150), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2152), new Guid("8c7001e2-ca54-4808-85e8-bc4a9ce519a8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2158), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2158), new Guid("ee9578bf-7a7a-47d9-b83f-4780f2ffb1e1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2172), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2172), new Guid("abe374f8-8e35-4b66-bcde-cd0c271a00ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2178), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2179), new Guid("b46f2dc0-6edd-493f-9e90-bc4639021467") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2185), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2186), new Guid("7632a272-5845-4010-a5ab-e814f4cf7098") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2191), new Guid("329e22e5-081e-4293-915b-fe58ffae7e95") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2214), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2216), new Guid("da4aaf44-94d0-440e-9b3f-3c27940632bd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2221), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2222), new Guid("59e9036d-1d28-4f61-96ca-3a4d3e2ec386") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2228), new Guid("e0293bc5-0de6-4eaf-be0f-ea7331268212") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2233), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2234), new Guid("c9661df0-b9f4-49fd-a6a8-f307aabc2e3b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2243), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2244), new Guid("7f3ac869-37f7-481e-96e8-22b4b5e5ffce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2249), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2250), new Guid("ca3287f9-3ffe-4edf-ae00-a4910d416fbe") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2258), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2260), new Guid("9628f841-69ef-4296-bd0d-55734958eeb6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2264), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2266), new Guid("acf577bb-e1a1-4643-9e7a-f31210d228ba") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2272), new Guid("1d0dd876-201a-495e-ad91-b5b7f5fcaadb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2289), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2291), new Guid("1941a52f-5c37-4763-a1c7-8f6d0f4d12cf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2296), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2297), new Guid("3e26b39b-088a-4502-8582-4c92bbc38f6c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2302), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2303), new Guid("5a497397-7618-484a-92ff-e6d3eb6e427d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2312), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2313), new Guid("1f48a7ad-650a-44ac-a388-abfd35b04a8f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2317), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2319), new Guid("d625a890-1cc5-46eb-9d32-c2be34999c86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2325), new Guid("0349e903-6c7d-414c-8a9e-4ac603cb9f32") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2330), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2331), new Guid("de0dcb6c-2eba-498a-943f-36bfca9451c5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2336), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2336), new Guid("d3ead76f-d643-46f6-8735-95022e4ae74d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2341), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2342), new Guid("ed582ab3-813b-46cd-8fce-1d67cf53d9be") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2348), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2349), new Guid("a5f4f095-78eb-4644-b671-a0a9542c236e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2354), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(2355), new Guid("cdb3fbee-7466-4420-a92c-d3c41e6c3bf6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(9952), new DateTime(2025, 6, 25, 16, 43, 59, 270, DateTimeKind.Utc).AddTicks(9952), new Guid("0062c9be-561b-4016-853f-9aab191028c0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(605), new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(605), new Guid("f5649ef4-d666-446b-82b3-24fb6c1d5381") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(608), new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(608), new Guid("41c7ff5c-87f8-4221-bcad-2d6cf7ffb69b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(610), new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(611), new Guid("dbdb61b5-3cde-4272-921c-42f6b5356952") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(613), new DateTime(2025, 6, 25, 16, 43, 59, 271, DateTimeKind.Utc).AddTicks(613), new Guid("4b180c8b-fde1-47f8-9c91-eaa9c659cb9d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTemplateMaturityPath",
                schema: "Dcube");

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1165), new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1168), new Guid("4635339b-f5d1-4073-8272-581f86ec4c8e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1553), new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1553), new Guid("f9bed135-dce3-4beb-a5d9-d58e06476216") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1555), new DateTime(2025, 6, 22, 12, 44, 34, 669, DateTimeKind.Utc).AddTicks(1556), new Guid("569badf6-3ecf-4e86-b3d0-2688113c4e01") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(216), new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(217), new Guid("ed53d42f-cc84-420e-90e6-94056b6d5c55") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(859), new Guid("47848678-4cb6-42d5-909a-81c631f2074d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(862), new DateTime(2025, 6, 22, 12, 44, 34, 670, DateTimeKind.Utc).AddTicks(862), new Guid("285db0f2-661c-4c1e-a0e3-5ba97db4a174") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3402), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3403), new Guid("c3e285de-ea12-4170-a1d8-8ac1c0c600bb") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3668), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3668), new Guid("c0e36b02-2a78-4f3a-bb4f-ad0c11386b28") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3742), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3743), new Guid("4b6765aa-c134-43a1-a6c5-863f226df098") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3747), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(3747), new Guid("8f617222-c794-40f5-af6b-3c25c2939f7d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(8623), new Guid("60439458-1771-487b-9588-9e46bdc33b3b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9078), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9078), new Guid("eaae6e80-a4c4-4d6c-bee1-e9bea2ee8ed5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9081), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9081), new Guid("7d986f99-a086-4ba7-83c2-66d736384115") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9082), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9082), new Guid("6d766375-5734-48d4-83ca-19e9b036e5e5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9086), new Guid("5e6a5f30-d3c6-4437-b343-3dc9eee93af3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9088), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9089), new Guid("2fa34e2f-9058-47a0-99d4-171a53f2f790") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9101), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9101), new Guid("c6fcebaf-70f2-4c38-b365-d00daa3f8271") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9103), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9103), new Guid("226b9156-401d-47e5-9fd8-3661d5def76e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9104), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9105), new Guid("1a991ae0-bbd4-4719-9e99-fd96704ef342") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9107), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9107), new Guid("321262ca-722b-4d9a-8d0d-a3519b1954ae") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9117), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9117), new Guid("a05c4d92-2008-462b-bd79-08b8f0ac43e7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9118), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9118), new Guid("fdc378d9-0e93-42d2-8be6-9cf463693b3a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9120), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9121), new Guid("12e34f45-0522-4af4-8ff1-447e0bea11fa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9123), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9123), new Guid("9a4d481d-3fce-4e6f-b2e3-0ea4b294005a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9126), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9126), new Guid("6e04a761-9f19-4eb5-9207-a5ea9d2adaf8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9128), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9128), new Guid("395a86a8-9f76-4072-a9af-71fd3b8175f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9131), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9131), new Guid("17406378-ff3b-4b49-8857-b120b95200fb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9132), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9132), new Guid("46032c65-97e8-4636-85d5-6a0906bb2476") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9134), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9135), new Guid("086b58c6-7350-4d1f-8e56-6a50c8c16134") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9137), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9137), new Guid("bc098d5c-3d70-4abc-8d40-4f8ea195ef87") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9138), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9139), new Guid("6dced478-3f6a-4406-8823-afba99b09697") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9140), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9140), new Guid("7db25fef-b502-4f47-a71e-11ba157e161b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9148), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9148), new Guid("2938cc53-0efe-4345-b6a3-9f619227eeea") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9150), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9151), new Guid("9088a1cf-19f0-478b-9565-6d66508ea70b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9152), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9152), new Guid("66cb5984-d3c7-4c96-abf0-1ab284e79f92") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9154), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9154), new Guid("e9f5d22a-d51c-447e-9008-9fe0f0fab961") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9156), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9156), new Guid("5d91edfc-fbd4-4d30-9a06-7aad14a036e8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9157), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9157), new Guid("322191de-5631-4835-9187-88418d2173cb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9159), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9159), new Guid("13cf9cb4-bb30-44e8-b9dd-0c2393a13e4d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9161), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9162), new Guid("13601440-a6f7-4ddb-adfb-d97b35be22ad") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9165), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9165), new Guid("56061da8-d99d-4cdd-a898-faf1ddad2e8c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9166), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9167), new Guid("3bdbfa1d-f428-421d-92ab-42e3f371fde9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9168), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9168), new Guid("33ebf82e-1407-4188-9e8b-36377cc2ed65") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9170), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9170), new Guid("50c9ffae-3971-455d-b83f-789ea8213970") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9172), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9173), new Guid("2e0f806f-ea51-4c3f-8a5e-85f6b37c16d8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9178), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9179), new Guid("7d72a5fe-d17a-4328-bcbb-488c0ea4cf0c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9180), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9180), new Guid("d0b4e887-3213-40ad-902d-721f191f4337") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9187), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9187), new Guid("59e27b42-7cfc-408b-a9c5-7805e926a288") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9190), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9190), new Guid("a7e8dee1-5279-44a7-8072-19c8c28d6837") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9192), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9192), new Guid("66f4804b-ed6d-40ef-a391-3904c7d5fd79") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9193), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9194), new Guid("44d6ec2f-24d2-4b06-ad5b-a7aff1b58756") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9197), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9197), new Guid("bb6457a8-5573-4d39-842e-6cf8a528ebf1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9200), new Guid("960bbb3b-8dae-4349-8c7e-1452f6b16198") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9201), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9201), new Guid("a3394fe7-3a35-4923-82ca-c6900aa9ce97") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9204), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9204), new Guid("aac6138a-74e7-4650-a26c-a65fafc37564") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9206), new Guid("adad1d96-19fc-45d2-9cfb-a1a219286340") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9209), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9209), new Guid("9d9f0bb0-14f0-4e9b-9261-8593d30a78b3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9215), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9216), new Guid("4d10ef41-5c4f-49db-8d05-715235aa4730") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9217), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9218), new Guid("275b0d0b-0b42-4d6b-9d6b-bb4a74de8bd6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9220), new Guid("e45693ca-6717-4eac-91ed-99affd927b26") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9221), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9222), new Guid("43a751ff-c166-4e23-aa6c-f1da0550b5ec") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9223), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9223), new Guid("7d0ecc95-e8da-4143-af45-04eef9ad3c7a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9225), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9225), new Guid("ccb1d8bd-72e2-4003-adae-006e17ac7823") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9226), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9227), new Guid("7ae795d6-5c8f-42c5-a72d-3ea7c879badf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9230), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9230), new Guid("7e6938b4-5b3a-4db7-b8b4-de02c41c6bb9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9232), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9232), new Guid("b596a97b-c7a4-4576-be42-38a5062a42e1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9234), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9234), new Guid("2d3cc7eb-eb77-41bf-bd1f-af431ec9c9d9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9236), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9236), new Guid("8c82cc19-ec0b-444e-a363-4299886222ff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9237), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9237), new Guid("89800cf2-609a-4794-b8d8-3bc5110de44e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9239), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9240), new Guid("c53b2307-2889-4eda-8834-8136d74aa4be") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9247), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9247), new Guid("ca3b19a9-ac2e-44c9-a010-c449ea8b4716") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9248), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9248), new Guid("61cb47c5-8150-4ca1-968e-afe661c46558") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9251), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9252), new Guid("1abd21c9-59d9-4fe5-b4d4-f74c471a4978") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9254), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9254), new Guid("deeaa253-8b7a-4755-a517-1bb259847249") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9255), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9256), new Guid("dbd74990-356b-4258-9e02-738480b66804") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9257), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9257), new Guid("0bafccb0-5a26-40a2-902b-e5371a42af96") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9259), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9259), new Guid("0d7b4040-dd25-4491-a554-c3bb9d7b3c6f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9261), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9262), new Guid("5043e8f7-18a6-472b-933f-65d7d01860c4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9262), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9263), new Guid("d68331b0-ee15-46f2-ab66-41d8ec39e0e2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9265), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9265), new Guid("90eef366-a616-4763-9b98-1dce2ea806b6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9268), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9268), new Guid("c8de0ba1-37d0-4582-be74-07920dc219b0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9270), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9271), new Guid("65a95abd-ca58-4457-9696-6d707369a24c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9273), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9273), new Guid("67100444-dc66-4160-88f0-3587220e37b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9279), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9280), new Guid("4893c117-d70a-4cfa-b0c7-3e5cbaf4e1a6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9281), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9282), new Guid("7a512e40-3e8d-4d1e-b9c7-6e21af693df8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9283), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9284), new Guid("625e6180-1890-4cba-8395-fa2bec0a6575") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9285), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9286), new Guid("03f6b3db-ed38-4f8b-b657-f1a1f859a94c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9287), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9287), new Guid("1d234a92-13b4-4cbc-8886-47a856ecc6d8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9290), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9290), new Guid("8a90a685-5b08-4b2d-8566-de67df1a2f15") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9293), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9293), new Guid("add3c34f-cfd8-48a2-865b-fadb3dc3276c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9296), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9296), new Guid("b969c1c2-3cc7-426a-92a8-4dca92597c1e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9298), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9299), new Guid("c21f3c73-d64c-4c5b-b2b1-aee5a9ba1e75") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9301), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9301), new Guid("9fa736e6-7614-4d1f-8cc4-2bc00c066e5c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9302), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9303), new Guid("a545cfd7-0f2d-46b3-a569-66e49c0937c5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9304), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9304), new Guid("c8aae62e-ba46-461d-85f5-1a4a37fd215f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9311), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9311), new Guid("14f8f507-5d90-4c64-8234-c4374ae8a89f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9314), new Guid("10000476-ff3d-4d94-a665-1b08ecebd927") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9315), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9315), new Guid("8d9bafbe-3d69-45b9-8d89-71fc63911c13") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9317), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9318), new Guid("91d21a86-6642-4a56-8b22-fc8b88e52676") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9319), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9319), new Guid("3931a198-d4bf-4dda-b6d1-6de3552f9bab") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9321), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9322), new Guid("b7e19d5c-e751-49d7-825d-7ffb4f70bc62") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9323), new Guid("c714e2ab-f5a1-4018-9897-f9929ef1377f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9325), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9325), new Guid("29224d04-133d-4cb1-abeb-9fca0683d5c8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9327), new Guid("e798136a-da29-4779-85f9-1a8db7a14847") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9331), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9331), new Guid("d40177e2-87b9-4f22-9866-ac8b8fffda6a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9332), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9333), new Guid("d1c97a81-94b6-4421-b2cb-d59b6e630f1a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9334), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9335), new Guid("6ec30cfe-af8d-401e-952f-c405f227aece") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9337), new Guid("c9e3b7ad-83bd-4032-b2e5-7e575803b99f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9339), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9339), new Guid("ccae41b6-00a8-42fa-a77e-fe7712a4dc3b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9340), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9340), new Guid("12ee3224-d4a7-45ce-b1e6-fc444d782104") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9342), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9342), new Guid("36792fa0-dc59-4077-ae6e-06f75362da8f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9343), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9344), new Guid("ea54101b-c9f2-4fc2-be13-cc5527dea32f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9347), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9348), new Guid("91ac3b2c-67c0-4725-936c-7ccf54aefdfd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9349), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9349), new Guid("43ab17fc-7311-4dff-bd6b-22e6be9bdefc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9351), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9351), new Guid("fc972b59-2931-4520-a0cf-acac5b1b5996") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9354), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9354), new Guid("87ed4f10-1169-4567-9eb0-2d0466b0ae83") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9356), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9357), new Guid("79659336-88cf-4b68-a459-c58321120dea") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9357), new DateTime(2025, 6, 22, 12, 44, 34, 678, DateTimeKind.Utc).AddTicks(9358), new Guid("81e1bc17-03d2-42f6-93af-b6e30e23042b") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(5855), new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(5856), new Guid("e86f7dbd-5a2a-4ae4-bf5b-714bf250909c") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(6043), new Guid("b6f92772-d278-4441-9ee1-5840a7a80c11") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(6057), new DateTime(2025, 6, 22, 12, 44, 34, 671, DateTimeKind.Utc).AddTicks(6057), new Guid("4d72a4fb-416a-4988-8131-95c58ef774fd") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9650), new Guid("7e4ffec4-6f6e-4893-b2ab-8e84fa071e7c") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9653), new Guid("3ce1c854-0b75-4843-b5fe-f5b0d873dbcb") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9763), new Guid("99bbf5b8-706b-4b81-8e9a-8842e3782b1b") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9776), new Guid("ce6972db-5bcf-4530-950f-08a4981fc293") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9778), new Guid("ba4ad9c3-eddd-45f6-899c-d11c76d015c7") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9779), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9779), new Guid("d8a25647-5ac6-4830-aed5-6623be2ea33c") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9781), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9781), new Guid("9e2bb4da-e36e-47c4-a334-ff6255b3db01") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9782), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9783), new Guid("f418d233-bba8-4b48-ae28-e6a7f1d65550") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9786), new Guid("6f81199b-c2cd-4f75-9f11-642952c549e1") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9787), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9787), new Guid("96661f7b-16ed-49e8-bcd4-77a5f7031634") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9789), new DateTime(2025, 6, 22, 12, 44, 34, 673, DateTimeKind.Utc).AddTicks(9789), new Guid("1cb470d6-6e19-4114-a9f2-9c72e69e5b9a") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 674, DateTimeKind.Utc).AddTicks(3120), new DateTime(2025, 6, 22, 12, 44, 34, 674, DateTimeKind.Utc).AddTicks(3120), new Guid("6d7618bf-2dd4-4cb6-ad09-9dccd6b7812d") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 674, DateTimeKind.Utc).AddTicks(3123), new DateTime(2025, 6, 22, 12, 44, 34, 674, DateTimeKind.Utc).AddTicks(3123), new Guid("571c2015-3ee5-4c3d-af2e-90c3a525a180") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 679, DateTimeKind.Utc).AddTicks(4214), new DateTime(2025, 6, 22, 12, 44, 34, 679, DateTimeKind.Utc).AddTicks(4214), new Guid("192a9bd3-7376-45fa-8008-1570564897b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6139), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6140), new Guid("68b9868a-3e8b-42ce-a221-419f20717954") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6593), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6593), new Guid("648554ea-15e7-4f1f-a119-4bd2987d4e3e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6601), new Guid("b3cd11b9-6b89-412e-a331-ea599ee8e963") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6602), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6603), new Guid("c9855d13-9956-4776-b36b-54149373fdce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6604), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6604), new Guid("783c1e1c-924a-4113-883c-925b56a58749") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6606), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6607), new Guid("4a94c86f-d994-4eaa-8701-dffa72e7a163") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6608), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6609), new Guid("487995ae-53c4-4816-a2d1-41cc54915b95") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6617), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6618), new Guid("f1e00d00-89cb-475a-885b-04a157f08df3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6619), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6620), new Guid("c6434519-26cf-40a2-91ca-a74a9ea6c726") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6623), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6623), new Guid("18d5a680-1db8-4ecf-9430-f332bcc1087e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6625), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6626), new Guid("887f8b51-f078-4c85-8c98-e552a33916d3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6627), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6628), new Guid("5bb2daf5-014c-4cbd-9beb-fd7552a6ecef") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6629), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6629), new Guid("25e2b790-3ea8-4477-9992-766102736325") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6632), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6632), new Guid("a6fa297d-a0c6-4f15-ba19-b340236b89a4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6634), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6635), new Guid("92f8ff1c-f439-4252-94aa-6dafb46ebbfc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6637), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6637), new Guid("c2cdbc0b-b142-4632-809f-5dcd929133da") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6643), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6643), new Guid("eabd39a6-e525-4778-8771-6b83856d4d03") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6647), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6647), new Guid("37fc1772-6927-4694-a1fe-a598d28ee27e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6648), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6649), new Guid("7722f137-1cff-4869-a6c0-5c1717e0697d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6651), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6651), new Guid("32edf0d0-c0c8-4f5d-8f3c-36e4d51c8b6c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6654), new Guid("7ce9aa32-3f5e-480a-96b3-c426db89fe8b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6656), new Guid("b4e8d52d-36de-47d8-a955-26e6ec43e6b0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6657), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6657), new Guid("e3f14a7a-7e3a-40d3-9d7e-dd0c4c7937d7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6660), new Guid("ad265294-150c-4cb5-9c3c-ebe12dc026bd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6662), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6662), new Guid("b50e96e9-0358-47fe-8433-f5162f3b7cb0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6665), new Guid("4fa1f89d-3b20-4129-a5af-1f9ee53fb757") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6667), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6667), new Guid("58c0c8ce-880f-40ea-8774-55aed16b3c18") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6669), new DateTime(2025, 6, 22, 12, 44, 34, 680, DateTimeKind.Utc).AddTicks(6669), new Guid("2cd19bb2-ca49-400d-9990-fb4dcac070df") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(4448), new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(4448), new Guid("e53b4911-30fd-4938-aa46-ba919492f43b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5070), new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5070), new Guid("f0a9c6fc-aee2-48d1-b056-476db1ab99ce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5073), new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5073), new Guid("ef645f28-6fd6-4972-bf93-be4b2769b24f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5076), new Guid("e8a777da-c1e5-4b2c-8faf-a8d63b76d1e0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5078), new DateTime(2025, 6, 22, 12, 44, 34, 681, DateTimeKind.Utc).AddTicks(5078), new Guid("93cc4c32-0324-46fb-8d81-950cc6f1dfca") });
        }
    }
}
