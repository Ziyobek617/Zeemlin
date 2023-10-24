using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Course>> GetSubscribedCoursesAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
