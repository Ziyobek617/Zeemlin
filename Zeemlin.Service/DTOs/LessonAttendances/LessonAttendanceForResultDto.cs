using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceForResultDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public UserForResultDto User { get; set; }
    public long LessonId { get; set; }
    public LessonForResultDto LessonForResultDto { get; set; }
    public DateTime Date { get; set; }
    public LessonAttendanceType LessonAttendanceType { get; set; }
}
