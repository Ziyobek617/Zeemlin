using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface ILessonAttendanceRepository : IRepository<LessonAttendance>
{
    Task<IEnumerable<LessonAttendance>> GetSubscribedLessonAttendanceAsync(long Id);
}
