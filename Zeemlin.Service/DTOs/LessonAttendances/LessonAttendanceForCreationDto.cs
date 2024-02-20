using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForCreationDto
{
    public long LessonId { get; set; }
    public long StudentId { get; set; }
    public string GroupName { get; set; }
    public string TeacherName { get; set; }
    public DateTime Date { get; set; }
    public ScienceType ScienceType { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
