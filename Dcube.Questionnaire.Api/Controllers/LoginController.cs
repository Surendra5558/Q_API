using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Model.Authentication;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DCube.Questionnaire.Api.Controllers;

/// <summary>
/// Controller for Login
/// </summary>
/// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
[Route("v1/[controller]")]
[ApiController]
[AllowAnonymous]
public class LoginController(ILogger<LoginController> logger, IValidator<TokenRequest> validator, IConfiguration configuration,
    IUserLoginBusiness userLoginBusiness)
    : ControllerBase
{
    private const string ClassName = nameof(LoginController);

    /// <summary>
    /// Posts the specified login.
    /// </summary>
    /// <param name="login">The login.</param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TokenResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] TokenRequest login)
    {
        try
        {
            logger.LogInformation($"Starting execution of {ClassName}.{nameof(PostAsync)}");

            var result = await validator.ValidateAsync(login);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            var response = await userLoginBusiness.ValidateUserAsync(login);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sid, response.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, response.Name),
                new Claim(JwtRegisteredClaimNames.Email, response.Email),
                new Claim("RoleId",response.RoleId.ToString()),
                new Claim("Role",response.RoleName),
                new Claim("ClientId",response.ClientId.ToString()),
                new Claim("Client",response.ClientName),
            };

            _ = double.TryParse(configuration["Tokens:AccessTokenExpiryInMinutes"], out var expireMinutes);
            var issuer = configuration["Tokens:Issuer"]!;
            var audience = configuration["Tokens:Audience"]!;
            var key = configuration["Tokens:Key"]!;

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(expireMinutes),
                signingCredentials: signinCredentials);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

            var tokenResponse = new TokenResponse
            {
                Name = response.Name,
                Token = tokenString,
                RoleId = response.RoleId
            };

            return Ok(tokenResponse);
        }
        catch (Exception e)
        {
            logger.LogError($"Error in {ClassName}.{nameof(PostAsync)}: {e.Message}", e);
            return StatusCode(402, e.Message);
        }
        finally
        {
            logger.LogInformation($"Ending execution of {ClassName}.{nameof(PostAsync)}");
        }
    }
}