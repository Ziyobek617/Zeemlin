namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForUpdateDto
{
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long GroupId { get; set; }
}
