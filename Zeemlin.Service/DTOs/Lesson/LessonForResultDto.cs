
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.LessonAttendances;

namespace Zeemlin.Service.DTOs.Lesson;

public class LessonForResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public long GroupId { get; set; }
    public GroupForResultDto Group { get; set; }
    public ICollection<GradeForResultDto> GradeForResultDtos { get; set; }
    public ICollection<LessonAttendanceForResultDto> lessonAttendanceForResultDtos { get; set; }
}
