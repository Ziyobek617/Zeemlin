namespace Zeemlin.Service.DTOs.Subjects;

public class SubjectForUpdateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long GroupId { get; set; }
    public long TeacherId { get; set; }
    public long LessonId { get; set; }
}
