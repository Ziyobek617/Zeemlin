using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface ICourseRepository : IRepository<Course>
{
    Task<IEnumerable<Course>> GetSubscribedCoursesAsync(long Id);
}
