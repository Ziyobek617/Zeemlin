namespace Zeemlin.Service.DTOs.Grade;

public class GradeForUpdateDto
{
    public long UserId { get; set; }
    public long LessonId { get; set; }
    public int Value { get; set; }
}
