namespace Zeemlin.Service.DTOs.Homework;

public class HomeworkForUpdateDto
{
    public long Id { get; set; }
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long GroupId { get; set; }
}
