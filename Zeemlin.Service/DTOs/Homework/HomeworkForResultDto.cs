using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Sciences;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForResultDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; }
    public LessonForResultDto Lesson { get; set; }
    public long ScienceId { get; set; }
    public ScienceForResultDto Science { get; set; }
    public long TeacherId { get; set; }
    public TeacherForResultDto Teacher { get; set; }
    public ICollection<GradeForResultDto> Grade {  get; set; }

}
