using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

public class ClientInformationController(ILogger<ClientInformationController> logger,
    IValidator<List<ClientInformationResponseSaveModel>> validator,
    IClientInformationSectionWiseBusiness clientInformationSectionWiseBusiness) : ODataController
{
    private const string ClassName = nameof(ClientController);

    /// <summary>
    /// Retrieves the section-wise client questionnaire response view model for the specified identifier.
    /// </summary>
    /// <param name="clientTemplateInfromationSectionId"></param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the <see cref="ClientInformationSectionWiseViewModel"/> if found;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{clientTemplateInfromationSectionId}")]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientInformationSectionWiseViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync(long clientTemplateInfromationSectionId)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetAsyncName} with ID: {Id}", ClassName,
                nameof(GetAsync), clientTemplateInfromationSectionId);

            var response = await clientInformationSectionWiseBusiness.GetAsync(clientTemplateInfromationSectionId);
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
    public async Task<IActionResult> PostAsync([FromBody] List<ClientInformationResponseSaveModel> models)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{nameof(PostAsync)}", ClassName,
                nameof(PostAsync));

            var validationResult = await validator.ValidateAsync(models);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for model in {ClassName}.{MethodName}: {Errors}", ClassName,
                    nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await clientInformationSectionWiseBusiness.SaveAsync(models);

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