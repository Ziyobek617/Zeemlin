using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class LessonAttendance : Auditable
{
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DateTime DateTime { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
