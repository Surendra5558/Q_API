using DCube.Questionnaire.Repository.Common.Constants;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="Domain.Questionnaire"/> entity for Entity Framework Core.
/// Sets up table mapping, base configuration, and property constraints for the questionnaire entity.
/// </summary>
public class QuestionnaireConfiguration : IEntityTypeConfiguration<Domain.Questionnaire>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="Domain.Questionnaire"/>.
    /// Applies base configuration, sets the table name, and configures property constraints
    /// such as maximum length and required fields for <c>Description</c> and <c>Options</c>.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Domain.Questionnaire> builder)
    {
        builder.BaseConfiguration("Questionnaire");
        builder.Property(e => e.Description).HasMaxLength(1000).IsRequired();
        builder.Property(e => e.Options).HasMaxLength(2000);
        builder.Property(e => e.OrderBy).IsRequired().HasDefaultValue(0);
        builder.Property(e => e.RenderTypeId).IsRequired();
        builder.Property(e => e.TemplateSectionId).IsRequired();

        builder.HasData(
            new Domain.Questionnaire
            {
                Id = 1,
                Description = "ID.AM-1: Physical devices and systems within the organization are inventoried",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 2,
                Description = "ID.AM-2: Software platforms and applications within the organization are inventoried",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 3,
                Description = "ID.AM-3: Organizational communication and data flows are mapped",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 4,
                Description = "ID.AM-4: External information systems are catalogued",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 5,
                Description =
                    "ID.AM-5: Resources (e.g., hardware, software, data) are prioritized based on their classification, criticality, and business value",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 6,
                Description =
                    "ID.AM-6: Cybersecurity roles and responsibilities for the entire workforce and third-party stakeholders (e.g., suppliers, customers, partners) are established",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 2,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 7,
                Description = "ID.BE-1: The organization’s role in the supply chain is identified and communicated",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 3,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 8,
                Description = "ID.BE-2: The organization’s place in critical infrastructure and its industry sector is identified",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 3,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 9,
                Description = "ID.BE-3: Priorities for organizational mission, objectives, and activities are established and communicated",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 3,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 10,
                Description = "ID.BE-4: Dependencies and critical functions for delivery of critical services are established",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 3,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 11,
                Description = "ID.BE-5: Resilience requirements to support delivery of critical services are established",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 3,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 12,
                Description = "ID.GV-1: Organizational cybersecurity policy is established and communicated",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 4,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 13,
                Description = "ID.GV-2: Cybersecurity roles and responsibilities are coordinated and aligned with internal roles and external partners",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 4,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 14,
                Description = "ID.GV-3: Legal and regulatory requirements regarding cybersecurity, including privacy and civil liberties obligations, are understood and managed",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 4,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 15,
                Description = "ID.GV-4: Governance and risk management processes address cybersecurity risks",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 4,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 16,
                Description = "ID.RA-1: Asset vulnerabilities are identified and documented",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 17,
                Description = "ID.RA-2: Threats, both internal and external, are identified and documented",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 18,
                Description = "ID.RA-3: Potential business impacts and likelihoods are identified",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 19,
                Description = "ID.RA-4: Risk responses are identified and prioritized",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 20,
                Description = "ID.RA-5: Risk responses are coordinated with internal and external stakeholders",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 21,
                Description = "ID.RA-6: Risk responses are documented and approved by management",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 5,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 22,
                Description = "ID.RM-1: Risk management processes are established, managed, and agreed to by organizational stakeholders",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 6,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 23,
                Description = "ID.RM-2: Organizational risk tolerance is determined and clearly expressed",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 6,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 24,
                Description = "ID.RM-3: The organization’s determination of risk tolerance is informed by its role in critical infrastructure and sector risk management practices",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 6,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 25,
                Description = "ID.SC-1: Cyber supply chain risk management processes are identified, established, assessed, managed, and agreed to by organizational stakeholders",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 7,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 26,
                Description = "ID.SC-2: Cyber supply chain risks are identified and assessed",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 7,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 27,
                Description = "ID.SC-3: Contracts with suppliers and third-party partners include cybersecurity requirements",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 7,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 28,
                Description = "ID.SC-4: Suppliers and third-party partners are monitored to ensure compliance with cybersecurity requirements",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 7,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 29,
                Description = "ID.SC-5: Response and recovery planning and testing are conducted with suppliers and third-party partners",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 7,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 30,
                Description = "PR.AC-1: Identities and credentials are issued, managed, verified, revoked, and audited for authorized devices, users and processes",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 31,
                Description = "PR.AC-2: Physical access to assets is managed and protected",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 32,
                Description = "PR.AC-3: Remote access is managed",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 33,
                Description = "PR.AC-4: Access permissions are managed, incorporating the principles of least privilege and separation of duties",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 34,
                Description = "PR.AC-5: Network integrity is protected (e.g., network segregation, network segmentation)",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 35,
                Description = "PR.AC-6: Identities are proofed and bound to credentials and asserted in interactions",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 36,
                Description = "PR.AC-7: Users, devices, and other assets are authenticated (e.g., single-factor, multi-factor) commensurate with the risk of the transaction (e.g., individuals’ security and privacy risks and other organizational risks)",
                OrderBy = 7,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 9,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 37,
                Description = "PR.AT-1: All users are informed and trained",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 10,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 38,
                Description = "PR.AT-2: Privileged users understand their roles and responsibilities",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 10,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 39,
                Description = "PR.AT-3: Third-party stakeholders (e.g., suppliers, customers, partners) understand their roles and responsibilities",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 10,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 40,
                Description = "PR.AT-4: Senior executives understand their roles and responsibilities",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 10,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 41,
                Description = "PR.AT-5: Physical and cybersecurity personnel understand their roles and responsibilities",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 10,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 42,
                Description = "PR.DS-1: Data-at-rest is protected",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 43,
                Description = "PR.DS-2: Data-in-transit is protected",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 44,
                Description = "PR.DS-3: Assets are formally managed throughout removal, transfers, and disposition",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 45,
                Description = "PR.DS-4: Adequate capacity to ensure availability is maintained",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 46,
                Description = "PR.DS-5: Protections against data leaks are implemented",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 47,
                Description = "PR.DS-6: Integrity checking mechanisms are used to verify software, firmware, and information integrity",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 48,
                Description = "PR.DS-7: The development and testing environment(s) are separate from the production environment",
                OrderBy = 7,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 49,
                Description = "PR.DS-8: Integrity checking mechanisms are used to verify hardware integrity",
                OrderBy = 8,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 11,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 50,
                Description = "PR.IP-1: A baseline configuration of information technology/industrial control systems is created and maintained incorporating security principles (e.g., least functionality)",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 51,
                Description = "PR.IP-2: A System Development Life Cycle to manage systems is implemented",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 52,
                Description = "PR.IP-3: Configuration change control processes are in place",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 53,
                Description = "PR.IP-4: Backups of information are conducted, maintained, and tested periodically",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 54,
                Description = "PR.IP-5: Policy and regulations regarding the physical operating environment for organizational assets are met",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 55,
                Description = "PR.IP-6: Data is destroyed according to policy",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 56,
                Description = "PR.IP-7: Protection processes are improved",
                OrderBy = 7,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 57,
                Description = "PR.IP-8: Effectiveness of protection technologies is shared",
                OrderBy = 8,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 58,
                Description = "PR.IP-9: Response and recovery plans are in place and managed",
                OrderBy = 9,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 59,
                Description = "PR.IP-10: Response and recovery plans are tested",
                OrderBy = 10,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 60,
                Description = "PR.IP-11: Cybersecurity is included in human resources practices (e.g., deprovisioning, personnel screening)",
                OrderBy = 11,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 61,
                Description = "PR.IP-12: A vulnerability management plan is developed and implemented",
                OrderBy = 12,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 12,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 62,
                Description = "PR.MA-1: Maintenance and repair of organizational assets are performed and logged, with approved and controlled tools",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 13,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 63,
                Description = "PR.MA-2: Remote maintenance of organizational assets is approved, logged, and performed in a manner that prevents unauthorized access",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 13,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 64,
                Description = "PR.PT-1: Audit/log records are determined, documented, implemented, and reviewed in accordance with policy",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 14,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 65,
                Description = "PR.PT-2: Removable media is protected and its use restricted according to policy",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 14,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 66,
                Description = "PR.PT-3: Access to systems and assets is controlled, incorporating the principle of least functionality",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 14,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 67,
                Description = "PR.PT-4: Communications and control networks are protected",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 14,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 68,
                Description = "PR.PT-5: Mechanisms (e.g., failsafe, load balancing, hot swap) are implemented to achieve resilience requirements in normal and adverse situations",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 14,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 69,
                Description = "DE.AE-1: A baseline of network operations and expected data flows for users and systems is established and managed",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 16,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 70,
                Description = "DE.AE-2: Detected events are analyzed to understand attack targets and methods",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 16,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 71,
                Description = "DE.AE-3: Event data are collected and correlated from multiple sources and sensors",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 16,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 72,
                Description = "DE.AE-4: Impact of events is determined",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 16,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 73,
                Description = "DE.AE-5: Incident alert thresholds are established",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 16,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 74,
                Description = "DE.CM-1: The network is monitored to detect potential cybersecurity events",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 75,
                Description = "DE.CM-2: The physical environment is monitored to detect potential cybersecurity events",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 76,
                Description = "DE.CM-3: Personnel activity is monitored to detect potential cybersecurity events",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 77,
                Description = "DE.CM-4: Malicious code is detected",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 78,
                Description = "DE.CM-5: Unauthorized mobile code is detected",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 79,
                Description = "DE.CM-6: External service provider activity is monitored to detect potential cybersecurity events",
                OrderBy = 6,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 80,
                Description = "DE.CM-7: Monitoring for unauthorized personnel, connections, devices, and software is performed",
                OrderBy = 7,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 81,
                Description = "DE.CM-8: Vulnerability scans are performed",
                OrderBy = 8,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 17,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 82,
                Description = "DE.DP-1: Roles and responsibilities for detection are well defined to ensure accountability",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 18,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 83,
                Description = "DE.DP-2: Detection activities comply with all applicable requirements",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 18,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 84,
                Description = "DE.DP-3: Detection processes are tested",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 18,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 85,
                Description = "DE.DP-4: Event detection information is communicated",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 18,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 86,
                Description = "DE.DP-5: Detection processes are continuously improved",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 18,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 87,
                Description = "RS.RP-1: Response plan is executed during or after an incident",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 20,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 88,
                Description = "RS.CO-1: Personnel know their roles and order of operations when a response is needed",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 21,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 89,
                Description = "RS.CO-2: Incidents are reported consistent with established criteria",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 21,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 90,
                Description = "RS.CO-3: Information is shared consistent with response plans",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 21,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 91,
                Description = "RS.CO-4: Coordination with stakeholders occurs consistent with response plans",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 21,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 92,
                Description = "RS.CO-5: Voluntary information sharing occurs with external stakeholders to achieve broader cybersecurity situational awareness",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 21,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 93,
                Description = "RS.AN-1: Notifications from detection systems are investigated",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 22,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 94,
                Description = "RS.AN-2: The impact of the incident is understood",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 22,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 95,
                Description = "RS.AN-3: Forensics are performed",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 22,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 96,
                Description = "RS.AN-4: Incidents are categorized consistent with response plans",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 22,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 97,
                Description = "RS.AN-5: Processes are established to receive, analyze and respond to vulnerabilities disclosed to the organization from internal and external sources (e.g. internal testing, security bulletins, or security researchers)",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 22,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 98,
                Description = "RS.MI-1: Incidents are contained",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 23,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 99,
                Description = "RS.MI-2: Incidents are mitigated",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 23,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 100,
                Description = "RS.MI-3: Newly identified vulnerabilities are mitigated or documented as accepted risks",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 23,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 101,
                Description = "RS.IM-1: Response plans incorporate lessons learned",
                OrderBy = 4,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 24,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 102,
                Description = "RS.IM-2: Response strategies are updated",
                OrderBy = 5,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 24,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 103,
                Description = "RC.RP-1: Recovery plan is executed during or after a cybersecurity incident",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 26,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 104,
                Description = "RC.IM-1: Recovery plans incorporate lessons learned into future activities",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 27,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 105,
                Description = "RC.IM-2: Recovery strategies are updated",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 27,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 106,
                Description = "RC.CO-1: Public relations are managed",
                OrderBy = 1,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 28,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 107,
                Description = "RC.CO-2: Reputation is repaired after an incident",
                OrderBy = 2,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 28,
                Options = "[YES,Inprogress,NO,NA]"
            },
            new Domain.Questionnaire
            {
                Id = 108,
                Description = "RC.CO-3: Recovery activities are communicated to internal and external stakeholders as well as executive and management teams",
                OrderBy = 3,
                RenderTypeId = RenderTypes.RadioButton,
                TemplateSectionId = 28,
                Options = "[YES,Inprogress,NO,NA]"
            }
        );
    }
}