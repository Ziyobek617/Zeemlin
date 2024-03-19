using Zeemlin.Domain.Entities;

namespace Zeemlin.Service.DTOs.Lesson;

public class LessonForCreationDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public long GroupId { get; set; }
    public long TeacherId { get; set; }
}
