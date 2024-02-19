namespace Zeemlin.Service.DTOs.Grade;

public class GradeForCreationDto
{
    public long UserId { get; set; }
    public long GroupId { get; set; }
    public long LessonId { get; set; }
    public long HomeworkId { get; set; }
    public int Value { get; set; }
}
