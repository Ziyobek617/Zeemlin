using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class GradeRepository : Repository<Grade>, IGradeRepository
{
    public GradeRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Grade>> GetSubscribedGradesAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
