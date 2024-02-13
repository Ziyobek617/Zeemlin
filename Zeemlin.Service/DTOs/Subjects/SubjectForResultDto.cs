using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.Subjects;

public class SubjectForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public GroupForResultDto Group { get; set; }
    public TeacherForResultDto Teacher { get; set; }
    public LessonForResultDto Lesson { get; set; }
}
