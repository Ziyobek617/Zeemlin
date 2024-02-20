using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Students;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForResultDto
{
    public long Id { get; set; }
    public long LessonId { get; set; }
    public LessonForResultDto LessonForResultDto { get; set; }
    public long StudentId { get; set; }
    public StudentForResultDto StudentForResultDto { get; set; }
    public string GroupName { get; set; }
    public string TeacherName { get; set; }
    public DateTime Date { get; set; }
    public ScienceType ScienceType { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
