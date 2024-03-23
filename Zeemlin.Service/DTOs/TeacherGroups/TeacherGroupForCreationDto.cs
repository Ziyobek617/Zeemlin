using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.TeacherGroups;

public class TeacherGroupForCreationDto
{
    public long TeacherId { get; set; }
    public long GroupId { get; set; }
    public TeacherRole Role { get; set; }

}
