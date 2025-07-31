using DCube.Questionnaire.Model.ViewModel;

namespace DCube.Questionnaire.Business.Interface;

/// <summary>
/// Provides business operations for retrieving summary information related to a client template.
/// </summary>
public interface ISummaryBusiness
{
    /// <summary>
    /// Retrieves the summary information for the specified client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="SummaryViewModel"/>
    /// with overall score, client summary, and resilience summary information.
    /// </returns>
    Task<SummaryViewModel> GetByIdAsync(long clientTemplateId);
}