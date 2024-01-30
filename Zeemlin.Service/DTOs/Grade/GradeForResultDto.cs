using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Homework;

namespace Zeemlin.Service.DTOs.Grade;

public class GradeForResultDto
{
    public long Id { get; set; }
    public long GroupId { get; set; }
    public GroupForResultDto Group { get; set; }
    public long HomeworkId { get; set; }
    public HomeworkForResultDto Homework { get; set; }
    public int Value { get; set; }
}
