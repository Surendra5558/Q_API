using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedInformationTablesAndComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientInformation",
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
                    ClientTemplateInformationSectionId = table.Column<long>(type: "bigint", nullable: false),
                    InformationId = table.Column<long>(type: "bigint", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTemplateAddSectionResponse",
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
                    InformationSectionId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplateAddSectionResponse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information",
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
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RenderTypeId = table.Column<int>(type: "int", nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    InformationSectionId = table.Column<long>(type: "bigint", nullable: false),
                    Options = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationSection",
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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationSection", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Information",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "InformationSectionId", "IsActive", "IsDeleted", "IsMandatory", "ModifiedBy", "ModifiedOn", "Options", "OrderBy", "RenderTypeId", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(6713), "How many total endpoints are currently in use (workstations, laptops, servers, mobile devices)?", 1L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(6715), null, 1, 8, new Guid("f6e31d4c-3507-442e-9e82-ec66a8dcbcc7") },
                    { 2L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7202), "How many physical or virtual office locations do you operate from?", 1L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7202), null, 2, 8, new Guid("09cd82ed-8cc3-4160-a924-dd67cb6f74fe") },
                    { 3L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7205), "What is your current technology stack (OS, application platforms, infrastructure tools)?", 1L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7206), null, 3, 8, new Guid("230b3a49-be51-4f28-9ea5-192e0310f8aa") },
                    { 4L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7214), "Are there any OT (Operational Technology) systems or IoT devices in use?", 1L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7215), null, 4, 8, new Guid("49e832da-840a-46e3-a07d-0ba2d950bee6") },
                    { 5L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7216), "What Endpoint Detection and Response (EDR) solution(s) are currently deployed?", 2L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7216), null, 1, 8, new Guid("fce7c8b8-3432-4fe6-b0c4-fb044d2b2693") },
                    { 6L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7219), "Are antivirus or anti-malware solutions deployed on all endpoints?", 2L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7219), null, 2, 8, new Guid("fb9e4360-6713-4aa7-86eb-7a4bfca962e4") },
                    { 7L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7221), "Do you use any device management tools like MDM (Mobile Device Management)?", 2L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7221), null, 3, 8, new Guid("040d89ea-ec3f-4629-850f-d0f2ba165cd4") },
                    { 8L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7238), "Are you using any public, private, or hybrid cloud infrastructure? Please specify (e.g., AWS, Azure, GCP).", 3L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7238), null, 1, 8, new Guid("80c35832-d75e-4b5e-bf1e-6ecb565c323b") },
                    { 9L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7240), "Are workloads or data hosted in the cloud? If yes, what types (VMs, containers, SaaS, etc.)?", 3L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7241), null, 2, 8, new Guid("5fbabb8d-3f54-4618-bc2d-248bb8e67e28") },
                    { 10L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7243), "Are you using Microsoft 365 (O365)? If yes, which services (Exchange Online, Teams, SharePoint, etc.)?", 4L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7243), null, 1, 8, new Guid("59fe0548-1c14-4ea2-96fc-e4eca5dce8ad") },
                    { 11L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7246), "Are you using Google Workspace (G Suite)? If yes, which services (Gmail, Drive, Meet, etc.)?", 4L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7246), null, 2, 8, new Guid("52bdb76f-95d2-4a6c-8b8d-34c73e97f076") },
                    { 12L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7248), "Do you use any third-party email platforms or services (e.g., Zimbra, ProtonMail)?", 4L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7248), null, 3, 8, new Guid("1a8c36b8-7068-44c5-9a0c-ec7ac4a96e76") },
                    { 13L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7249), "Is there any secure email gateway or DLP (Data Loss Prevention) solution in place?", 4L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7249), null, 4, 8, new Guid("6358a784-b537-4fe7-b444-eac503195e39") },
                    { 14L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7252), "How is business-critical data stored and retained (on-premises, cloud, hybrid)?", 5L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7252), null, 1, 8, new Guid("11f05205-7a60-4279-b87b-14e0f35d0e6e") },
                    { 15L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7260), "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?", 5L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7260), null, 2, 8, new Guid("512eea75-bf3e-4bc9-bfa9-eb5eafc8f70d") },
                    { 16L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7264), "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?", 5L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7264), null, 3, 8, new Guid("28876215-76eb-4328-a456-a3687ae3e037") },
                    { 17L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7266), "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?", 5L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7266), null, 4, 8, new Guid("ec74ae4d-8622-4f06-ad6c-b7af52b2526d") },
                    { 18L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7269), "Do you currently utilize a SIEM solution for ingesting and correlating security data?", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7270), null, 1, 8, new Guid("71495773-7d69-42ac-973e-fde21fd6ac00") },
                    { 19L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7271), "Is your SIEM deployment on-premises or cloud-based?", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7271), null, 2, 8, new Guid("7b7b0389-5551-4a62-95cd-a46fec5d9c7e") },
                    { 20L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7274), "How many distinct data sources are currently configured to forward logs to the SIEM?", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7274), null, 3, 8, new Guid("03f8388f-35c7-4d41-8ffe-85d00b56582b") },
                    { 21L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7282), "Average volume of data ingested per day", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7282), null, 4, 1, new Guid("e0c293c2-0b66-4eba-8772-fec69857baae") },
                    { 22L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7285), "Total data stored as of today", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7285), null, 5, 1, new Guid("0b07a7db-faaf-47ad-9895-bbc88b7d025c") },
                    { 23L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7287), "Log retention period configured", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7288), null, 6, 1, new Guid("e2898c79-6732-41db-9925-2b8de7863a6d") },
                    { 24L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7291), "How are correlation rules and alerting mechanisms designed and managed?", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7291), null, 7, 8, new Guid("8f337cfa-6971-481c-9aa1-0032c409138e") },
                    { 25L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7293), "Integration with external tools (e.g., Threat Intelligence platforms, CRM systems, etc.)", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7293), null, 8, 8, new Guid("5533f8a0-53fd-45f7-94a5-2cc50ecded4f") },
                    { 26L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7295), "Orchestration with security infrastructure (e.g., firewalls, web/email gateways, cloud platforms, etc.)", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7295), null, 9, 8, new Guid("ea8d1328-e4c5-4369-ae91-1d10db09cdfd") },
                    { 27L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7296), "Automated response capabilities (e.g., automatic blocking, IOC reputation lookups, etc.)", 6L, true, false, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 421, DateTimeKind.Utc).AddTicks(7297), null, 10, 8, new Guid("2e721d98-9c11-4b8e-8a5d-0aff2ef1a17b") }
                });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "InformationSection",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8187), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8188), "Environment Overview", 1, new Guid("f2a540a2-2569-43c9-8671-c05eaa1f4e08") },
                    { 2L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8476), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8476), "Endpoint & Device Security", 2, new Guid("db7620f1-0b37-412f-8966-22c6c3091d23") },
                    { 3L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8478), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8479), "Cloud Infrastructure", 3, new Guid("199e1746-cbb3-4820-9d4f-13a8c212c925") },
                    { 4L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8481), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8481), "Email & Collaboration Tools", 4, new Guid("ff20fb86-4f41-4bad-9c35-4f04812d61db") },
                    { 5L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8482), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8482), "Data Protection & Governance", 5, new Guid("f5b8df8f-8824-41ef-ba47-13c397cb43ae") },
                    { 6L, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8484), null, true, false, 1L, new DateTime(2025, 7, 5, 15, 4, 2, 423, DateTimeKind.Utc).AddTicks(8485), "Security Log Ingestion & Storage", 6, new Guid("472e4a4e-c8df-4611-bc9b-af059bd231ae") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientInformation",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientTemplateAddSectionResponse",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "Information",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "InformationSection",
                schema: "Dcube");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "Dcube",
                table: "ClientQuestionnaireResponse");

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
    }
}
