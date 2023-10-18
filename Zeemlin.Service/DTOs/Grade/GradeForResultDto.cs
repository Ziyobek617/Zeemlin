using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.DTOs.Grade;

public class GradeForResultDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public UserForResultDto User { get; set; }
    public long HomeworkId { get; set; }
    public HomeworkForResultDto Homework { get; set; }
    public int Value { get; set; }
}
