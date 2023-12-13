using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Group;

namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; }
    public LessonForResult Lesson { get; set; }
    public ICollection<GradeForResultDto> Grade {  get; set; }

}
