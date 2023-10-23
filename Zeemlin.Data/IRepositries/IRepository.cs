using Zeemlin.Domain.Commons;

namespace Zeemlin.Data.IRepositries;

public interface IRepository<TEntity> where TEntity : Auditable
{
    Task<bool> DeleteAsync(long id);
    IQueryable<TEntity> SelectAll();
    Task<TEntity> SelectByIdAsync(long id);
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}
