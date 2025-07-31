using DCube.Questionnaire.Model.ViewModel;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace DCube.Questionnaire.Api.Models;

/// <summary>
/// Class for EDM Model
/// </summary>
public class EdmModelBuilder
{
    /// <summary>
    /// Gets the EDM Model
    /// </summary>
    /// <returns></returns>
    public static IEdmModel GetModels()
    {
        var builder = new ODataConventionModelBuilder();
        builder.EnableLowerCamelCase();

        builder.EntitySet<ClientViewModel>("Client").EntityType.HasKey(x => x.Id);
        builder.EntitySet<ClientTemplateViewModel>("ClientTemplate").EntityType.HasKey(x => x.Id);
        builder.EntitySet<ClientTemplateMaturityPathViewModel>("ClientTemplateMaturityPath")
            .EntityType.HasKey(x => x.Id);
        builder.EntitySet<ClientTemplateSectionViewModel>("ClientTemplateSection").EntityType.HasKey(x => x.Id);
        builder.EntitySet<ClientQuestionnaireResponseSectionWiseViewModel>("ClientSectionQuestionnaire")
            .EntityType.HasKey(x => x.Id).CollectionProperty(x => x.QuestionnaireResponses);
        var summaryBuiler = builder.EntitySet<SummaryViewModel>("Summary").EntityType.HasKey(x => x.Id);
        summaryBuiler.CollectionProperty(x => x.ResilienceSummaries);
        summaryBuiler.ComplexProperty(x => x.ClientSummary);
        builder.EntitySet<ClientTemplateSectionSolutionViewModel>("ClientTemplateSectionSolution").EntityType
            .HasKey(x => x.Id);
        builder.EntitySet<ClientTemplateInfromationSectionViewModel>("ClientTemplateInformationSection").EntityType.HasKey(x => x.Id);
        builder.EntitySet<ClientInformationSectionWiseViewModel>("ClientInformation").EntityType.HasKey(x => x.Id)
            .CollectionProperty(x => x.InformationResponses);
        builder.EntitySet<TemplateViewModel>("Template").EntityType.HasKey(x => x.Id);
        builder.EntitySet<UserViewModel>("User").EntityType.HasKey(x => x.Id);

        return builder.GetEdmModel();
    }
}