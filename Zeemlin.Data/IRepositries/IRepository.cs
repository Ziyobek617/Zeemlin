using Zeemlin.Domain.Commons;

namespace Zeemlin.Data.IRepositries;

public interface IRepository<TEntity> where TEntity : Auditable
{
    public Task<bool> DeleteAsync(long id);
    public IQueryable<TEntity> SelectAll();
    public Task<TEntity> SelectByIdAsync(long id);
    public Task<TEntity> InsertAsync(TEntity entity);
    public Task<TEntity> UpdateAsync(TEntity entity);
}
