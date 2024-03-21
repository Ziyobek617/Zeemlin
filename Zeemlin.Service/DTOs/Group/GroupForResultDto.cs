using Zeemlin.Service.DTOs.Courses;
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.DTOs.Group;

public class GroupForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long CourseId { get; set; }
    public CourseForResultDto Course { get; set; }


    public ICollection<StudentGroupForResultDto> Student { get; set; }
    public ICollection<TeacherGroupForResultDto> TeacherGroup { get; set; }
}
