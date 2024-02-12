using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class LessonAttendance : Auditable
{
    public long ScienceId { get; set; }
    public Science Science { get; set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }
    public DateTime DateTime { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
