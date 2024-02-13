using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Course>> GetAllAsync()
    {
        return await _dbContext.Courses
            .Include(c => c.Groups) // Eagerly load related groups
            .ToListAsync();
    }

    public async Task<int> GetGroupCountAsync(long courseId)
    {
        // Optimized to directly count groups associated with a specific course
        return await _dbContext.Courses.Where(c => c.Id == courseId).SelectMany(c => c.Groups).CountAsync();
    }
}
