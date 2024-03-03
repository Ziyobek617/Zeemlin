namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForCreationDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; }
}
