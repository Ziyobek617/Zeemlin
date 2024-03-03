using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Students;

namespace Zeemlin.Service.DTOs.Grade;

public class GradeForResultDto
{
    public long Id { get; set; }
    public long StudentId { get; set; }
    public StudentForResultDto Student { get; set; }
    public long LessonId { get; set; }
    public LessonForResultDto Lesson { get; set; }
    public int Value { get; set; }
}
