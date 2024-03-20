using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForCreationDto
{
    public long LessonId { get; set; }
    public long StudentId { get; set; }
    public DateTime Date { get; set; }
}
