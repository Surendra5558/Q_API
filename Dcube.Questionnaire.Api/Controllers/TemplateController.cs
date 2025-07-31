using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing templates, including retrieval operations.
/// </summary>
public class TemplateController(ILogger<TemplateController> logger, ITemplateBusiness templateBusiness) : ODataController
{
    private const string ClassName = nameof(TemplateController);

    /// <summary>
    /// Retrieves all templates with their details.
    /// </summary>
    /// <remarks>
    /// Returns a queryable collection of all templates. Supports OData query options for filtering, sorting, and paging.
    /// </remarks>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a collection of <see cref="TemplateViewModel"/> if successful; otherwise, a corresponding error response.
    /// </returns>
    [HttpGet]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<TemplateViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync()
    {
        try
        {
            logger.LogInformation("{ClassName} - Get started", ClassName);
            var result = await templateBusiness.GetAsync();
            return Ok(result);
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in Get", ClassName);
            return StatusCode(500, "Internal server error");
        }
        finally
        {
            logger.LogInformation("{ClassName} - Get completed", ClassName);
        }
    }

}

