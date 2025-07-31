using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing client template sections, including retrieval of all sections for a given client template.
/// </summary>
public class ClientTemplateSectionController(ILogger<ClientTemplateController> logger, IClientTemplateSectionBusiness clientTemplateSectionBusiness)
    : ODataController
{
    private const string ClassName = nameof(ClientTemplateSectionController);

    /// <summary>
    /// Retrieves all sections for a given client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a queryable collection of <see cref="ClientTemplateSectionViewModel"/> if successful;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{clientTemplateId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientTemplateInfromationSectionViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetAsyncName} with ID: {ClientTemplateId}",
                ClassName, nameof(GetAsync), clientTemplateId);
            var response = await clientTemplateSectionBusiness.GetAsync(clientTemplateId);
            return Ok(response);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{MethodName}: {EMessage}", ClassName,
                nameof(GetAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(GetAsync)}");
        }
    }
}