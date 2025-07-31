using DCube.Questionnaire.Repository.Common.Constants;
using DCube.Questionnaire.Repository.Common.Extensions;
using DCube.Questionnaire.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the EF Core entity mapping for <see cref="Information"/>,
/// including property constraints and seed data for the AdditionalQuestionnaire table.
/// </summary>
public class InformationConfiguration : IEntityTypeConfiguration<Information>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="Information"/>.
    /// Sets up property requirements, constraints, and initial seed data.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Information> builder)
    {
        builder.BaseConfiguration("Information");
        builder.Property(e => e.Description).HasMaxLength(1000).IsRequired();
        builder.Property(e => e.Options).HasMaxLength(2000);
        builder.Property(e => e.OrderBy).IsRequired().HasDefaultValue(0);
        builder.Property(e => e.RenderTypeId).IsRequired();
        builder.Property(e => e.InformationSectionId).IsRequired();

        builder.HasData(
            new Information
            {
                Id = 1,
                InformationSectionId = 1,
                Description = "How many total endpoints are currently in use (workstations, laptops, servers, mobile devices)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 2,
                InformationSectionId = 1,
                Description = "How many physical or virtual office locations do you operate from?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 3,
                InformationSectionId = 1,
                Description = "What is your current technology stack (OS, application platforms, infrastructure tools)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.CheckBox,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1,
                Options = "['Microsoft','Google','Apple','Other']"
            },
            new Information
            {
                Id = 4,
                InformationSectionId = 1,
                Description = "Are there any OT (Operational Technology) systems or IoT devices in use?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 5,
                InformationSectionId = 2,
                Description = "What Endpoint Detection and Response (EDR) solution(s) are currently deployed?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 6,
                InformationSectionId = 2,
                Description = "Are antivirus or anti-malware solutions deployed on all endpoints?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 7,
                InformationSectionId = 2,
                Description = "Do you use any device management tools like MDM (Mobile Device Management)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 8,
                InformationSectionId = 3,
                Description = "Are you using any public, private, or hybrid cloud infrastructure? Please specify (e.g., AWS, Azure, GCP).",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 9,
                InformationSectionId = 3,
                Description = "Are workloads or data hosted in the cloud? If yes, what types (VMs, containers, SaaS, etc.)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 10,
                InformationSectionId = 4,
                Description = "Are you using Microsoft 365 (O365)? If yes, which services (Exchange Online, Teams, SharePoint, etc.)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 11,
                InformationSectionId = 4,
                Description = "Are you using Google Workspace (G Suite)? If yes, which services (Gmail, Drive, Meet, etc.)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 12,
                InformationSectionId = 4,
                Description = "Do you use any third-party email platforms or services (e.g., Zimbra, ProtonMail)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 13,
                InformationSectionId = 4,
                Description = "Is there any secure email gateway or DLP (Data Loss Prevention) solution in place?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 14,
                InformationSectionId = 5,
                Description = "How is business-critical data stored and retained (on-premises, cloud, hybrid)?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 15,
                InformationSectionId = 5,
                Description = "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 16,
                InformationSectionId = 5,
                Description = "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 17,
                InformationSectionId = 5,
                Description = "Do you have a documented Records Retention Policy? If yes, can you provide a copy or summary?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 18,
                InformationSectionId = 6,
                Description = "What SIEM solution do you currently use for ingesting and correlating security data?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.CheckBox,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
                Options = "['SentinalOne','Crowd Strike','None','Other']"
            },
            new Information
            {
                Id = 19,
                InformationSectionId = 6,
                Description = "Is your SIEM deployment on-premises or cloud-based?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 20,
                InformationSectionId = 6,
                Description = "How many distinct data sources are currently configured to forward logs to the SIEM?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 21,
                InformationSectionId = 6,
                Description = "Average volume of data ingested per day",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextBox,
                OrderBy = 4,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 22,
                InformationSectionId = 6,
                Description = "Total data stored as of today",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextBox,
                OrderBy = 5,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 23,
                InformationSectionId = 6,
                Description = "Log retention period configured",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextBox,
                OrderBy = 6,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 24,
                InformationSectionId = 6,
                Description = "How are correlation rules and alerting mechanisms designed and managed?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 25,
                InformationSectionId = 6,
                Description = "Integration with external tools (e.g., Threat Intelligence platforms, CRM systems, etc.)",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 9,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 26,
                InformationSectionId = 6,
                Description = "Orchestration with security infrastructure (e.g., firewalls, web/email gateways, cloud platforms, etc.)",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 10,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 27,
                InformationSectionId = 6,
                Description = "Automated response capabilities (e.g., automatic blocking, IOC reputation lookups, etc.)",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 11,
                CreatedBy = 1,
                ModifiedBy = 1
            },

            new Information
            {
                Id = 28,
                InformationSectionId = 1,
                Description = "Have you Previously Conducted Penetration Testing? If yes, please mention the date.",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 5,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new Information
            {
                Id = 29,
                InformationSectionId = 5,
                Description = "What regulatory do you complain with?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.CheckBox,
                OrderBy = 5,
                CreatedBy = 1,
                ModifiedBy = 1,
                Options = "['HIPPA','GDPR','PCIDSS','SOX','ISO/IEC 27001','NIST','CCPA','FERPA','FISMA','Other']"

            },
            new Information
            {
                Id = 30,
                InformationSectionId = 6,
                Description = "What regulatory do you need to comply with for log data?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 7,
                CreatedBy = 1,
                ModifiedBy = 1,

            },
            new Information
            {
                Id = 31,
                InformationSectionId = 7,
                Description = "Do you currently have Cyber Insurance coverage?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 1,
                CreatedBy = 1,
                ModifiedBy = 1,

            },
            new Information
            {
                Id = 32,
                InformationSectionId = 7,
                Description = "Do you have an Established Incident response [IR] plan?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 2,
                CreatedBy = 1,
                ModifiedBy = 1,

            },
            new Information
            {
                Id = 33,
                InformationSectionId = 7,
                Description = "Who is your cyber insurance broker or provider?",
                IsMandatory = false,
                RenderTypeId = RenderTypes.TextArea,
                OrderBy = 3,
                CreatedBy = 1,
                ModifiedBy = 1,

            }

        );
    }
}