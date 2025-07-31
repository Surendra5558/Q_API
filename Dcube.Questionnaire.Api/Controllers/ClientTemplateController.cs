using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing client-template associations, including retrieval, creation, and update operations.
/// </summary>
public class ClientTemplateController(
    ILogger<ClientTemplateController> logger,
    IValidator<ClientTemplateCreateModel> createValidator,
    IValidator<ClientTemplateUpdateModel> updateValidator,
    IClientTemplateBusiness clientTemplateBusiness)
    : ODataController
{
    private const string ClassName = nameof(ClientTemplateController);

    /// <summary>
    /// Retrieves all client-template associations.
    /// </summary>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a queryable collection of <see cref="ClientTemplateViewModel"/> if successful;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientTemplateViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync()
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(GetAsync)}");

            var response = await clientTemplateBusiness.GetAsync();
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
    /// Creates a new client-template association.
    /// </summary>
    /// <param name="model">The <see cref="ClientTemplateCreateModel"/> containing the data required to create the association.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the operation.
    /// Returns <see cref="StatusCodes.Status201Created"/> if successful.
    /// </returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] ClientTemplateCreateModel model)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(PostAsync)}");

            var validationResult = await createValidator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for {ClassName}.{MethodName}: {Errors}", ClassName,
                    nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }

            var response = await clientTemplateBusiness.CreateAsync(model);
            return Ok(response);
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

    /// <summary>
    /// Updates an existing client-template association.
    /// </summary>
    /// <param name="model">The <see cref="ClientTemplateUpdateModel"/> containing the data required to update the association.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the update operation.
    /// Returns <see cref="StatusCodes.Status200OK"/> if successful.
    /// </returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PutAsync([FromBody] ClientTemplateUpdateModel model)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(PutAsync)}");

            var validationResult = await updateValidator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for {ClassName}.{MethodName}: {Errors}", ClassName,
                    nameof(PutAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await clientTemplateBusiness.UpdateAsync(model);
            return Ok(response);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{MethodName}: {EMessage}", ClassName,
                nameof(PutAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(PutAsync)}");
        }
    }
}