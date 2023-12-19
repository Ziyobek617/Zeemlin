using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class LessonAttendanceRepository : Repository<LessonAttendance>, ILessonAttendanceRepository
{
    public LessonAttendanceRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<LessonAttendance>> GetSubscribedLessonAttendanceAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
