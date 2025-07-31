using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;


public class ClientTemplateSectionSolutionController(ILogger<ClientTemplateInformationSectionController> logger,
    IValidator<ClientTemplateSectionSolutionSaveModel> validator, IClientTemplateSectionSolutionBusiness clientTemplateSectionSolutionBusiness)
    : ODataController
{
    private const string ClassName = nameof(ClientController);

    /// <summary>
    /// Retrieves all clients.
    /// </summary>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a collection of clients if successful; otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{clientTemplateId}")]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientTemplateSectionSolutionViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync(long clientTemplateId)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(GetAsync)}");

            var response = await clientTemplateSectionSolutionBusiness.GetAsync(clientTemplateId);
            return Ok(response);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{GetAsyncName}: {EMessage}", ClassName,
                nameof(GetAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(GetAsync)}");
        }
    }

    /// <summary>
    /// Submits client questionnaire responses for a specific section.
    /// </summary>
    /// <param name="models">The model containing the client template section response ID and the questionnaire responses to save.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the operation.
    /// Returns <see cref="StatusCodes.Status201Created"/> if successful.
    /// </returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] List<ClientTemplateSectionSolutionSaveModel> models)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{nameof(PostAsync)}", ClassName,
                nameof(PostAsync));

            var validationResult = new ValidationResult();

            foreach (var model in models)
            {
                validationResult = await validator.ValidateAsync(model);
            }

            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for model in {ClassName}.{MethodName}: {Errors}", ClassName,
                    nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await clientTemplateSectionSolutionBusiness.SaveAsync(models);

            return Created();
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{MethodName}: {EMessage}", ClassName,
                nameof(PostAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(PostAsync)}");
        }
    }
}


