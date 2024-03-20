using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForUpdateDto
{
    public long LessonId { get; set; }
    public long StudentId { get; set; }
    public DateTime Date { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
