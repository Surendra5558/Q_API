using DCube.Questionnaire.Business;
using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Repository;
using DCube.Questionnaire.Repository.DataAccess;
using DCube.Questionnaire.Repository.DataAccess.Interface;
using FluentValidation;
using DCube.Questionnaire.Repository.DataAccess.Interface.MetaData;
using DCube.Questionnaire.Repository.DataAccess.MetaData;

namespace DCube.Questionnaire.Api.Extensions;

/// <summary>
/// Static class for DependencyInjectionExtension
/// </summary>
public static class DependencyInjectionExtension
{
    /// <summary>
    /// Adds the dependency.
    /// </summary>
    /// <param name="serviceCollection">The service collection.</param>
    public static void AddDependency(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddValidatorsFromAssemblyContaining<ClientValidator>();
        serviceCollection.AddHttpContextAccessor();
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<QuestionnaireDbContext>();

        serviceCollection.AddScoped<IUserLoginBusiness, UserLoginBusiness>();
        serviceCollection.AddScoped<IUserContext, UserContext>();

        serviceCollection.AddScoped<IClientBusiness, ClientBusiness>();
        serviceCollection.AddScoped<IClientInformationSectionWiseBusiness, ClientInformationSectionWiseBusiness>();
        serviceCollection.AddScoped<IClientQuestionnaireResponseSectionWiseBusiness, ClientQuestionnaireResponseSectionWiseBusiness>();
        serviceCollection.AddScoped<IClientTemplateBusiness, ClientTemplateBusiness>();
        serviceCollection.AddScoped<IClientTemplateSectionBusiness, ClientTemplateSectionBusiness>();
        serviceCollection.AddScoped<IClientTemplateSectionSolutionBusiness, ClientTemplateSectionSolutionBusiness>();
        serviceCollection.AddScoped<IClientTemplateInformationSectionBusiness, ClientTemplateInformationSectionBusiness>();
        serviceCollection.AddScoped<ISummaryBusiness, SummaryBusiness>();
        serviceCollection.AddScoped<IUserBusiness, UserBusiness>();
        serviceCollection.AddScoped<ITemplateBusiness, TemplateBusiness>();


        serviceCollection.AddScoped<IQuestionnaireStatusTypeRepository, QuestionnaireStatusTypeRepository>();
        serviceCollection.AddScoped<IQuestionResponseWeightageTypeRepository, QuestionResponseWeightageTypeRepository>();
        serviceCollection.AddScoped<IRenderTypeRepository, RenderTypeRepository>();
        serviceCollection.AddScoped<IRoleTypeRepository, RoleTypeRepository>();
        serviceCollection.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
        serviceCollection.AddScoped<IClientExtensionRepository, ClientExtensionRepository>();
        serviceCollection.AddScoped<IClientInformationRepository, ClientInformationRepository>();
        serviceCollection.AddScoped<IClientQuestionnaireResponseRepository, ClientQuestionnaireResponseRepository>();
        serviceCollection.AddScoped<IClientTemplateDocumentRepository, ClientTemplateDocumentRepository>();
        serviceCollection.AddScoped<IClientRepository, ClientRepository>();
        serviceCollection.AddScoped<IClientTemplateRepository, ClientTemplateRepository>();
        serviceCollection.AddScoped<IClientTemplateInformationSectionRepository, ClientTemplateInformationSectionRepository>();
        serviceCollection.AddScoped<IClientTemplateSectionSolutionRepository, ClientTemplateSectionSolutionRepository>();
        serviceCollection.AddScoped<IClientTemplateSectionResponseRepository, ClientTemplateSectionResponseRepository>();
        serviceCollection.AddScoped<IInformationRepository, InformationRepository>();
        serviceCollection.AddScoped<IInformationSectionRepository, InformationSectionRepository>();
        serviceCollection.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
        serviceCollection.AddScoped<ITemplateRepository, TemplateRepository>();
        serviceCollection.AddScoped<ITemplateSectionRepository, TemplateSectionRepository>();
        serviceCollection.AddScoped<IUserRepository, UserRepository>();
    }
}