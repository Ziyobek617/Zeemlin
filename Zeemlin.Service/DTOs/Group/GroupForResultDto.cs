using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.DTOs.Group;

public class GroupForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long HeadTeacherId { get; set; }
    public long SchoolId { get; set; }
    public StudentGroupForResultDto Student { get; set; }
    public TeacherGroupForResultDto TeacherGroup { get; set; }
}
