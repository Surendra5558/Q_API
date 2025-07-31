using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing client section questionnaire responses, including retrieval and submission of section-wise responses.
/// </summary>
public class ClientSectionQuestionnaire(
    ILogger<ClientSectionQuestionnaire> logger,
    IValidator<List<ClientQuestionnaireResponseSaveModel>> saveValidator,
    IClientQuestionnaireResponseSectionWiseBusiness clientQuestionnaireResponseSectionWiseBusiness)
    : ODataController
{
    private const string ClassName = nameof(ClientSectionQuestionnaire);

    /// <summary>
    /// Retrieves the section-wise client questionnaire response view model for the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client questionnaire section response.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the <see cref="ClientQuestionnaireResponseSectionWiseViewModel"/> if found;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{id}")]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientQuestionnaireResponseSectionWiseViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync(long id)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetAsyncName} with ID: {Id}", ClassName,
                nameof(GetAsync), id);

            var response = await clientQuestionnaireResponseSectionWiseBusiness.GetAsync(id);
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
    public async Task<IActionResult> PostAsync([FromBody] List<ClientQuestionnaireResponseSaveModel> models)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{nameof(PostAsync)}", ClassName,
                nameof(PostAsync));

            var validationResult = await saveValidator.ValidateAsync(models);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for model in {ClassName}.{MethodName}: {Errors}", ClassName,
                    nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await clientQuestionnaireResponseSectionWiseBusiness.SaveAsync(models);

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