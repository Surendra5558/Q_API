namespace DCube.Questionnaire.Repository.Common.Interface;

/// <summary>
/// Interface for Base Repositories
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
/// <typeparam name="TContext"></typeparam>
public interface IRepository<out TContext, TEntity>
{
    /// <summary>
    /// Gets the context.
    /// </summary>
    /// <value>
    /// The context.
    /// </value>
    public TContext Context { get; }

    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <returns></returns>
    Task<IQueryable<TEntity>> GetAsync();

    /// <summary>
    /// Gets the by identifier asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    Task<TEntity?> GetByIdAsync(long id);

    /// <summary>
    /// Adds the asynchronous.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    Task<TEntity> AddAsync(TEntity entity);

    /// <summary>
    /// Update the range asynchronous.
    /// </summary>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entities);

    /// <summary>
    /// Adds the range asynchronous.
    /// </summary>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    Task<List<TEntity>> AddRangeAsync(List<TEntity> entities);

    /// <summary>
    /// Updates the asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    Task<TEntity> UpdateAsync(long id, TEntity entity);

    /// <summary>
    /// Deletes the asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    Task<TEntity?> DeleteAsync(long id);
}