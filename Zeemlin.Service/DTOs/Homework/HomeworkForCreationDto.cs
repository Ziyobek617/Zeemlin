namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForCreationDto
{
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long GroupId { get; set; }
}
