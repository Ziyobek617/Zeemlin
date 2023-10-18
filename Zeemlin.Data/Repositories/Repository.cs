using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    private readonly AppDbContext dbContext;
    private readonly DbSet<TEntity> dbSet;

    public Repository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        this.dbSet = this.dbContext.Set<TEntity>();
    }
    public async Task<bool> DeleteAsync(long Id)
    {
        var entity = await dbSet.FirstOrDefaultAsync(x => x.Id == Id);
        dbSet.Remove(entity);
        return true;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var model = (await this.dbSet.AddAsync(entity)).Entity;
        return model;
    }

    public async Task<bool> SaveAsync()
    {
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public IQueryable<TEntity> SelectAll()
    {
        return this.dbSet;
    }
    public async Task<TEntity> SelectByIdAsync(long Id)
    {
        var entity = await this.dbSet.FirstOrDefaultAsync(u => u.Id == Id);
        return entity;
    }
    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var model = this.dbSet.Update(entity);
        return model.Entity;
    }
}
