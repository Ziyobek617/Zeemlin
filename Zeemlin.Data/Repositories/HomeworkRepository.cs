using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class HomeworkRepository : Repository<Homework>, IHomeworkRepository
{
    public HomeworkRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Homework>> GetSubscribedHomeworksAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
