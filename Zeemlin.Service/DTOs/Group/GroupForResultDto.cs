using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.DTOs.Group;

public class GroupForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long CourseId { get; set; }
    public ICollection<UserForResultDto> Users { get; set; }
}
