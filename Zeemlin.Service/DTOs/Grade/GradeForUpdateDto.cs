namespace Zeemlin.Service.DTOs.Grade;

public class GradeForUpdateDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long HomeworkId { get; set; }
    public int Value { get; set; }
}
