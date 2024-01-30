using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.TeacherGroups;

public class TeacherGroupForResultDto
{
    public long Id { get; set; }
    public TeacherForResultDto TeacherForResultDto { get; set; }
    public GroupForResultDto GroupForResultDto { get; set; }
}
