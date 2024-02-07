namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForUpdateDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; }
    public long ScienceId { get; set; }
    public long TeacherId { get; set; }
}
