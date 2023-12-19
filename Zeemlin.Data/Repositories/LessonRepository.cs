using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class LessonRepository : Repository<Lesson>, ILessonRepository
{
    public LessonRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Lesson>> GetSubscribedLessonsAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
