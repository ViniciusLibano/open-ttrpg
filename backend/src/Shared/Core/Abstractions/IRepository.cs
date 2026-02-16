using System.Linq.Expressions;

namespace OpenTTRPG.Core.Abstractions;

public interface IRepository<TEntity>
{
    ValueTask<TEntity?> GetByIdAsync(params object?[]? key);
    Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate);
    void Update(TEntity entity);
    void Add(TEntity entity);
}