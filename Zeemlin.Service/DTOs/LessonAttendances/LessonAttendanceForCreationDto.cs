using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForCreationDto
{
    public long LessonId { get; set; }
    public long UserId { get; set; }
    public DateTime Date { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
