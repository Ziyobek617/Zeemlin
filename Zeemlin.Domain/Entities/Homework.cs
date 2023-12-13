using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Homework : Auditable
{
    public string Title { get; set; } // Added
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; } // Added
    public Lesson Lesson { get; set; } // Added
    public ICollection<Grade> Grades { get; set; }
}
