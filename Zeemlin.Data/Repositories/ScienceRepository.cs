using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class ScienceRepository : Repository<Science>, IScienceRepository
{
    public ScienceRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
