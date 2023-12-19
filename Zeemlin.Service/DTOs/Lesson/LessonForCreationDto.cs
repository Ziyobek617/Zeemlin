namespace Zeemlin.Service.DTOs.Lesson;

public class LessonForCreationDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public long GroupId { get; set; }
}
