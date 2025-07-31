using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.SaveModel;
using DCube.Questionnaire.Model.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// API controller for managing users, including retrieval and creation operations.
/// </summary>
public class UserController(ILogger<UserController> logger, IValidator<UserCreateModel> createValidator,
    IUserBusiness userBusiness) : ODataController
{
    private const string ClassName = nameof(UserController);

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    /// <returns>
    /// An <see cref="IActionResult"/> containing a queryable collection of <see cref="UserViewModel"/> if successful;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet]
    [EnableQuery]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IQueryable<UserViewModel>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetAsync()
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(GetAsync)}");

            var response = await userBusiness.GetAsync();
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
    /// Retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the <see cref="UserViewModel"/> if found;
    /// otherwise, a corresponding error response.
    /// </returns>
    [HttpGet("v1/[controller]/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserViewModel))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetByIdAsync(long id)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(GetByIdAsync)}");

            var response = await userBusiness.GetByIdAsync(id);
            return Ok(response);
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{GetByIdAsync}: {EMessage}", ClassName,
                nameof(GetByIdAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(GetByIdAsync)}");
        }
    }

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="model">The <see cref="UserCreateModel"/> containing the user's creation details.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> indicating the result of the creation operation.
    /// Returns <see cref="StatusCodes.Status201Created"/> if successful.
    /// </returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] UserCreateModel model)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(PostAsync)}");

            var validationResult = await createValidator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                logger.LogError("Validation failed for {ClassName}.{PostAsync}: {Errors}", ClassName,
                    nameof(PostAsync), validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }
            var response = await userBusiness.CreateAsync(model);

            return Created();
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred in {ClassName}.{CreateAsync}: {EMessage}", ClassName,
                nameof(PostAsync), e.Message);
            return StatusCode(500, e.Message);
        }
        finally
        {
            logger.LogInformation($"Finished execution of {ClassName}.{nameof(PostAsync)}");
        }
    }
}