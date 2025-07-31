using DCube.Questionnaire.Repository.Domain;
using DCube.Questionnaire.Repository.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCube.Questionnaire.Repository.Configuration;

/// <summary>
/// Configures the <see cref="TemplateSection"/> entity for Entity Framework Core.
/// Sets up table mapping and applies base configuration for sections.
/// </summary>
public class TemplateSectionConfiguration : IEntityTypeConfiguration<TemplateSection>
{
    /// <summary>
    /// Configures the entity type builder for <see cref="TemplateSection"/>.
    /// Applies base configuration and sets the table name.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<TemplateSection> builder)
    {
        builder.BaseConfiguration("TemplateSection");
        builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(1000);
        builder.Property(e => e.OrderBy).IsRequired();

        builder.HasData(
            new TemplateSection
            {
                Id = 1,
                TemplateId = 1,
                Name = "IDENTITY (ID)",
                Description =
                    "The NIST CSF “Identify” function helps assess systems, assets, data, business context, and resources to understand and manage cybersecurity risk.  The components of the Identify function are the foundation for cybersecurity readiness.  Identifying the components that are critical to the enterprise’s infrastructure helps to focus and prioritise development of cybersecurity processes that are consistent with risk management strategy and organisational needs.",
                OrderBy = 1,
                ParentSectionId = null,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 2,
                TemplateId = 1,
                Name = "Asset Management (ID.AM)",
                Description =
                    "Asset Management (ID.AM): The data, personnel, devices, systems, and facilities that enable the enterprise to achieve business purposes are identified and managed consistent with their relative importance to organisational objectives and the enterprises’s risk strategy.",
                OrderBy = 1,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 3,
                TemplateId = 1,
                Name = "Business Environment (ID.BE)",
                Description =
                    "Business Environment (ID.BE): The enterprise’s mission, objectives, stakeholders, and activities are understood and prioritised; this information is used to inform cybersecurity roles, responsibilities, and risk management decisions.",
                OrderBy = 2,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 4,
                TemplateId = 1,
                Name = "Governance (ID.GV)",
                Description =
                    "Governance (ID.GV): The policies, procedures, and processes to manage and monitor the enterprise’s regulatory, legal, risk, environmental, and operational requirements are understood and inform the management of cybersecurity risk.",
                OrderBy = 3,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 5,
                TemplateId = 1,
                Name = "Risk Assessment (ID.RA)",
                Description =
                    "Risk Assessment (ID.RA): The organization understands the cybersecurity risk to organizational operations (including mission, functions, image, or reputation), organizational assets, and individuals.",
                OrderBy = 4,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 6,
                TemplateId = 1,
                Name = "Risk Management Strategy (ID.RM)",
                Description =
                    "Risk Management Strategy (ID.RM): The organization’s priorities, constraints, risk tolerances, and assumptions are established and used to support operational risk decisions.",
                OrderBy = 5,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 7,
                TemplateId = 1,
                Name = "Supply Chain Risk Management (ID.SC)",
                Description =
                    "Supply Chain Risk Management (ID.SC): The organization’s priorities, constraints, risk tolerances, and assumptions are established and used to support risk decisions associated with managing supply chain risk. The organization has established and implemented the processes to identify, assess and manage supply chain risks.",
                OrderBy = 6,
                ParentSectionId = 1,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 8,
                TemplateId = 1,
                Name = "PROTECT (PR)",
                Description =
                    "The NIST CSF “Protect” function aims to ensure continuity of critical infrastructure services.  This function provides the framework for providers to develop and implement the appropriate safeguards to limit or contain the potential impact of a cybersecurity event.  The organisational safeguards assessed include access control, awareness and training, data security, information protection processes and procedures, maintenance, and protective technology.",
                OrderBy = 2,
                ParentSectionId = null,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 9,
                TemplateId = 1,
                Name = "Identity Management, Authentication and Access Control (PR.AC)",
                Description =
                    "Identity Management, Authentication and Access Control (PR.AC): Access to physical and logical assets and associated facilities is limited to authorized users, processes, and devices, and is managed consistent with the assessed risk of unauthorized access to authorized activities and transactions.",
                OrderBy = 1,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 10,
                TemplateId = 1,
                Name = "Awareness and Training (PR.AT)",
                Description =
                    "Awareness and Training (PR.AT): The organization’s personnel and partners are provided cybersecurity awareness education and are trained to perform their cybersecurity-related duties and responsibilities consistent with related policies, procedures, and agreements.",
                OrderBy = 2,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 11,
                TemplateId = 1,
                Name = "Data Security (PR.DS)",
                Description =
                    "Data Security (PR.DS): Information and records (data) are managed consistent with the organization’s risk strategy to protect the confidentiality, integrity, and availability of information.",
                OrderBy = 3,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 12,
                TemplateId = 1,
                Name = "Information Protection Processes and Procedures (PR.IP)",
                Description =
                    "Information Protection Processes and Procedures (PR.IP): Security policies (that address purpose, scope, roles, responsibilities, management commitment, and coordination among organizational entities), processes, and procedures are maintained and used to manage protection of information systems and assets.",
                OrderBy = 4,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 13,
                TemplateId = 1,
                Name = "Maintenance (PR.MA)",
                Description =
                    "Maintenance and repairs of industrial control and information system components are performed consistent with policies and procedures.",
                OrderBy = 5,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 14,
                TemplateId = 1,
                Name = "Protective Technology (PR.PT)",
                Description =
                    "Protective Technology (PR.PT): Technical security solutions are managed to ensure the security and resilience of systems and assets, consistent with related policies, procedures, and agreements.",
                OrderBy = 6,
                ParentSectionId = 8,
                CreatedBy = 1,
                ModifiedBy = 1
            },

            new TemplateSection
            {
                Id = 15,
                TemplateId = 1,
                Name = "DETECT (DE)",
                Description =
                    "The NIST CSF “Detect” function aims to ensure cybersecurity incidents can be identified in a timely manner.  This function assists providers in assessing procedures to rapidly identify cyber events, test detection processes, analyse data to understand attack targets and methods, and inform improvements to organisational processes.  The organisational safeguards assessed include anomalies and events, security continuous monitoring, and detection processes.",
                OrderBy = 3,
                ParentSectionId = null,
                CreatedBy = 1,
                ModifiedBy = 1,
            },
            new TemplateSection
            {
                Id = 16,
                TemplateId = 1,
                Name = "Anomalies and Events (DE.AE)",
                Description =
                    "Anomalies and Events (DE.AE): Anomalous activity is detected in a timely manner and the potential impact of events is understood.",
                OrderBy = 1,
                ParentSectionId = 15,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 17,
                TemplateId = 1,
                Name = "Security Continuous Monitoring (DE.CM)",
                Description =
                    "Security Continuous Monitoring (DE.CM): The information system and assets are monitored to identify cybersecurity events and verify the effectiveness of protective measures.",
                OrderBy = 2,
                ParentSectionId = 15,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 18,
                TemplateId = 1,
                Name = "Detection Processes (DE.DP)",
                Description = "Detection Processes (DE.DP): Detection processes and procedures are maintained and tested to ensure awareness of anomalous events.",
                OrderBy = 2,
                ParentSectionId = 15,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 19,
                TemplateId = 1,
                Name = "RESPOND (RS)",
                Description =
                    "The NIST CSF “Respond” function aims to assist providers to contain the impact of a potential cybersecurity event. This function supports providers in assessing current processes in place to respond to a detected cybersecurity event.  The organisational safeguards assessed include:  response planning, communications, analysis, mitigation, and improvements.",
                OrderBy = 4,
                ParentSectionId = null,
                CreatedBy = 1,
                ModifiedBy = 1,
            },
            new TemplateSection
            {
                Id = 20,
                TemplateId = 1,
                Name = "Response Planning (RS.RP)",
                Description =
                    "Response Planning (RS.RP): Response processes and procedures are executed and maintained to ensure timely response to detected cybersecurity incidents.",
                OrderBy = 1,
                ParentSectionId = 19,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 21,
                TemplateId = 1,
                Name = "Communications (RS.CO)",
                Description =
                    "Communications (RS.CO): Response activities are coordinated with internal and external stakeholders (e.g., external support from law enforcement agencies).",
                OrderBy = 2,
                ParentSectionId = 19,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 22,
                TemplateId = 1,
                Name = "Analysis (RS.AN)",
                Description =
                    "Analysis (RS.AN): Analysis is conducted to ensure effective response and support recovery activities.",
                OrderBy = 3,
                ParentSectionId = 19,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 23,
                TemplateId = 1,
                Name = "Mitigation (RS.MI)",
                Description =
                    "Mitigation (RS.MI): Activities are performed to prevent expansion of an event, mitigate its effects, and resolve the incident.",
                OrderBy = 4,
                ParentSectionId = 19,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 24,
                TemplateId = 1,
                Name = "Improvements (RS.IM)",
                Description =
                    "Improvements (RS.IM): Organizational response activities are improved by incorporating lessons learned from current and previous detection/response activities.",
                OrderBy = 5,
                ParentSectionId = 19,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 25,
                TemplateId = 1,
                Name = "RECOVER (RC)",
                Description =
                    "The NIST CSF “Recover” function aims to assist providers to restore any capabilities or services that were impaired due to a cybersecurity event.  This function supports providers in assessing current processes in place to recover from a detected cybersecurity event.  The organisational safeguards assessed include: recovery planning, improvements, and communications.",
                OrderBy = 5,
                ParentSectionId = null,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 26,
                TemplateId = 1,
                Name = "Recovery Planning (RC.RP)",
                Description =
                    "Recovery Planning (RC.RP): Recovery processes and procedures are executed and maintained to ensure timely restoration of systems or assets affected by cybersecurity incidents.",
                OrderBy = 1,
                ParentSectionId = 25,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 27,
                TemplateId = 1,
                Name = "Improvements (RC.IM)",
                Description =
                    "Improvements (RC.IM): Recovery planning and processes are improved by incorporating lessons learned into future activities.",
                OrderBy = 2,
                ParentSectionId = 25,
                CreatedBy = 1,
                ModifiedBy = 1
            },
            new TemplateSection
            {
                Id = 28,
                TemplateId = 1,
                Name = "Communications (RC.CO)",
                Description =
                    "Communications (RC.CO): Restoration activities are coordinated with internal and external stakeholders (e.g., external support from law enforcement agencies).",
                OrderBy = 3,
                ParentSectionId = 25,
                CreatedBy = 1,
                ModifiedBy = 1
            });
    }
}