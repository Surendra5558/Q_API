using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCube.Questionnaire.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dcube");

            migrationBuilder.EnsureSchema(
                name: "MetaData");

            migrationBuilder.CreateTable(
                name: "Client",
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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientExtension",
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
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    LegalName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumberOfLocations = table.Column<int>(type: "int", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    NumberOfSuppliers = table.Column<int>(type: "int", nullable: false),
                    NumberOfExternalPartners = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientQuestionnaireResponse",
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
                    ClientTemplateSectionResponseId = table.Column<long>(type: "bigint", nullable: false),
                    QuestionnaireId = table.Column<long>(type: "bigint", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientQuestionnaireResponse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTemplate",
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
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTemplateSectionResponse",
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
                    TemplateSectionId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemplateSectionResponse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaire",
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
                    TemplateSectionId = table.Column<long>(type: "bigint", nullable: false),
                    Options = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireStatusType",
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
                    table.PrimaryKey("PK_QuestionnaireStatusType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RenderType",
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
                    table.PrimaryKey("PK_RenderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleType",
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
                    table.PrimaryKey("PK_RoleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Template",
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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateSection",
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
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ParentSectionId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
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
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Client",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "RowId" },
                values: new object[] { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 239, DateTimeKind.Utc).AddTicks(7566), true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 239, DateTimeKind.Utc).AddTicks(7571), "Dcube DataSciences", new Guid("72095872-1cb5-4204-a43d-0de9698431d6") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Questionnaire",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "IsMandatory", "ModifiedBy", "ModifiedOn", "Options", "OrderBy", "RenderTypeId", "RowId", "TemplateSectionId" },
                values: new object[,]
                {
                    { 1L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(6807), "ID.AM-1: Physical devices and systems within the organization are inventoried", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(6810), "[YES,NO,NA]", 1, 7, new Guid("ebc30155-f984-445c-8667-a5af97d94f57"), 2L },
                    { 2L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8200), "ID.AM-2: Software platforms and applications within the organization are inventoried", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8201), "[YES,NO,NA]", 2, 7, new Guid("156b116b-24ac-4013-b7ed-ca5da5eeb1e4"), 2L },
                    { 3L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8206), "ID.AM-3: Organizational communication and data flows are mapped", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8206), "[YES,NO,NA]", 3, 7, new Guid("a02d8a80-fe93-4b31-9891-122db333ca45"), 2L },
                    { 4L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8209), "ID.AM-4: External information systems are catalogued", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8209), "[YES,NO,NA]", 4, 7, new Guid("7b01e7d1-a2d4-46cc-94b5-55ec1d6a6d9c"), 2L },
                    { 5L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8212), "ID.AM-5: Resources (e.g., hardware, software, data) are prioritized based on their classification, criticality, and business value", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8213), "[YES,NO,NA]", 5, 7, new Guid("bfbb0ed7-6e63-499c-8772-ad1adb7eb4e5"), 2L },
                    { 6L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8215), "ID.AM-6: Cybersecurity roles and responsibilities for the entire workforce and third-party stakeholders (e.g., suppliers, customers, partners) are established", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8216), "[YES,NO,NA]", 6, 7, new Guid("04c21e20-3d7d-4272-bb9a-493c38a4094b"), 2L },
                    { 7L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8227), "ID.BE-1: The organization’s role in the supply chain is identified and communicated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8228), "[YES,NO,NA]", 1, 7, new Guid("5714bed2-07be-4d7d-a613-1f55ebf93aee"), 3L },
                    { 8L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8241), "ID.BE-2: The organization’s place in critical infrastructure and its industry sector is identified", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8242), "[YES,NO,NA]", 2, 7, new Guid("e088f67d-80d2-4fa5-82ee-78c0228d5f38"), 3L },
                    { 9L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8244), "ID.BE-3: Priorities for organizational mission, objectives, and activities are established and communicated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8245), "[YES,NO,NA]", 3, 7, new Guid("e1f21a41-074c-4859-8b68-f3c94bc86741"), 3L },
                    { 10L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8283), "ID.BE-4: Dependencies and critical functions for delivery of critical services are established", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8284), "[YES,NO,NA]", 4, 7, new Guid("8f5b3af3-0c3f-4bba-b521-0f38daf31a77"), 3L },
                    { 11L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8286), "ID.BE-5: Resilience requirements to support delivery of critical services are established", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8287), "[YES,NO,NA]", 5, 7, new Guid("4485340c-eaa2-4509-b32f-499165587a46"), 3L },
                    { 12L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8289), "ID.GV-1: Organizational cybersecurity policy is established and communicated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8289), "[YES,NO,NA]", 1, 7, new Guid("e2044009-3d07-402a-a348-81027652acc1"), 4L },
                    { 13L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8292), "ID.GV-2: Cybersecurity roles and responsibilities are coordinated and aligned with internal roles and external partners", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8292), "[YES,NO,NA]", 2, 7, new Guid("5fff0047-c840-42e3-b634-38268933837e"), 4L },
                    { 14L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8295), "ID.GV-3: Legal and regulatory requirements regarding cybersecurity, including privacy and civil liberties obligations, are understood and managed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8295), "[YES,NO,NA]", 3, 7, new Guid("5cc0ec30-fd2f-4e27-af18-663b887e719b"), 4L },
                    { 15L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8301), "ID.GV-4: Governance and risk management processes address cybersecurity risks", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8301), "[YES,NO,NA]", 4, 7, new Guid("6f924b84-c08c-4941-a6f2-3f79f17d05f9"), 4L },
                    { 16L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8304), "ID.RA-1: Asset vulnerabilities are identified and documented", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8304), "[YES,NO,NA]", 1, 7, new Guid("2ba71881-05f9-4a29-9bd7-cf7981cd80b4"), 5L },
                    { 17L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8307), "ID.RA-2: Threats, both internal and external, are identified and documented", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8307), "[YES,NO,NA]", 2, 7, new Guid("44432ef7-f5fd-4a9d-accf-5d13a7370e9c"), 5L },
                    { 18L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8310), "ID.RA-3: Potential business impacts and likelihoods are identified", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8310), "[YES,NO,NA]", 3, 7, new Guid("fb0560f2-46e4-4e05-a362-ff98285d5142"), 5L },
                    { 19L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8312), "ID.RA-4: Risk responses are identified and prioritized", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8313), "[YES,NO,NA]", 4, 7, new Guid("3f84667f-c664-44a4-9318-2810f9438425"), 5L },
                    { 20L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8315), "ID.RA-5: Risk responses are coordinated with internal and external stakeholders", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8316), "[YES,NO,NA]", 5, 7, new Guid("201fe7d2-1855-4c30-8210-f7d0d68370bc"), 5L },
                    { 21L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8318), "ID.RA-6: Risk responses are documented and approved by management", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8319), "[YES,NO,NA]", 6, 7, new Guid("19ee793c-c2e9-417f-b853-1a5f7ea58e3c"), 5L },
                    { 22L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8321), "ID.RM-1: Risk management processes are established, managed, and agreed to by organizational stakeholders", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8321), "[YES,NO,NA]", 6, 7, new Guid("bb7d9d02-0786-4717-a63c-724dabdee886"), 6L },
                    { 23L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8326), "ID.RM-2: Organizational risk tolerance is determined and clearly expressed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8326), "[YES,NO,NA]", 1, 7, new Guid("b31db060-261a-4883-a2ef-826da0e48620"), 6L },
                    { 24L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8329), "ID.RM-3: The organization’s determination of risk tolerance is informed by its role in critical infrastructure and sector risk management practices", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8329), "[YES,NO,NA]", 2, 7, new Guid("e48d60bd-0552-4b37-a6be-2253106710cc"), 6L },
                    { 25L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8331), "ID.SC-1: Cyber supply chain risk management processes are identified, established, assessed, managed, and agreed to by organizational stakeholders", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8332), "[YES,NO,NA]", 1, 7, new Guid("42e51698-48a0-4381-b959-299fee4b9599"), 7L },
                    { 26L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8334), "ID.SC-2: Cyber supply chain risks are identified and assessed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8334), "[YES,NO,NA]", 2, 7, new Guid("8552042d-51b4-4858-88e5-d504a03e815a"), 7L },
                    { 27L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8337), "ID.SC-3: Contracts with suppliers and third-party partners include cybersecurity requirements", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8337), "[YES,NO,NA]", 3, 7, new Guid("b9e22e6b-30cc-40a1-99db-9a19cb4d41c7"), 7L },
                    { 28L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8356), "ID.SC-4: Suppliers and third-party partners are monitored to ensure compliance with cybersecurity requirements", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8356), "[YES,NO,NA]", 4, 7, new Guid("20780009-c451-4c82-9559-be61e2d31007"), 7L },
                    { 29L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8360), "ID.SC-5: Response and recovery planning and testing are conducted with suppliers and third-party partners", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8360), "[YES,NO,NA]", 5, 7, new Guid("20dd2ccd-b94c-46ee-96de-5fcac8ed9ba3"), 7L },
                    { 30L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8363), "PR.AC-1: Identities and credentials are issued, managed, verified, revoked, and audited for authorized devices, users and processes", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8363), "[YES,NO,NA]", 1, 7, new Guid("2409e4c4-ef10-4a3a-8a51-1fe6e015b8df"), 9L },
                    { 31L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8369), "PR.AC-2: Physical access to assets is managed and protected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8370), "[YES,NO,NA]", 2, 7, new Guid("fdf8cbab-2c76-461c-b0cb-26c01bb52aab"), 9L },
                    { 32L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8373), "PR.AC-3: Remote access is managed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8373), "[YES,NO,NA]", 3, 7, new Guid("ea90ff85-e5a1-4855-bf32-9ed01f96fa89"), 9L },
                    { 33L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8376), "PR.AC-4: Access permissions are managed, incorporating the principles of least privilege and separation of duties", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8376), "[YES,NO,NA]", 4, 7, new Guid("41876e09-65aa-4110-a8a7-d6d968d29a9b"), 9L },
                    { 34L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8379), "PR.AC-5: Network integrity is protected (e.g., network segregation, network segmentation)", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8379), "[YES,NO,NA]", 5, 7, new Guid("2fa4e110-b732-4f3c-aaf6-c627bc2efc95"), 9L },
                    { 35L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8382), "PR.AC-6: Identities are proofed and bound to credentials and asserted in interactions", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8383), "[YES,NO,NA]", 6, 7, new Guid("69e0473b-d548-47fc-a3f0-0a330d2dc2c5"), 9L },
                    { 36L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8385), "PR.AC-7: Users, devices, and other assets are authenticated (e.g., single-factor, multi-factor) commensurate with the risk of the transaction (e.g., individuals’ security and privacy risks and other organizational risks)", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8386), "[YES,NO,NA]", 7, 7, new Guid("1dc01a94-cc50-4d2a-b9a3-c51239d762cb"), 9L },
                    { 37L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8388), "PR.AT-1: All users are informed and trained", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8389), "[YES,NO,NA]", 1, 7, new Guid("a84b1077-e050-4c19-b581-63137bd1d7c5"), 10L },
                    { 38L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8391), "PR.AT-2: Privileged users understand their roles and responsibilities", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8392), "[YES,NO,NA]", 2, 7, new Guid("5216fef8-183e-4de4-9ccd-5ba665d5615e"), 10L },
                    { 39L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8473), "PR.AT-3: Third-party stakeholders (e.g., suppliers, customers, partners) understand their roles and responsibilities", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8473), "[YES,NO,NA]", 3, 7, new Guid("1dacd1d7-5ad0-4101-8f30-2389868f69e8"), 10L },
                    { 40L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8476), "PR.AT-4: Senior executives understand their roles and responsibilities", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8476), "[YES,NO,NA]", 4, 7, new Guid("4323b273-69b4-4866-89a9-fee18bf30ade"), 10L },
                    { 41L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8479), "PR.AT-5: Physical and cybersecurity personnel understand their roles and responsibilities", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8479), "[YES,NO,NA]", 5, 7, new Guid("05893633-f181-4e4b-9310-f4a07e6e38ba"), 10L },
                    { 42L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8482), "PR.DS-1: Data-at-rest is protected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8482), "[YES,NO,NA]", 1, 7, new Guid("d256f494-f1f2-41aa-9cb5-3872d0fb1abc"), 11L },
                    { 43L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8485), "PR.DS-2: Data-in-transit is protected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8485), "[YES,NO,NA]", 2, 7, new Guid("c7a66d33-1a85-418b-a9b6-59a0e28caf7e"), 11L },
                    { 44L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8488), "PR.DS-3: Assets are formally managed throughout removal, transfers, and disposition", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8488), "[YES,NO,NA]", 3, 7, new Guid("1c00bcc7-57d2-427d-85f5-6158b63702ce"), 11L },
                    { 45L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8490), "PR.DS-4: Adequate capacity to ensure availability is maintained", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8491), "[YES,NO,NA]", 4, 7, new Guid("15346d34-d5a4-42fa-b37e-dc7e4a090104"), 11L },
                    { 46L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8493), "PR.DS-5: Protections against data leaks are implemented", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8493), "[YES,NO,NA]", 5, 7, new Guid("c8c9f822-fc7b-40c2-b1e6-01984cc6aa83"), 11L },
                    { 47L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8519), "PR.DS-6: Integrity checking mechanisms are used to verify software, firmware, and information integrity", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8520), "[YES,NO,NA]", 6, 7, new Guid("49c5bdb6-c30d-43d4-a82e-86cea96481c3"), 11L },
                    { 48L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8522), "PR.DS-7: The development and testing environment(s) are separate from the production environment", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8522), "[YES,NO,NA]", 7, 7, new Guid("5b6bb6bf-6256-4b94-9dc6-387fa04e819d"), 11L },
                    { 49L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8524), "PR.DS-8: Integrity checking mechanisms are used to verify hardware integrity", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8525), "[YES,NO,NA]", 8, 7, new Guid("41834b0c-b15c-4611-8f08-db86439cadc6"), 11L },
                    { 50L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8527), "PR.IP-1: A baseline configuration of information technology/industrial control systems is created and maintained incorporating security principles (e.g., least functionality)", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8527), "[YES,NO,NA]", 1, 7, new Guid("807facd3-417b-417f-8f1b-de9748ee28c8"), 12L },
                    { 51L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8529), "PR.IP-2: A System Development Life Cycle to manage systems is implemented", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8529), "[YES,NO,NA]", 2, 7, new Guid("3f29e1ce-5953-4a0e-930a-39b22ecccb7a"), 12L },
                    { 52L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8531), "PR.IP-3: Configuration change control processes are in place", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8531), "[YES,NO,NA]", 3, 7, new Guid("2c48f98c-27cc-4307-8a4e-392dd5088047"), 12L },
                    { 53L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8533), "PR.IP-4: Backups of information are conducted, maintained, and tested periodically", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8534), "[YES,NO,NA]", 4, 7, new Guid("4bd2dcc9-0d5f-42ad-a621-b7da8e166da9"), 12L },
                    { 54L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8536), "PR.IP-5: Policy and regulations regarding the physical operating environment for organizational assets are met", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8536), "[YES,NO,NA]", 5, 7, new Guid("9cca69b1-cf0a-45ae-ba8f-9c16340ffe75"), 12L },
                    { 55L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8541), "PR.IP-6: Data is destroyed according to policy", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8541), "[YES,NO,NA]", 6, 7, new Guid("03df0d07-9a94-4e71-8ed1-013a020c9d37"), 12L },
                    { 56L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8543), "PR.IP-7: Protection processes are improved", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8543), "[YES,NO,NA]", 7, 7, new Guid("522e08bd-43b5-453b-8472-89270f79df11"), 12L },
                    { 57L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8545), "PR.IP-8: Effectiveness of protection technologies is shared", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8546), "[YES,NO,NA]", 8, 7, new Guid("1d6f89c3-ed52-4dae-b622-fd15a019740f"), 12L },
                    { 58L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8548), "PR.IP-9: Response and recovery plans are in place and managed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8548), "[YES,NO,NA]", 9, 7, new Guid("617693c9-a78e-4757-ace5-c9d1aae3b182"), 12L },
                    { 59L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8550), "PR.IP-10: Response and recovery plans are tested", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8550), "[YES,NO,NA]", 10, 7, new Guid("4256a1b7-4aad-4084-ac81-f10e634feba5"), 12L },
                    { 60L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8552), "PR.IP-11: Cybersecurity is included in human resources practices (e.g., deprovisioning, personnel screening)", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8552), "[YES,NO,NA]", 11, 7, new Guid("ef2d4e0b-a5a8-4d7b-8e71-043945ab401a"), 12L },
                    { 61L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8554), "PR.IP-12: A vulnerability management plan is developed and implemented", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8555), "[YES,NO,NA]", 12, 7, new Guid("bd978096-6918-41c9-82f9-6e839ce05554"), 12L },
                    { 62L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8557), "PR.MA-1: Maintenance and repair of organizational assets are performed and logged, with approved and controlled tools", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8557), "[YES,NO,NA]", 1, 7, new Guid("a00cc19b-f96d-4ef8-828e-812504a00b7a"), 13L },
                    { 63L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8561), "PR.MA-2: Remote maintenance of organizational assets is approved, logged, and performed in a manner that prevents unauthorized access", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8561), "[YES,NO,NA]", 2, 7, new Guid("32de123c-5288-4287-b2c8-f7d7815e3e84"), 13L },
                    { 64L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8563), "PR.PT-1: Audit/log records are determined, documented, implemented, and reviewed in accordance with policy", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8563), "[YES,NO,NA]", 1, 7, new Guid("c6630b2b-827d-4cbb-801c-58b79347e054"), 14L },
                    { 65L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8578), "PR.PT-2: Removable media is protected and its use restricted according to policy", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8579), "[YES,NO,NA]", 2, 7, new Guid("af4e278e-8add-4577-99af-92ecf928708e"), 14L },
                    { 66L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8581), "PR.PT-3: Access to systems and assets is controlled, incorporating the principle of least functionality", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8581), "[YES,NO,NA]", 3, 7, new Guid("a094167c-29e4-47ce-af36-e1234f5f5ff8"), 14L },
                    { 67L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8583), "PR.PT-4: Communications and control networks are protected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8584), "[YES,NO,NA]", 4, 7, new Guid("9a5ef5d3-3881-484a-9ff4-3a6a0e862fb6"), 14L },
                    { 68L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8586), "PR.PT-5: Mechanisms (e.g., failsafe, load balancing, hot swap) are implemented to achieve resilience requirements in normal and adverse situations", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8586), "[YES,NO,NA]", 5, 7, new Guid("8ebce80b-b00d-4261-b823-24b652908d86"), 14L },
                    { 69L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8588), "DE.AE-1: A baseline of network operations and expected data flows for users and systems is established and managed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8589), "[YES,NO,NA]", 1, 7, new Guid("d9fcab1e-a06b-4270-936b-92a186a85a56"), 16L },
                    { 70L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8591), "DE.AE-2: Detected events are analyzed to understand attack targets and methods", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8591), "[YES,NO,NA]", 2, 7, new Guid("f9c0252a-b32f-4a21-b682-efd2caea60ee"), 16L },
                    { 71L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8595), "DE.AE-3: Event data are collected and correlated from multiple sources and sensors", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8595), "[YES,NO,NA]", 3, 7, new Guid("2ed9c789-5f01-491a-ab4c-fcd8e586f828"), 16L },
                    { 72L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8597), "DE.AE-4: Impact of events is determined", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8598), "[YES,NO,NA]", 4, 7, new Guid("3ac2f607-83db-4f2c-8963-6ae80f07f367"), 16L },
                    { 73L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8600), "DE.AE-5: Incident alert thresholds are established", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8600), "[YES,NO,NA]", 5, 7, new Guid("de30c320-66b0-4512-bfa0-90be4e592fc6"), 16L },
                    { 74L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8602), "DE.CM-1: The network is monitored to detect potential cybersecurity events", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8602), "[YES,NO,NA]", 1, 7, new Guid("dc74e161-afa9-4189-9044-55b088fd33c9"), 17L },
                    { 75L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8604), "DE.CM-2: The physical environment is monitored to detect potential cybersecurity events", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8604), "[YES,NO,NA]", 2, 7, new Guid("b1041309-af27-4f9c-8367-7000866dd061"), 17L },
                    { 76L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8606), "DE.CM-3: Personnel activity is monitored to detect potential cybersecurity events", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8607), "[YES,NO,NA]", 3, 7, new Guid("864935c5-21d7-4cef-9890-8c42bbb2ce18"), 17L },
                    { 77L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8609), "DE.CM-4: Malicious code is detected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8609), "[YES,NO,NA]", 4, 7, new Guid("b69fcf1f-967d-4f33-a70a-c3db7c30fe93"), 17L },
                    { 78L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8611), "DE.CM-5: Unauthorized mobile code is detected", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8611), "[YES,NO,NA]", 5, 7, new Guid("f075864a-c254-4cbb-b8d1-bae642cbc455"), 17L },
                    { 79L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8615), "DE.CM-6: External service provider activity is monitored to detect potential cybersecurity events", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8616), "[YES,NO,NA]", 6, 7, new Guid("d51df018-91a7-4ad6-bdd2-eb8c21c4b76c"), 17L },
                    { 80L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8618), "DE.CM-7: Monitoring for unauthorized personnel, connections, devices, and software is performed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8618), "[YES,NO,NA]", 7, 7, new Guid("99f265c1-f9b6-4da2-a861-1ee4fe0fb572"), 17L },
                    { 81L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8620), "DE.CM-8: Vulnerability scans are performed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8620), "[YES,NO,NA]", 8, 7, new Guid("8648bfa7-7d19-4b26-8104-b1f92d75396c"), 17L },
                    { 82L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8622), "DE.DP-1: Roles and responsibilities for detection are well defined to ensure accountability", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8622), "[YES,NO,NA]", 1, 7, new Guid("4c2876f7-21c3-4ae1-b4fb-02814011d140"), 18L },
                    { 83L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8637), "DE.DP-2: Detection activities comply with all applicable requirements", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8638), "[YES,NO,NA]", 2, 7, new Guid("cabbcd97-b666-465c-b03c-b77162e7f2e4"), 18L },
                    { 84L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8640), "DE.DP-3: Detection processes are tested", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8640), "[YES,NO,NA]", 3, 7, new Guid("d61cb65a-0fa1-4433-93cb-6b175adbaf54"), 18L },
                    { 85L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8642), "DE.DP-4: Event detection information is communicated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8643), "[YES,NO,NA]", 4, 7, new Guid("a86f4b3a-e7bd-4f9c-9fea-26a518fe0514"), 18L },
                    { 86L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8645), "DE.DP-5: Detection processes are continuously improved", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8645), "[YES,NO,NA]", 5, 7, new Guid("d333a87a-d61f-4867-b569-e0c29bc9d168"), 18L },
                    { 87L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8649), "RS.RP-1: Response plan is executed during or after an incident", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8649), "[YES,NO,NA]", 1, 7, new Guid("0159a6e0-79f4-44fb-97f6-0b6aacc57b5e"), 20L },
                    { 88L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8651), "RS.CO-1: Personnel know their roles and order of operations when a response is needed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8652), "[YES,NO,NA]", 1, 7, new Guid("25d5b908-06ad-4ea8-b4e5-59ac91e86617"), 21L },
                    { 89L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8654), "RS.CO-2: Incidents are reported consistent with established criteria", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8654), "[YES,NO,NA]", 2, 7, new Guid("c52ab3e3-a45e-4ff1-9963-acc86cf80f6e"), 21L },
                    { 90L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8656), "RS.CO-3: Information is shared consistent with response plans", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8656), "[YES,NO,NA]", 3, 7, new Guid("134b9698-3d93-4c34-aeb6-c7c4308b10ee"), 21L },
                    { 91L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8658), "RS.CO-4: Coordination with stakeholders occurs consistent with response plans", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8658), "[YES,NO,NA]", 4, 7, new Guid("81f4d6f6-9219-45e4-ac59-d5d50283b637"), 21L },
                    { 92L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8660), "RS.CO-5: Voluntary information sharing occurs with external stakeholders to achieve broader cybersecurity situational awareness", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8661), "[YES,NO,NA]", 5, 7, new Guid("e5f5f9e8-5bf7-4401-b878-07ff057e25a6"), 21L },
                    { 93L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8663), "RS.AN-1: Notifications from detection systems are investigated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8663), "[YES,NO,NA]", 1, 7, new Guid("e763a7b8-bad8-450b-b470-5c0cc4278755"), 22L },
                    { 94L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8665), "RS.AN-2: The impact of the incident is understood", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8665), "[YES,NO,NA]", 2, 7, new Guid("a07fcb6b-6d8a-4c1e-badf-b66cbb96b927"), 22L },
                    { 95L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8669), "RS.AN-3: Forensics are performed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8670), "[YES,NO,NA]", 3, 7, new Guid("3ec172a3-9844-4453-b7b0-0c0e0bd4e567"), 22L },
                    { 96L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8672), "RS.AN-4: Incidents are categorized consistent with response plans", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8672), "[YES,NO,NA]", 4, 7, new Guid("ee2d25bb-d1eb-4e3a-b29e-e83df13e08f5"), 22L },
                    { 97L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8674), "RS.AN-5: Processes are established to receive, analyze and respond to vulnerabilities disclosed to the organization from internal and external sources (e.g. internal testing, security bulletins, or security researchers)", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8674), "[YES,NO,NA]", 5, 7, new Guid("24f9c6a5-0288-4bc7-bb32-208b151e8f25"), 22L },
                    { 98L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8676), "RS.MI-1: Incidents are contained", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8677), "[YES,NO,NA]", 1, 7, new Guid("6d390707-1550-47f1-af57-84ef4964e339"), 23L },
                    { 99L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8678), "RS.MI-2: Incidents are mitigated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8679), "[YES,NO,NA]", 2, 7, new Guid("0279ccce-1546-4879-9c98-c750e7a0da7a"), 23L },
                    { 100L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8681), "RS.MI-3: Newly identified vulnerabilities are mitigated or documented as accepted risks", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8681), "[YES,NO,NA]", 3, 7, new Guid("2b96425e-46d7-412a-9549-b71272b0b980"), 23L },
                    { 101L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8683), "RS.IM-1: Response plans incorporate lessons learned", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8683), "[YES,NO,NA]", 4, 7, new Guid("83e9f4b5-5a39-44ab-a6cf-5a363e6bd027"), 24L },
                    { 102L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8685), "RS.IM-2: Response strategies are updated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8685), "[YES,NO,NA]", 5, 7, new Guid("c1526cb0-9420-4e10-81bc-7148713e464b"), 24L },
                    { 103L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8689), "RC.RP-1: Recovery plan is executed during or after a cybersecurity incident", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8690), "[YES,NO,NA]", 1, 7, new Guid("cd5c9c7d-5a9c-4af3-b28e-38ae1d8e04ed"), 26L },
                    { 104L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8692), "RC.IM-1: Recovery plans incorporate lessons learned into future activities", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8692), "[YES,NO,NA]", 1, 7, new Guid("610b846d-e8ee-48a7-abde-d1d90a340964"), 27L },
                    { 105L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8694), "RC.IM-2: Recovery strategies are updated", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8694), "[YES,NO,NA]", 2, 7, new Guid("64a133f6-6e23-4412-ae89-3fa85c8af4c9"), 27L },
                    { 106L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8696), "RC.CO-1: Public relations are managed", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8696), "[YES,NO,NA]", 1, 7, new Guid("e6f928d5-c4f9-4a94-ace8-3402400461c2"), 28L },
                    { 107L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8698), "RC.CO-2: Reputation is repaired after an incident", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8699), "[YES,NO,NA]", 2, 7, new Guid("f4477962-5e1d-458a-ab4c-22834afddaab"), 28L },
                    { 108L, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8735), "RC.CO-3: Recovery activities are communicated to internal and external stakeholders as well as executive and management teams", true, false, true, 0L, new DateTime(2025, 6, 7, 15, 31, 1, 254, DateTimeKind.Utc).AddTicks(8735), "[YES,NO,NA]", 3, 7, new Guid("66f47bb2-98c4-4eb2-8e7e-04b604366d17"), 28L }
                });

            migrationBuilder.InsertData(
                schema: "MetaData",
                table: "QuestionnaireStatusType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(1572), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(1574), "Not Initiated", 1, new Guid("d03a52cd-e949-4661-91c7-8ba0cf2fd201") },
                    { 2L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2109), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2110), "Draft", 2, new Guid("49142602-289d-4994-9fb0-2157f10fce0e") },
                    { 3L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2113), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 245, DateTimeKind.Utc).AddTicks(2113), "Published", 3, new Guid("a767399b-3da1-4054-acda-0184516af1bf") }
                });

            migrationBuilder.InsertData(
                schema: "MetaData",
                table: "RenderType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2877), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2878), "TextBox", 1, new Guid("85f38460-3685-4e66-8b12-894cc599a7d8") },
                    { 2L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2882), null, false, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(2883), "Number", 2, new Guid("da866054-9588-4a54-91e9-f63c140472ee") },
                    { 3L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3198), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3198), "DropDown", 3, new Guid("2ec95c3f-eb9f-4278-b650-144be87f7657") },
                    { 4L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3217), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3217), "MultiSelect", 4, new Guid("75966d74-9338-486b-9362-65c8e04a2c24") },
                    { 5L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3220), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3220), "DateTimePicker", 5, new Guid("367c9502-9776-4844-8586-1eded15d6f54") },
                    { 6L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3222), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3222), "CheckBox", 6, new Guid("6ed2cc56-a64d-4712-91c8-ab33db012794") },
                    { 7L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3224), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3225), "RadioButton", 7, new Guid("72645f51-61ba-49f1-a2d4-f8ed3b54f7bf") },
                    { 8L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3227), null, false, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3227), "TextArea", 8, new Guid("dc0d1000-c855-4681-8ee0-c881d1b6d173") },
                    { 9L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3230), null, false, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3230), "RichTextEditor", 9, new Guid("4736df78-8d55-479b-a2cb-2f8829ca27dd") },
                    { 10L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3232), null, false, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3232), "AutoSearch", 10, new Guid("329865a1-ebfd-408e-9a3f-6504e0ec9080") },
                    { 11L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3235), null, false, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 246, DateTimeKind.Utc).AddTicks(3235), "FileUpload", 10, new Guid("cb38403c-7692-4763-b0db-c35585e455e0") }
                });

            migrationBuilder.InsertData(
                schema: "MetaData",
                table: "RoleType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "RowId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(719), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(720), "Admin", 1, new Guid("8ff92cf5-2ca2-4508-a1b9-514448746b4c") },
                    { 2L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(725), null, true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 247, DateTimeKind.Utc).AddTicks(725), "User", 2, new Guid("f87bdfef-07ae-4f40-82c9-3d0bd1e808fa") }
                });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "Template",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "RowId" },
                values: new object[] { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 255, DateTimeKind.Utc).AddTicks(9125), true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 255, DateTimeKind.Utc).AddTicks(9126), "Cybersecurity Default Template", new Guid("21174592-7409-4554-8f68-1156853e48e6") });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "TemplateSection",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "OrderBy", "ParentSectionId", "RowId", "TemplateId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(3005), "The NIST CSF “Identify” function helps assess systems, assets, data, business context, and resources to understand and manage cybersecurity risk.  The components of the Identify function are the foundation for cybersecurity readiness.  Identifying the components that are critical to the enterprise’s infrastructure helps to focus and prioritise development of cybersecurity processes that are consistent with risk management strategy and organisational needs.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(3008), "IDENTIFY (ID)", 1, null, new Guid("09cf2f6e-9420-4420-9703-1770a0e3a10f"), 1L },
                    { 2L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4232), "Asset Management (ID.AM): The data, personnel, devices, systems, and facilities that enable the enterprise to achieve business purposes are identified and managed consistent with their relative importance to organisational objectives and the enterprises’s risk strategy.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4233), "Asset Management (ID.AM)", 1, 1L, new Guid("82645d8b-71f1-415b-a6c5-ca064c3d78b0"), 1L },
                    { 3L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4257), "Business Environment (ID.BE): The enterprise’s mission, objectives, stakeholders, and activities are understood and prioritised; this information is used to inform cybersecurity roles, responsibilities, and risk management decisions.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4257), "Business Environment (ID.BE)", 2, 1L, new Guid("c00a05f5-2970-469a-a774-cf149f24907a"), 1L },
                    { 4L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4261), "Governance (ID.GV): The policies, procedures, and processes to manage and monitor the enterprise’s regulatory, legal, risk, environmental, and operational requirements are understood and inform the management of cybersecurity risk.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4261), "Governance (ID.GV)", 3, 1L, new Guid("e51cfa1d-b517-44d0-8d2f-4e309618c3d2"), 1L },
                    { 5L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4264), "Risk Assessment (ID.RA): The organization understands the cybersecurity risk to organizational operations (including mission, functions, image, or reputation), organizational assets, and individuals.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4264), "Risk Assessment (ID.RA)", 4, 1L, new Guid("13136e7d-7b68-4476-94f9-ef0b5267c77e"), 1L },
                    { 6L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4267), "Risk Management Strategy (ID.RM): The organization’s priorities, constraints, risk tolerances, and assumptions are established and used to support operational risk decisions.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4267), "Risk Management Strategy (ID.RM)", 5, 1L, new Guid("e94dd25b-7fd1-4cb0-9e53-54418e6f9a29"), 1L },
                    { 7L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4270), "Supply Chain Risk Management (ID.SC): The organization’s priorities, constraints, risk tolerances, and assumptions are established and used to support risk decisions associated with managing supply chain risk. The organization has established and implemented the processes to identify, assess and manage supply chain risks.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4270), "Supply Chain Risk Management (ID.SC)", 6, 1L, new Guid("38a6851d-7dd8-4239-a6ea-4bf2459584ca"), 1L },
                    { 8L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4273), "The NIST CSF “Protect” function aims to ensure continuity of critical infrastructure services.  This function provides the framework for providers to develop and implement the appropriate safeguards to limit or contain the potential impact of a cybersecurity event.  The organisational safeguards assessed include access control, awareness and training, data security, information protection processes and procedures, maintenance, and protective technology.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4273), "PROTECT (PR)", 2, null, new Guid("ecc82d53-9816-435c-bb99-1d91809506ec"), 1L },
                    { 9L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4276), "Identity Management, Authentication and Access Control (PR.AC): Access to physical and logical assets and associated facilities is limited to authorized users, processes, and devices, and is managed consistent with the assessed risk of unauthorized access to authorized activities and transactions.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4276), "Identity Management, Authentication and Access Control (PR.AC)", 1, 8L, new Guid("692a4967-632c-4818-a8f6-d16d8cc0f326"), 1L },
                    { 10L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4281), "Awareness and Training (PR.AT): The organization’s personnel and partners are provided cybersecurity awareness education and are trained to perform their cybersecurity-related duties and responsibilities consistent with related policies, procedures, and agreements.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4282), "Awareness and Training (PR.AT)", 2, 8L, new Guid("0909ca27-3721-4e63-9fe5-fbd512c96669"), 1L },
                    { 11L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4284), "Data Security (PR.DS): Information and records (data) are managed consistent with the organization’s risk strategy to protect the confidentiality, integrity, and availability of information.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4285), "Data Security (PR.DS)", 3, 8L, new Guid("3b0dfba8-6ec0-49b0-b11e-3868917563ab"), 1L },
                    { 12L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4287), "Information Protection Processes and Procedures (PR.IP): Security policies (that address purpose, scope, roles, responsibilities, management commitment, and coordination among organizational entities), processes, and procedures are maintained and used to manage protection of information systems and assets.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4287), "Information Protection Processes and Procedures (PR.IP)", 4, 8L, new Guid("aad3d341-f219-4b64-bdd3-429324fa873b"), 1L },
                    { 13L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4290), "Maintenance and repairs of industrial control and information system components are performed consistent with policies and procedures.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4290), "Maintenance (PR.MA)", 5, 8L, new Guid("300a2075-03f5-44af-91d1-fc05958fe9d2"), 1L },
                    { 14L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4293), "Protective Technology (PR.PT): Technical security solutions are managed to ensure the security and resilience of systems and assets, consistent with related policies, procedures, and agreements.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4293), "Protective Technology (PR.PT)", 6, 8L, new Guid("6769c64b-9101-4f87-8252-dc50fc538440"), 1L },
                    { 15L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4308), "The NIST CSF “Detect” function aims to ensure cybersecurity incidents can be identified in a timely manner.  This function assists providers in assessing procedures to rapidly identify cyber events, test detection processes, analyse data to understand attack targets and methods, and inform improvements to organisational processes.  The organisational safeguards assessed include anomalies and events, security continuous monitoring, and detection processes.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4309), "DETECT (DE)", 3, null, new Guid("cd68dace-bd40-42c5-b485-ec76f8baf96b"), 1L },
                    { 16L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4311), "Anomalies and Events (DE.AE): Anomalous activity is detected in a timely manner and the potential impact of events is understood.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4311), "Anomalies and Events (DE.AE)", 1, 15L, new Guid("d12ee893-0323-43d1-a819-3c4622cb2265"), 1L },
                    { 17L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4314), "Security Continuous Monitoring (DE.CM): The information system and assets are monitored to identify cybersecurity events and verify the effectiveness of protective measures.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4314), "Security Continuous Monitoring (DE.CM)", 2, 15L, new Guid("d7bf89c5-e374-4a1f-9c92-76e4b6fc2972"), 1L },
                    { 18L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4319), "Detection Processes (DE.DP): Detection processes and procedures are maintained and tested to ensure awareness of anomalous events.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4320), "Detection Processes (DE.DP)", 2, 15L, new Guid("9f8e1f3f-1f63-4b1b-84c8-016ff61c8b63"), 1L },
                    { 19L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4322), "The NIST CSF “Respond” function aims to assist providers to contain the impact of a potential cybersecurity event. This function supports providers in assessing current processes in place to respond to a detected cybersecurity event.  The organisational safeguards assessed include:  response planning, communications, analysis, mitigation, and improvements.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4323), "RESPOND (RS)", 4, null, new Guid("48871ef7-80c7-446f-a301-37d310972ade"), 1L },
                    { 20L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4325), "Response Planning (RS.RP): Response processes and procedures are executed and maintained to ensure timely response to detected cybersecurity incidents.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4326), "Response Planning (RS.RP)", 1, 19L, new Guid("4cd6db7f-2b71-4780-8f07-cc4c65c357d6"), 1L },
                    { 21L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4328), "Communications (RS.CO): Response activities are coordinated with internal and external stakeholders (e.g., external support from law enforcement agencies).", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4328), "Communications (RS.CO)", 2, 19L, new Guid("17ab1e69-adeb-4f4d-939b-3ed219e58894"), 1L },
                    { 22L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4331), "Analysis (RS.AN): Analysis is conducted to ensure effective response and support recovery activities.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4332), "Analysis (RS.AN)", 3, 19L, new Guid("0598eda2-b439-49af-a3a9-9fc05a72f3fb"), 1L },
                    { 23L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4334), "Mitigation (RS.MI): Activities are performed to prevent expansion of an event, mitigate its effects, and resolve the incident.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4334), "Mitigation (RS.MI)", 4, 19L, new Guid("98108b71-a5ba-492c-b407-1c1b7961eb08"), 1L },
                    { 24L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4337), "Improvements (RS.IM): Organizational response activities are improved by incorporating lessons learned from current and previous detection/response activities.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4337), "Improvements (RS.IM)", 5, 19L, new Guid("06cc5cdf-5f2f-4a4a-9b7b-9348469ac12e"), 1L },
                    { 25L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4340), "The NIST CSF “Recover” function aims to assist providers to restore any capabilities or services that were impaired due to a cybersecurity event.  This function supports providers in assessing current processes in place to recover from a detected cybersecurity event.  The organisational safeguards assessed include: recovery planning, improvements, and communications.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4340), "RECOVER (RC)", 5, null, new Guid("7af3efc5-f9cc-4238-b1ef-e1004c3aa247"), 1L },
                    { 26L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4345), "Recovery Planning (RC.RP): Recovery processes and procedures are executed and maintained to ensure timely restoration of systems or assets affected by cybersecurity incidents.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4345), "Recovery Planning (RC.RP)", 1, 25L, new Guid("2bb1c7c4-33df-47e6-9877-dbffec4240d7"), 1L },
                    { 27L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4347), "Improvements (RC.IM): Recovery planning and processes are improved by incorporating lessons learned into future activities.", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4348), "Improvements (RC.IM)", 2, 25L, new Guid("25c8b905-8c1f-4145-9a88-fa2f57d47756"), 1L },
                    { 28L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4350), "Communications (RC.CO): Restoration activities are coordinated with internal and external stakeholders (e.g., external support from law enforcement agencies).", true, false, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 258, DateTimeKind.Utc).AddTicks(4351), "Communications (RC.CO)", 3, 25L, new Guid("8029b11a-f7a3-4250-a226-5029636ec61d"), 1L }
                });

            migrationBuilder.InsertData(
                schema: "Dcube",
                table: "User",
                columns: new[] { "Id", "Address", "ClientId", "CreatedBy", "CreatedOn", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedBy", "ModifiedOn", "Password", "PhoneNumber", "RoleId", "RowId", "UserName" },
                values: new object[] { 1L, "123 Main St, City, Country", 1L, 1L, new DateTime(2025, 6, 7, 15, 31, 1, 259, DateTimeKind.Utc).AddTicks(7634), "Krishna Chaitanya", true, false, "Kona", 1L, new DateTime(2025, 6, 7, 15, 31, 1, 259, DateTimeKind.Utc).AddTicks(7636), "$2b$12$YAP.oTkyjlqbzrIRvAK9l.fLapZLtJy/eRLHMD0.KjTmS5CZARf6y", "1234567890", 1L, new Guid("1a3880d8-b3c9-494e-9516-3dcac0f0e65f"), "kkona@konaai.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Name",
                schema: "Dcube",
                table: "Client",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Template_Name",
                schema: "Dcube",
                table: "Template",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                schema: "Dcube",
                table: "User",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientExtension",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientQuestionnaireResponse",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientTemplate",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "ClientTemplateSectionResponse",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "Questionnaire",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "QuestionnaireStatusType",
                schema: "MetaData");

            migrationBuilder.DropTable(
                name: "RenderType",
                schema: "MetaData");

            migrationBuilder.DropTable(
                name: "RoleType",
                schema: "MetaData");

            migrationBuilder.DropTable(
                name: "Template",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "TemplateSection",
                schema: "Dcube");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Dcube");
        }
    }
}
