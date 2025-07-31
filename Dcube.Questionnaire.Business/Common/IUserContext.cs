using DCube.Questionnaire.Model.Authentication;
using DCube.Questionnaire.Repository.Common.Domain;

namespace DCube.Questionnaire.Business.Common;

/// <summary>
/// Provides user context operations for domain entities, such as setting default values
/// based on the current user and the specified data operation mode.
/// </summary>
public interface IUserContext
{
    public UserContextValue UserContextValue { get; set; }

    /// <summary>
    /// Sets default values on the specified domain entity according to the current user context
    /// and the provided <paramref name="dataModes"/> operation.
    /// </summary>
    /// <typeparam name="T">The type of the domain entity, derived from <see cref="BaseDomain"/>.</typeparam>
    /// <param name="domain">The domain entity to update.</param>
    /// <param name="dataModes">The data operation mode (e.g., Add, Edit, Delete, DeActive).</param>
    void SetDomainDefaults<T>(T domain, DataModes dataModes) where T : BaseDomain;

    /// <summary>
    /// Sets the domain defaults.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="domains">The domains.</param>
    /// <param name="dataModes">The data modes.</param>
    public void SetDomainDefaults<T>(List<T> domains, DataModes dataModes) where T : BaseDomain;
}