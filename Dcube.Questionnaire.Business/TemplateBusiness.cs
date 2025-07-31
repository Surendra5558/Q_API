using DCube.Questionnaire.Business.Common;
using DCube.Questionnaire.Business.Interface;
using DCube.Questionnaire.Model.ViewModel;
using DCube.Questionnaire.Repository;
using Microsoft.Extensions.Logging;

namespace DCube.Questionnaire.Business;

/// <summary>
/// Provides business operations for managing templates, including retrieval of template information.
/// </summary>
public class TemplateBusiness(ILogger<ClientBusiness> logger, IUserContext userContext, IUnitOfWork unitOfWork)
    : ITemplateBusiness
{
    private const string ClassName = nameof(TemplateBusiness);

    /// <summary>
    /// Retrieves a queryable collection of all templates, including their details and audit information.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains an <see cref="IQueryable{TemplateViewModel}"/>
    /// representing all templates.
    /// </returns>
    public async Task<IQueryable<TemplateViewModel>> GetAsync()
    {
        try
        {
            logger.LogInformation("{ClassName} - GetAsync started", ClassName);

            var result = from t in await unitOfWork.Templates.GetAsync()
                         join uc in await unitOfWork.Users.GetAsync() on t.CreatedBy equals uc.Id
                         join um in await unitOfWork.Users.GetAsync() on t.ModifiedBy equals um.Id
                         select new TemplateViewModel
                         {
                             Id = t.Id,
                             Name = t.Name,
                             CreatedBy = string.Concat(uc.FirstName, " ", uc.LastName),
                             CreatedOn = t.CreatedOn,
                             ModifiedBy = string.Concat(um.FirstName, " ", um.LastName),
                             ModifiedOn = t.ModifiedOn
                         };

            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "{ClassName} - Error in GetAsync", ClassName);
            throw;
        }
        finally
        {
            logger.LogInformation("{ClassName} - GetAsync completed", ClassName);
        }
    }
}