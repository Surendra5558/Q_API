using DCube.Questionnaire.Business;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

public class ClientTemplateInformationSectionController(
    ILogger<ClientTemplateInformationSectionController> logger,
    IClientTemplateInformationSectionBusiness clientTemplateInformationSectionBusiness) : ODataController
{
    private const string ClassName = nameof(ClientTemplateInformationSectionController);


    /// <summary>
    /// Retrieves all sections for a given client template.
    /// </summary>
    /// <param name="clientTemplateId">The unique identifier of the client template.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a queryable collection of <see cref="ClientTemplateSectionViewModel"/> if successful;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{clientTemplateId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientTemplateSectionViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetAsyncName} with ID: {ClientTemplateId}",
                ClassName, nameof(GetAsync), clientTemplateId);
            var response = await clientTemplateInformationSectionBusiness.GetAsync(clientTemplateId);
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



