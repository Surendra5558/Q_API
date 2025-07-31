using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Repository.Common.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.JsonWebTokens;

namespace DCube.Questionnaire.Business.Common;

/// <summary>
/// Provides user context information and utilities for the current HTTP request.
/// Extracts user claims and applies domain defaults based on user and operation mode.
/// </summary>
public class UserContext : IUserContext
{
    private const string ClassName = nameof(UserContext);

    private readonly ILogger<UserContext> _logger;
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly UserContextValue _userContext;

    public UserContextValue UserContextValue { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserContext"/> class.
    /// Extracts user information from the current HTTP context claims.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="contextAccessor">The HTTP context accessor.</param>
    public UserContext(ILogger<UserContext> logger, IHttpContextAccessor contextAccessor)
    {
        _logger = logger;
        _contextAccessor = contextAccessor;
        _userContext = new UserContextValue();
        if (contextAccessor.HttpContext?.User is { } claimsPrincipal)
        {
            _userContext.EmployeeId = long.Parse(claimsPrincipal.FindFirst(JwtRegisteredClaimNames.Sid)?.Value!);
            _userContext.EmployeeName = claimsPrincipal.FindFirst(JwtRegisteredClaimNames.Name)?.Value ?? string.Empty;
            _userContext.EmployeeEmail = claimsPrincipal
                .FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value ?? string.Empty;
            _userContext.RoleId = long.Parse(claimsPrincipal.FindFirst("RoleId")?.Value!);
            _userContext.RoleName = claimsPrincipal.FindFirst("Role")?.Value ?? string.Empty;
            _userContext.ClientId = long.Parse(claimsPrincipal.FindFirst("ClientId")?.Value!);
            _userContext.ClientName = claimsPrincipal.FindFirst("Client")?.Value ?? string.Empty;

            UserContextValue = _userContext;
        }
    }

    /// <summary>
    /// Sets domain entity default values based on the current user context and the specified data mode.
    /// </summary>
    /// <typeparam name="T">The type of the domain entity, derived from <see cref="BaseDomain"/>.</typeparam>
    /// <param name="domains">The domain entity to update.</param>
    /// <param name="dataModes">The operation mode (Add, Edit, Delete, DeActive).</param>
    public void SetDomainDefaults<T>(List<T> domains, DataModes dataModes) where T : BaseDomain
    {
        _logger.LogInformation("{ClassName} - GetUserContext called", ClassName);
        foreach (var domain in domains)
        {
            switch (dataModes)
            {
                case DataModes.Add:
                    domain.CreatedBy = _userContext.EmployeeId;
                    domain.CreatedOn = DateTime.UtcNow;
                    domain.IsActive = true;
                    domain.IsDeleted = false;
                    break;

                case DataModes.Delete:
                    domain.IsActive = false;
                    domain.IsDeleted = true;
                    break;

                case DataModes.DeActive:
                    domain.IsActive = false;
                    break;
            }

            domain.ModifiedBy = _userContext.EmployeeId;
            domain.ModifiedOn = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Sets domain entity default values based on the current user context and the specified data mode.
    /// </summary>
    /// <typeparam name="T">The type of the domain entity, derived from <see cref="BaseDomain"/>.</typeparam>
    /// <param name="domain">The domain entity to update.</param>
    /// <param name="dataModes">The operation mode (Add, Edit, Delete, DeActive).</param>
    public void SetDomainDefaults<T>(T domain, DataModes dataModes) where T : BaseDomain
    {
        _logger.LogInformation("{ClassName} - GetUserContext called", ClassName);

        switch (dataModes)
        {
            case DataModes.Add:
                domain.CreatedBy = _userContext.EmployeeId;
                domain.CreatedOn = DateTime.UtcNow;
                domain.IsActive = true;
                domain.IsDeleted = false;
                break;

            case DataModes.Delete:
                domain.IsActive = false;
                domain.IsDeleted = true;
                break;

            case DataModes.DeActive:
                domain.IsActive = false;
                break;
        }

        domain.ModifiedBy = _userContext.EmployeeId;
        domain.ModifiedOn = DateTime.UtcNow;
    }
}