using Zeemlin.Service.DTOs.Group;

namespace Zeemlin.Service.DTOs.Course;

public class CourseForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<GroupForResultDto> Groups { get; set; }
}
