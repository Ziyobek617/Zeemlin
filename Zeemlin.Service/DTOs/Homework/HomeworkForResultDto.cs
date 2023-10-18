using Zeemlin.Service.DTOs.Group;

namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForResultDto
{
    public long Id { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long GroupId { get; set; }
    public GroupForResultDto Group { get; set; }
    public ICollection<GradeForResultDto> Grade {  get; set; }

}
