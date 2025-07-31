using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RenamedClientTemplateInformationSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientTemplateAddSectionResponse",
                schema: "Dcube",
                table: "ClientTemplateAddSectionResponse");

            migrationBuilder.RenameTable(
                name: "ClientTemplateAddSectionResponse",
                schema: "Dcube",
                newName: "ClientTemplateInformationSection",
                newSchema: "Dcube");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientTemplateInformationSection",
                schema: "Dcube",
                table: "ClientTemplateInformationSection",
                column: "Id");

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
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3096), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3096), new Guid("93ba463e-6b25-4f75-abe9-2dd1d089f8c7") });

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
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3146), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3146), new Guid("087dd2ea-7185-4f3c-bad2-ae806c057cf5") });

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
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3158), new Guid("c2ddf3d0-bd7f-4f1b-b87c-30a7f8c46951") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3161), new Guid("a459d5dc-bfd9-4322-b837-ec0ac950e8d2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3164), new Guid("70c2fffc-5ee5-42cb-b472-c5a1084ec651") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 7, 7, 3, 47, 57, 152, DateTimeKind.Utc).AddTicks(3167), new Guid("f703eb3b-8d3b-4616-95ee-37d7c099d296") });

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
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4061), new DateTime(2025, 7, 7, 3, 47, 57, 163, DateTimeKind.Utc).AddTicks(4062), new Guid("6a753fdc-b446-46d2-9950-a0ce1c13134a") });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientTemplateInformationSection",
                schema: "Dcube",
                table: "ClientTemplateInformationSection");

            migrationBuilder.RenameTable(
                name: "ClientTemplateInformationSection",
                schema: "Dcube",
                newName: "ClientTemplateAddSectionResponse",
                newSchema: "Dcube");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientTemplateAddSectionResponse",
                schema: "Dcube",
                table: "ClientTemplateAddSectionResponse",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(422), new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(426), new Guid("e595f14f-a897-4b5d-8970-20316cc02ffc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(828), new Guid("c8423b03-37cb-4207-9fab-f1522ac8bd8e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(831), new Guid("133b59b6-d13c-4358-81b5-a08fdd7ef38f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(9860), new DateTime(2025, 7, 5, 15, 4, 2, 413, DateTimeKind.Utc).AddTicks(9860), new Guid("cafaa59c-80ac-442f-9ecd-222649efa953") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 414, DateTimeKind.Utc).AddTicks(541), new DateTime(2025, 7, 5, 15, 4, 2, 414, DateTimeKind.Utc).AddTicks(543), new Guid("df253fad-b741-45e9-a5ba-29e027b8470e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 414, DateTimeKind.Utc).AddTicks(565), new DateTime(2025, 7, 5, 15, 4, 2, 414, DateTimeKind.Utc).AddTicks(565), new Guid("cd90dbae-bcf0-4810-b49c-f53da72d4df2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(6713), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(6715), new Guid("f6e31d4c-3507-442e-9e82-ec66a8dcbcc7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7202), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7202), new Guid("09cd82ed-8cc3-4160-a924-dd67cb6f74fe") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7206), new Guid("230b3a49-be51-4f28-9ea5-192e0310f8aa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7215), new Guid("49e832da-840a-46e3-a07d-0ba2d950bee6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7216), new Guid("fce7c8b8-3432-4fe6-b0c4-fb044d2b2693") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7219), new Guid("fb9e4360-6713-4aa7-86eb-7a4bfca962e4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7221), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7221), new Guid("040d89ea-ec3f-4629-850f-d0f2ba165cd4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7238), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7238), new Guid("80c35832-d75e-4b5e-bf1e-6ecb565c323b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7240), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7241), new Guid("5fbabb8d-3f54-4618-bc2d-248bb8e67e28") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7243), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7243), new Guid("59fe0548-1c14-4ea2-96fc-e4eca5dce8ad") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7246), new Guid("52bdb76f-95d2-4a6c-8b8d-34c73e97f076") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7248), new Guid("1a8c36b8-7068-44c5-9a0c-ec7ac4a96e76") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7249), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7249), new Guid("6358a784-b537-4fe7-b444-eac503195e39") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7252), new Guid("11f05205-7a60-4279-b87b-14e0f35d0e6e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7260), new Guid("512eea75-bf3e-4bc9-bfa9-eb5eafc8f70d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7264), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7264), new Guid("28876215-76eb-4328-a456-a3687ae3e037") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7266), new Guid("ec74ae4d-8622-4f06-ad6c-b7af52b2526d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7270), new Guid("71495773-7d69-42ac-973e-fde21fd6ac00") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7271), new Guid("7b7b0389-5551-4a62-95cd-a46fec5d9c7e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7274), new Guid("03f8388f-35c7-4d41-8ffe-85d00b56582b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7282), new Guid("e0c293c2-0b66-4eba-8772-fec69857baae") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7285), new Guid("0b07a7db-faaf-47ad-9895-bbc88b7d025c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7288), new Guid("e2898c79-6732-41db-9925-2b8de7863a6d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7291), new Guid("8f337cfa-6971-481c-9aa1-0032c409138e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7293), new Guid("5533f8a0-53fd-45f7-94a5-2cc50ecded4f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7295), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7295), new Guid("ea8d1328-e4c5-4369-ae91-1d10db09cdfd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Information",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7297), new Guid("2e721d98-9c11-4b8e-8a5d-0aff2ef1a17b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8187), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8188), new Guid("f2a540a2-2569-43c9-8671-c05eaa1f4e08") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8476), new Guid("db7620f1-0b37-412f-8966-22c6c3091d23") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8479), new Guid("199e1746-cbb3-4820-9d4f-13a8c212c925") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8481), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8481), new Guid("ff20fb86-4f41-4bad-9c35-4f04812d61db") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8482), new Guid("f5b8df8f-8824-41ef-ba47-13c397cb43ae") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "InformationSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8484), new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8485), new Guid("472e4a4e-c8df-4611-bc9b-af059bd231ae") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5121), new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5121), new Guid("5e42f6a7-7d64-4ddd-9fb1-f54e56d36ec8") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5354), new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5355), new Guid("ef7b4a1d-e3d9-4aac-acba-ac24751a15fd") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5413), new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5414), new Guid("58133a05-f821-4730-b134-c0bb83548126") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5416), new DateTime(2025, 7, 5, 15, 4, 2, 426, DateTimeKind.Utc).AddTicks(5416), new Guid("a0a36746-1c94-450a-9b54-e4d591c5feb6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8124), new Guid("6be6ae8d-823a-4890-b63b-58c31f7eab65") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8585), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8585), new Guid("f83d6062-a767-4e9a-b0f0-946a499fa895") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8588), new Guid("bbbce753-a2b3-4cd9-a635-acd65f16f100") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8598), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8598), new Guid("600a663b-c8f8-40f8-a298-e475fa2222e9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8599), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8600), new Guid("d571bf92-5a8b-4a14-a467-673e511a26ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8602), new Guid("4ecc9070-f47d-4440-8f8f-7ff973e49474") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8604), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8604), new Guid("8da0127d-ab5c-4537-8ed1-eade82dcf43c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8606), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8606), new Guid("488f5d26-bf8c-4833-b2a5-12342ff722a9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8607), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8608), new Guid("f5966ba2-36ca-4dc4-a7cd-f4ea2adde101") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8610), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8610), new Guid("9713d97a-72f4-4cab-b040-d8e31fa6e83a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8612), new Guid("a932f4e0-753c-4230-b6f3-755f58744086") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8615), new Guid("740612b0-b98f-486a-b948-db2884ad634a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8616), new Guid("34e96f97-dbdf-4197-a878-8d461eae0d4c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8624), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8625), new Guid("153a0ded-bbf9-4021-a7f2-78889fe05485") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8627), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8627), new Guid("24701fa3-b7b8-4144-80bd-94312376f20a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8628), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8629), new Guid("c6ae5832-cb3d-4122-a8bc-c62eeb967c35") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8631), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8631), new Guid("eca2df00-567a-4ae3-af69-5867ec2bbf37") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8632), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8632), new Guid("567cf786-bf5e-4180-a434-ef59dd154b57") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8634), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8635), new Guid("18a29489-540a-428a-a01d-7a9ebcd08afe") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8638), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8638), new Guid("fe80c803-9f9c-4b73-91fd-3e9351432200") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8639), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8640), new Guid("a7371177-f254-453f-aace-e0fbdb47cfeb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8641), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8641), new Guid("3687a517-44d9-4b29-8cf0-23be9d547c66") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8643), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8643), new Guid("ce12a80d-cb18-4d5f-ba11-35ba3a9fd275") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8645), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8646), new Guid("ded1b132-e954-490f-aa2c-6798805dcbd2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8647), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8647), new Guid("9023110d-a3ac-4440-8cb7-f689e27ee853") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8653), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8653), new Guid("f581e9d1-f4db-49df-bccc-3101c3becb0c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8655), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8656), new Guid("81715c38-571e-4ae8-bed0-8cdf7dc1f72f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8659), new Guid("07e16a36-7e0f-4695-8a5a-3833f0ade67c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8660), new Guid("5e38de02-90cc-4c89-b704-582509d59360") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8663), new Guid("8a54262d-0e1d-4b03-9ba0-813f6ac9ccc8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8664), new Guid("85b6e216-077a-49a1-8f64-753f9687008d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8666), new Guid("2e01e464-93a7-4ec6-96e1-25277756f62f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8668), new Guid("e828a543-07cb-4ae3-9728-45b5e8b18b17") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8670), new Guid("9e383dc2-5ab2-4f1b-81a4-15fb99c9c174") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8671), new Guid("f0764fab-ba6b-40b3-917f-5e38d439df0e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8674), new Guid("2bb25320-f0d4-4a1f-a5e9-1c34d86a8343") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8677), new Guid("c37ab2c6-d7ab-40e7-81a7-c98013e882c4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8678), new Guid("32b630cf-e878-44d9-b9a9-a0c8add12b6f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8685), new Guid("7686b423-86dc-4f1c-9550-fca3e8da116e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8687), new Guid("1aad4b34-484d-4577-93bd-509cd565f38f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8688), new Guid("25dc68ee-2ca8-4961-83dc-8b62b9f6cdb7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8690), new Guid("1674c04b-c462-4293-8c5d-a5847bc6e15c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8691), new Guid("a6daa1fc-a845-4855-80b8-1e1e61b09956") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8696), new Guid("7bf2f5b6-55e6-42a1-81d5-789bcf8769f2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8697), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8697), new Guid("669499ef-7d76-4dc2-a9bd-c4e8faeb1552") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8699), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8699), new Guid("f505326f-30d2-4567-9bd7-cc04bc381e43") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8700), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8701), new Guid("8cc01345-495f-4ac5-b92f-503f7fa3c524") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8703), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8703), new Guid("0c913872-7423-48a8-a995-e305715e1673") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8705), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8706), new Guid("a25f8b06-2a5b-40b9-b007-74a5358bf535") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8707), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8707), new Guid("a820aff8-97ef-4e25-8eb7-0179bbb81d1b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8709), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8709), new Guid("27ef251d-bf0d-468c-a9b7-0c99c7c3ffd7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8716), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8716), new Guid("62d6e83f-cd71-408f-9030-a2dfa9941b22") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8718), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8718), new Guid("55e1e351-2ef1-4756-b82a-b94af851403a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8725), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8725), new Guid("3acb787f-72e6-45f9-a469-db2d82d4c525") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8727), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8727), new Guid("651fec17-1d48-431d-bf8b-dcd94f08b74b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8729), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8729), new Guid("7460ee8b-699a-4bdd-85cc-a4b74531a0c8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8731), new Guid("1d21aa3d-2ca0-4f1b-bb5c-4a2bb2b6c8e0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8732), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8733), new Guid("41a439e0-ac72-48ac-8bf5-9b8262cb5f01") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8735), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8735), new Guid("6b0d02d7-3891-464b-8f55-0c2ed0cffdc2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8738), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8738), new Guid("d970e9f9-03ed-4286-99e0-126deb5d6adc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8740), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8741), new Guid("e3d51f29-0bc2-454f-b6ba-fe5f01baee5f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8743), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8743), new Guid("ef5e9ce4-1011-429d-b501-1ff10a3b76f5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8745), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8745), new Guid("9fc3193b-9403-4197-89e0-20f7164d533e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8751), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8751), new Guid("a2987f02-64d1-49f4-97a8-8eae05070e3a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8752), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8752), new Guid("27a64688-3388-4cf5-b605-633721b36a2a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8754), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8754), new Guid("0bdc3502-f368-498b-9e61-112a7562ce5b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8756), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8757), new Guid("13cd217f-9a6b-4d84-bf76-0a9467154c4c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8760), new Guid("cf06c6d3-cd80-4365-8887-a8b4e74884fe") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8761), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8762), new Guid("cc92d41d-d809-4976-9bd3-5c791367df03") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8763), new Guid("d1ba5944-7c9c-4f94-981c-5b09ae9c17b6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8765), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8765), new Guid("6910f63f-418a-4474-b819-a2a3d077bc30") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8768), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8769), new Guid("9078aca6-9db7-4bf1-9917-17b2ffb7a26c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8771), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8771), new Guid("6a5cc4b6-740b-49ed-9252-5ce121280755") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8772), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8773), new Guid("0fb01535-eeb7-419e-90fc-9389c360d235") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8774), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8774), new Guid("6fc9aa42-2dab-4c86-b872-ea070424be92") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8777), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8777), new Guid("bd84c517-760d-45cc-86af-0ffb2d78e34d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8784), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8784), new Guid("c92880cd-577e-4e85-94e1-379c6665d259") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8785), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8785), new Guid("4ff877c5-ded7-4c82-83d6-4402d0de7d97") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8787), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8788), new Guid("c8fd812e-60aa-4c57-9087-72a2027b6935") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8788), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8789), new Guid("8aba57a0-2fc6-4ff9-82a5-c4ac04a1af65") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8791), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8791), new Guid("c16cc2b1-4269-4ff9-b347-a1c21d004a39") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8793), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8793), new Guid("3722a89d-8488-4939-900b-394cd2447a70") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8795), new Guid("68cdf4ed-a87e-4575-a7ed-bce7fcb516f3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8798), new Guid("750d8025-8965-4c25-8c96-e6f080c1990e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8799), new Guid("c4781451-ee27-43c5-b5f6-b7855944788c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8801), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8802), new Guid("30d20cc6-2cad-4207-b3bf-829c76fb689e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8803), new Guid("e57ba7e1-6275-4dbd-b0ea-4f2439bacbb7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8805), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8806), new Guid("4e488763-625f-4e82-8f5d-ca3e3ede165c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8807), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8807), new Guid("84f91e71-eb56-4323-9cd7-d97380cfac0e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8813), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8813), new Guid("462fc915-41a4-4f2f-9a4a-04f8233d116d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8815), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8815), new Guid("d2edd3c9-3efe-4c38-9324-43f11865c7bc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8818), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8818), new Guid("130df641-7091-40d3-a169-1390dc42c5a1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8820), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8821), new Guid("3d8b0b88-1b5f-4c78-9d9e-24b4c6ab43be") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8821), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8822), new Guid("3b130779-52dc-409e-82f5-c2ec49da991f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8824), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8824), new Guid("a17facd2-522f-430c-af38-17043cea2fdc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8825), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8826), new Guid("6dfe619b-4bc0-49e9-994e-b1fd88a638be") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8827), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8827), new Guid("2920466b-a999-4cca-8b2c-b332bf27ef37") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8829), new Guid("a739fb96-413f-45d0-81c5-8c095eaaef48") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8831), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8831), new Guid("fd1a0250-905d-4314-a25f-7a84a3dcabb4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8834), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8835), new Guid("87e3da5b-7f85-425d-869f-3a52e2b1d63d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8836), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8836), new Guid("2ad92be6-9f96-442d-9613-17f04fdd4181") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8838), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8838), new Guid("cbbc1f33-e4fa-4ef9-9b23-2493df8ebacc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8840), new Guid("306f0aa8-c337-4514-bfad-75349c850c3b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8841), new Guid("b62071f2-be2c-4fef-a47a-0dc832178594") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8843), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8843), new Guid("3ac0c0a4-e1d5-4364-bbba-98228cae10d1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8845), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8846), new Guid("23f8b964-b349-42bc-bf20-e637559422a1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8846), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8847), new Guid("5bfb49ed-376b-4440-983d-b1e0d83a4c48") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8850), new DateTime(2025, 7, 5, 15, 4, 2, 430, DateTimeKind.Utc).AddTicks(8850), new Guid("35c2a40c-d8b7-40e7-a60c-ffe96227f6a2") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7077), new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7078), new Guid("6aa8aba0-1149-417a-ba3c-f16006fbe002") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7287), new Guid("64e95b80-d058-42ba-b6f5-6ab856a1afe6") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 7, 5, 15, 4, 2, 424, DateTimeKind.Utc).AddTicks(7296), new Guid("cf565b14-fc96-4e37-954e-3215d7367569") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(866), new Guid("7759a170-c2c2-4e9f-813d-01cc066dbed9") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(868), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(868), new Guid("5d1bdedc-3faa-48aa-8b06-be73424db1b0") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(987), new Guid("16c031d1-cbfb-4c90-af96-f51296f7e501") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(988), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(988), new Guid("b5d05a7e-fdd8-41c8-b1be-3917031bca43") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(991), new Guid("44e716c9-8f19-45ca-b061-7040dfc62e8f") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(993), new Guid("c23b0466-d717-4f90-984e-43f24c774044") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(995), new Guid("be9436b2-3b12-410f-9517-84e4e92fbbee") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(996), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(996), new Guid("fdb812f7-ed8b-42a7-a317-2edc79aee087") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(999), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(1000), new Guid("1cc458cb-84e2-440b-b71e-c5541dc91d1d") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(1002), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(1002), new Guid("9d089f00-0db9-477a-abc9-11e5a99080b7") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RenderType",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(1004), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(1004), new Guid("7d2bb4c7-2002-478f-b1c7-ebe4897424cc") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(4099), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(4100), new Guid("a3317132-6dbb-4180-8cac-380f98d48539") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "RoleType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(4102), new DateTime(2025, 7, 5, 15, 4, 2, 427, DateTimeKind.Utc).AddTicks(4103), new Guid("75b4d5fc-56a2-4c9d-aa92-a19e17b731c0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Template",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 431, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 7, 5, 15, 4, 2, 431, DateTimeKind.Utc).AddTicks(4341), new Guid("08d70e55-9a06-4f4f-9c1d-5fb980968582") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8144), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8145), new Guid("ce45a17a-9bed-411a-b811-54e58ad01e73") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8595), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8596), new Guid("3b874105-b8f1-4347-be0c-cf9a12ba890f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8607), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8607), new Guid("8f399425-516b-4401-89f7-c042254d6ec2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8609), new Guid("976155b5-4425-43e1-8e03-7d9ae8e2040d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8612), new Guid("1fc49ad2-ac5e-489d-b28a-9b5b6fd1586c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8613), new Guid("2f2d6cd2-f3f9-4b5d-8e1f-c75f458d5351") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8621), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8621), new Guid("5612dd91-cb9f-4966-898b-2c42a76de10e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8626), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8626), new Guid("13930016-b39e-49d3-95d1-782894562bf0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8627), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8628), new Guid("6937dd4f-dea2-4df0-9995-96ff81bbb889") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8630), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8631), new Guid("c424922c-558a-499a-9dd0-dafa7dfff6e5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8632), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8632), new Guid("2e9f7252-5c19-4599-9549-da585931c19c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8635), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8635), new Guid("14bd735b-0610-4cc4-b478-bf6555176faf") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8641), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8641), new Guid("18cf6c7c-a365-460e-bda9-c186e0253cc5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8643), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8643), new Guid("83ea2702-fd73-45b7-a663-ebf27fc5a9aa") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8646), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8647), new Guid("93b335ff-e8f7-4e8b-a5da-b0b2984c7957") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8649), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8649), new Guid("4183d459-016d-4329-ba91-8ab151e2a3b0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8651), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8651), new Guid("b539d735-7631-43c3-8f81-e270654ed0bd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8653), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8653), new Guid("7bf3c051-d242-4752-be94-6717a931aa6f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8656), new Guid("36aa222d-a499-4b43-bd76-36962f01bd88") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8657), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8658), new Guid("f769b0d7-47bf-40ea-9c53-425ea5d47940") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8660), new Guid("b40aa973-f502-4b0d-91cd-6f5b72523296") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8662), new Guid("891c613b-b25e-49b6-9224-153b24302acd") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8665), new Guid("19efbb2f-e273-409c-8a4b-2c39cfcb2045") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8668), new Guid("9d65a86c-a6fe-40fd-b5e6-dd4b12f7a143") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8670), new Guid("8dd6d62f-f414-4718-99b5-a82f29bbc1da") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8671), new Guid("c6dbef6d-ce99-4389-83c6-72c5e3a9b8f7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8674), new Guid("172baa50-05b3-44c8-85ab-78ec81ec0bb7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "TemplateSection",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 7, 5, 15, 4, 2, 432, DateTimeKind.Utc).AddTicks(8677), new Guid("e9d07044-c742-4e1f-8a42-6e2ed6260f39") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(5938), new Guid("974abe01-adf6-4e6f-89b6-febececa9937") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6548), new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6548), new Guid("3b9d07f9-170c-4f41-a8ac-e655a2912ea9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6555), new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6555), new Guid("4ee1f8e5-f173-4974-a092-1fb1b37d758b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6557), new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6557), new Guid("47c4b48a-1e7e-48fd-ac17-22ac9d1f8a11") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 7, 5, 15, 4, 2, 433, DateTimeKind.Utc).AddTicks(6560), new Guid("f223be27-f7ac-4fb4-909b-e4e70b24d85c") });
        }
    }
}
