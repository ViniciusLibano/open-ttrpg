using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OpenTTRPG.Core.Abstractions;

namespace OpenTTRPG.Infrastructure.Database;

public abstract class RepositoryBase<TEntity>(DbContext context) : IRepository<TEntity> 
    where TEntity : class
{
    protected DbSet<TEntity> DbSet = context.Set<TEntity>();

    public virtual ValueTask<TEntity?> GetByIdAsync(params object?[]? key) => DbSet.FindAsync(key);

    public virtual Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate) =>
        DbSet.AsNoTracking()
            .Where(predicate)
            .ToListAsync<TEntity>();

    public virtual void Update(TEntity entity) => DbSet.Update(entity);

    public virtual void Add(TEntity entity) => DbSet.Add(entity);
}