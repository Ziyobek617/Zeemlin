using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Lesson : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public ICollection<Grade> Grades { get; set;}
    public ICollection<LessonAttendance> LessonAttendances { get;set;}
}
