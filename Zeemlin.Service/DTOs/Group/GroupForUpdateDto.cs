namespace Zeemlin.Service.DTOs.Group;

public class GroupForUpdateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long HeadTeacherId { get; set; }
    public long SchoolId { get; set; }
}
