using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing clients, including retrieval and creation operations.
/// </summary>
public class ClientController(ILogger<ClientController> logger, IValidator<ClientCreateModel> createValidator,
    IValidator<ClientUpdateModel> updareValidator, IClientBusiness clientBusiness)
    : ODataController
{
    private const string ClassName = nameof(ClientController);

    /// <summary>
    /// Retrieves all clients.
    /// </summary>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a collection of clients if successful; otherwise, a corresponding error response.
    /// </returns>
    [HttpGet]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<ClientViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync()
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(GetAsync)}");

            var response = await clientBusiness.GetAsync();
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
    /// Retrieves a client by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the client.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the client if found; otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClientViewModel))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetById(long id)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{GetByIdName} with ID: {Id}", ClassName, nameof(GetById), id);

            var response = await clientBusiness.GetByIdAsync(id);
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
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(GetById)} with ID: {id}");
        }
    }

    /// <summary>
    /// Creates a new client.
    /// </summary>
    /// <param name="model">The model containing the client's creation details.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the creation operation.
    /// Returns <see cref="StatusCodes.Status201Created"/> if successful.
    /// </returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] ClientCreateModel model)
    {
        try
        {
            logger.LogInformation("Starting execution of {ClassName}.{nameof(PostAsync)}", ClassName,
                nameof(PostAsync));

            var validationResult = await createValidator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for {ClassName}.{CreateName}: {Errors}", ClassName, nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await clientBusiness.CreateAsync(model);
            return Created();
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{CreateName}: {EMessage}", ClassName,
                nameof(PostAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(PostAsync)}");
        }
    }
}