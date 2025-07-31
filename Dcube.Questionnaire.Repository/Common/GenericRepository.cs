using DCube.Questionnaire.Repository.Common.Domain;
using DCube.Questionnaire.Repository.Common.Interface;
using Microsoft.EntityFrameworkCore;

namespace DCube.Questionnaire.Repository.Common;

/// <summary>
/// Generic repository for performing CRUD operations on entities of type <typeparamref name="TEntity"/> within a specified <typeparamref name="TContext"/>.
/// </summary>
/// <typeparam name="TContext">The type of the context.</typeparam>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
/// <seealso cref="Interface.IRepository&lt;TContext, TEntity&gt;" />
public class GenericRepository<TContext, TEntity>(TContext context) : IRepository<TContext, TEntity>
    where TEntity : BaseDomain
    where TContext : DbContext
{
    private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    public TContext Context { get; set; } = context;

    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    public virtual async Task<IQueryable<TEntity>> GetAsync()
    {
        return await Task.FromResult(_dbSet.AsNoTracking());
    }

    /// <summary>
    /// Gets the by identifier asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Record not found</exception>
    public virtual async Task<TEntity?> GetByIdAsync(long id)
    {
        var result = await _dbSet.FindAsync(id);
        return result ?? throw new ArgumentException("Record not found");
    }

    /// <summary>
    /// Adds the asynchronous.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        Context.Entry(entity).State = EntityState.Added;
        return await Task.FromResult(entity);
    }

    /// <summary>
    /// Update the asynchronous.
    /// </summary>
    /// <param name="entities">The entity.</param>
    /// <returns></returns>
    public virtual async Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entities)
    {
        _dbSet.UpdateRange(entities);
        return await Task.FromResult(entities.ToList());
    }

    /// <summary>
    /// Adds the range asynchronous.
    /// </summary>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    public virtual async Task<List<TEntity>> AddRangeAsync(List<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
        return await Task.FromResult(entities.ToList());
    }

    /// <summary>
    /// Updates the asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    public async Task<TEntity> UpdateAsync(long id, TEntity entity)
    {
        _dbSet.Update(entity);
        Context.Entry(entity).State = EntityState.Modified;
        return await Task.FromResult(entity);
    }

    /// <summary>
    /// Deletes the asynchronous.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public async Task<TEntity?> DeleteAsync(long id)
    {
        var entity = await GetByIdAsync(id);
        _dbSet.Update(entity!);
        Context.Entry(entity!).State = EntityState.Modified;
        return await Task.FromResult(entity);
    }
}