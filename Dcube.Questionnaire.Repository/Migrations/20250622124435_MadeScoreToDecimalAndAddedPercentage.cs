using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MadeScoreToDecimalAndAddedPercentage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Percentage",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percentage",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                schema: "Dcube",
                table: "ClientTemplateSectionResponse",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5259), new Guid("465d84f0-0379-4429-9267-da88d4aaaa28") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5666), new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5667), new Guid("591acafb-4647-4962-a9d6-d8639abcc322") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Client",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5668), new DateTime(2025, 6, 22, 7, 10, 31, 27, DateTimeKind.Utc).AddTicks(5668), new Guid("df226c38-5577-40cb-a4e5-f7de563f703e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4122), new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4122), new Guid("1f4e1092-ab04-4754-a483-3ef67f99d975") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4820), new Guid("042b851a-386f-4f4b-acb2-058a941a412a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "ClientExtension",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4823), new DateTime(2025, 6, 22, 7, 10, 31, 28, DateTimeKind.Utc).AddTicks(4823), new Guid("df0dbc06-861c-4e45-a81d-b0f815877561") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5437), new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5437), new Guid("57b39e48-371d-40ce-8764-41bbe4acc386") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5568), new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5569), new Guid("aad57fb5-3632-4bc8-a2a7-999d5a7fcb32") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5612), new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5612), new Guid("67f9c584-f5d8-429d-96f8-4e5b1a43e484") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionResponseWeightageType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5614), new DateTime(2025, 6, 22, 7, 10, 31, 31, DateTimeKind.Utc).AddTicks(5614), new Guid("cdc5d377-e830-4a59-b3c2-f27d6ceb5886") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7068), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7069), new Guid("19c1b03c-3846-49fc-91ce-e0a34013913f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7517), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7517), new Guid("4d4712ff-4168-45fc-8cbb-c7eab376753c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7519), new Guid("4c7cbd34-a937-49cd-b45f-b4eaaf1f40f4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7521), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7522), new Guid("944a1b6a-de3f-4917-a59d-c119d3efce5a") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7523), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7523), new Guid("ab7cb426-8807-420c-91c6-a76fff9d7d07") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7525), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7525), new Guid("cdfc93bc-22e6-4ffd-a886-33754a90036f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7526), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7527), new Guid("c1c98215-a50e-48fb-b275-4c2f02fb6e47") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7540), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7540), new Guid("c5c2a306-9217-442a-8eda-029a2fd5fd93") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7546), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7547), new Guid("491f9231-1732-4d5a-bbf5-ffdb80a22209") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7548), new Guid("a0e6996b-4aa6-46fb-b051-cd36311c1c76") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7557), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7557), new Guid("7746bd1c-2280-4e5a-982b-7089d1bea5b3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7559), new Guid("2dcba2a2-8e55-4657-aeb4-81b99c8f0db1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7561), new Guid("4a799701-9b93-476d-b880-17d9c33a2a40") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7562), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7562), new Guid("3723f7b3-e1a1-42be-82ad-3f775adbf86e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7565), new Guid("1cf8bbc7-9ccf-43c7-80d2-4d4bc5eabbe4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7568), new Guid("52fe275d-9446-46e8-b683-2b14c43d809d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7570), new Guid("a6a99a3c-1b51-4d85-9c47-c5f4483f20eb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7572), new Guid("e008251a-e4ed-4a4b-a662-7d80d92410c2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7573), new Guid("9524ce60-74a2-482c-95b7-bff8ad14c8dc") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7575), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7575), new Guid("6dabf280-d3bf-4c93-94ec-ae9bb645d0a0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7577), new Guid("ae9a0985-40d0-48fb-98e6-d6f6e480c298") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7579), new Guid("45858771-482b-483c-b0cf-8484c32bbab6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7585), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7585), new Guid("11467b44-f4af-4e43-9d8c-3519550184b2") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7588), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7589), new Guid("1f5291ac-fab8-49ae-a7be-5267c72619b7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7590), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7590), new Guid("baad262e-ab15-4656-96d4-32949a53de7c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7592), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7592), new Guid("85d6c83a-938b-4b47-b1b3-4a47d060743d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7593), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7593), new Guid("3caa9a1f-01e3-4d87-8f57-36d08a069aa5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7595), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7596), new Guid("2f676853-d372-455a-a8eb-f001b625e6c7") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7598), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7598), new Guid("b2e71a38-623c-4d93-a928-df6cc3c76997") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7599), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7600), new Guid("57ba7f6f-03a0-4f09-a798-9666be7fb105") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7601), new Guid("609f7d1b-0876-478d-991e-361c8a186875") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7604), new Guid("4e199cac-2379-4063-802c-e8725d0bc950") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7606), new Guid("2dca2eaf-d143-4038-9808-50f6b8204a7f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7607), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7607), new Guid("4c3d2f30-133a-4270-8905-16c81a115d55") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7610), new Guid("22e9ff06-f95d-4263-bdf1-6f9a2616c8a5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7615), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7616), new Guid("d9513688-3015-44ad-b88c-725948189575") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7618), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7618), new Guid("7c35233a-d98a-4897-a8f0-7711bbd60935") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7619), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7620), new Guid("ac8d841d-670c-422f-9516-9045b93b5ca0") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7621), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7622), new Guid("8301980b-41a5-4390-83f6-629536159df4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7625), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7625), new Guid("8d3daf09-7e2a-498d-a749-faad35450aff") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7626), new Guid("0fe903fe-577a-42a7-8d33-d32c8c83e592") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7628), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7628), new Guid("dee65e6d-92c9-4767-bc27-c65ccde11297") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7629), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7630), new Guid("1895f947-0dc2-4a29-b5ae-bfff35e4bdeb") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7632), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7632), new Guid("2f69b0da-3c2b-4d63-a14a-8ac7c806e269") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7633), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7634), new Guid("19b37d4b-09a7-45c0-a5ba-7d65ab53f7ce") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7635), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7636), new Guid("827bf40c-1002-4d8b-8c3c-ea575441bcc5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7637), new Guid("8b6935fc-6035-4aa0-9080-0233a3388a2b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7645), new Guid("c4d07790-5c18-40f6-86d2-1902f718d39d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7647), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7647), new Guid("8886c5f3-6d15-4184-82f3-a50765849f5f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7649), new Guid("3558b02a-bccb-46d0-96f3-00685048fc52") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7650), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7651), new Guid("3b27d23f-a6d9-418a-b59c-fd12c8ec6fb4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7652), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7653), new Guid("12ba4c97-a26d-44df-8f6a-85ac894c7676") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7654), new Guid("20c53110-8e69-452a-ba8d-e2202e988aa3") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7656), new Guid("fc4dc1e2-0ab7-4f59-9f5c-b1d8abdb08f6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7657), new Guid("d7ac303a-c736-4052-9e7f-7f5db775b50b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7661), new Guid("494fd77a-4bd5-4ce8-8f94-044f4327a0f4") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7664), new Guid("46917bcd-0655-4bea-9f46-08e6fdc10f4d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7665), new Guid("9c692551-a66a-4870-873b-dbd6790e456b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7667), new Guid("2a64ac08-20ad-4c0d-9618-b92a8ae6a13e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7668), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7669), new Guid("f944ca33-fab0-4a1d-be20-b0bf561a0bb6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7676), new Guid("0c94d258-db4e-47bc-b133-c777713e0a78") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7677), new Guid("efc7cf56-3125-4e8a-b1dd-4c1f88398c72") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7679), new Guid("ef162c89-42ec-4cc8-ab35-c07ad9f29e81") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7682), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7682), new Guid("fa9f5095-74e0-4ed7-85fe-8fb5cc8ed0ba") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7684), new Guid("efd52da5-b62f-4832-bdf7-a46db0df9ce8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7686), new Guid("c13d0f94-432c-4d08-acf2-6e26e2e82d62") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7688), new Guid("f805d1f7-e982-4204-942a-ba9b02a1b24f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7690), new Guid("41128fff-6d39-41cb-bce5-4c67e1eb14ac") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7691), new Guid("cca2e120-7dfb-46a2-9d3f-55fc76f4c424") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7693), new Guid("289ca14d-2353-4966-846e-6555b39d1276") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7695), new Guid("e274f5f1-4877-40c3-8d90-0662d25297de") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7698), new Guid("60b1d347-f811-4d7e-a096-2bce28368a07") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7700), new Guid("99def0b2-f4c5-4ef8-b2d2-6c27150a39ee") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7707), new Guid("dab8644d-b8be-4871-bf0c-e7f1e2b1ae86") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7709), new Guid("7a37f2b2-ac40-46f1-a3c1-634705ed9460") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7711), new Guid("3d36aeeb-2115-4cbe-a6c8-c190b4d949f9") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7712), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7712), new Guid("ca192cfe-de5c-41f1-9727-5ffbd04ad04d") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7715), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7716), new Guid("d18eed71-20d1-4c92-b134-6edba201d122") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7718), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7718), new Guid("dafb7769-7b9c-4bc6-90f9-83955da0112e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7721), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7722), new Guid("09c654b8-9464-414f-84a5-f6806ef7ec36") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7723), new Guid("b986562d-c850-4713-911f-316c2e2978a8") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7726), new Guid("056f040d-b8a1-433a-ad35-d37071602ed1") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7727), new Guid("a69fcaab-aa57-419b-81be-fc975829860c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7729), new Guid("af86195c-4c70-4578-b615-b8b4b167d263") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7731), new Guid("b2b1eb23-f348-416d-b0d1-3761e2914e89") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7737), new Guid("0713470e-2e36-433f-858d-4f5ff536a854") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7739), new Guid("f054d4ed-7be5-4dbc-8ce4-cc0d1ad11f27") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7742), new Guid("81adb5bc-1e58-4037-9b37-9f4f651d046b") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7744), new Guid("58195b52-a5f5-4d9e-b803-c53e4f4a1815") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7746), new Guid("c064de78-60c0-4107-b825-b221de0d94af") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7748), new Guid("797c8edd-af23-4939-af39-f0d639a43726") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7750), new Guid("d2638c27-d532-4127-9def-5781651e82b6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7751), new Guid("c7f2f6b6-4506-4622-9435-d279ff26e730") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7753), new Guid("25367aaf-568f-43da-909e-f64b7c268742") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7755), new Guid("67e5fdf3-fe6e-44f4-b4a5-04e999320335") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7757), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7758), new Guid("af80d43a-b382-412a-a6bd-a54419bfe92f") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7760), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7761), new Guid("38587954-503b-46b9-9fe2-c2530352d692") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7762), new Guid("3d812982-9eb8-4c7a-b795-6beac1f2e7db") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7764), new Guid("3b8e0e20-9efa-4091-930d-0fb6c0b5df6c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7765), new Guid("071e11e6-4f8e-4ebe-ae55-1dca69fa3c63") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7767), new Guid("75a12820-6495-4a34-b58a-5e752d8f0259") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7769), new Guid("55a833d0-03fe-4f69-b9eb-77ebeafbbfe6") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7771), new Guid("e0085714-a613-4b94-a258-f70be067c07e") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7775), new Guid("be78acb1-5e15-4974-ac5b-484a8ee72c1c") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7776), new Guid("af4cfe19-c090-4f9a-a27e-132ec8332c59") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7778), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7778), new Guid("62a8723d-04cd-41f8-81cd-08756042a3b5") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7780), new Guid("1e72070e-8b96-4c1e-a6a9-b301a6ab2944") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "Questionnaire",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 6, 22, 7, 10, 31, 36, DateTimeKind.Utc).AddTicks(7782), new Guid("a5573b09-2aed-4d26-a6cc-d0bc9d6bd3ab") });

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
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9875), new Guid("f5242cd4-2477-41ef-8d85-395c3ebfc897") });

            migrationBuilder.UpdateData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 6, 22, 7, 10, 31, 29, DateTimeKind.Utc).AddTicks(9876), new Guid("5df828f4-7ad7-42d3-a859-4a7e2ae78678") });

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

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5742), new Guid("9fe9ba69-c936-4eb5-851a-b6cfc7a418ed") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5744), new Guid("a051a101-8a0a-427a-a567-bf7423c24023") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5747), new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5747), new Guid("31d82aac-1bf0-4ccb-aa35-2cd2ed2e5128") });

            migrationBuilder.UpdateData(
                schema: "Dcube",
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn", "RowId" },
                values: new object[] { new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5749), new DateTime(2025, 6, 22, 7, 10, 31, 39, DateTimeKind.Utc).AddTicks(5750), new Guid("e6048b94-3829-4efc-85f8-dc91ffda469e") });
        }
    }
}
