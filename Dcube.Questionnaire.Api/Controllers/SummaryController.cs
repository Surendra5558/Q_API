using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for retrieving summary information related to a client template.
/// </summary>
public class SummaryController(ILogger<SummaryController> logger, ISummaryBusiness summaryBusiness)
    : ODataController
{
    private const string ClassName = nameof(SummaryController);

    /// <summary>
    /// Retrieves the summary information for a client template by its unique identifier.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the <see cref="SummaryViewModel"/> if found; otherwise, a corresponding error response.
    /// </returns>
    /// <response code="200">Returns the summary information for the specified client template.</response>
    /// <response code="404">If the client template is not found.</response>
    /// <response code="401">If the user is unauthorized.</response>
    [HttpGet("v1/[controller]/{clientTemplateId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SummaryViewModel))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetById(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetByIdName} with ID: {Id}", ClassName,
                nameof(GetById), clientTemplateId);

            var response = await summaryBusiness.GetByIdAsync(clientTemplateId);
            return Ok(response);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{GetByIdName}: {EMessage}", ClassName,
                nameof(GetById), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation(
                $"Finished execution of {ClassName}.{nameof(GetById)} with ID: {clientTemplateId}");
        }
    }
}
