using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Grade : Auditable
{
    public long UserId { get; set; }
    public Student Student { get; set; } // One-to-many relationship
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; } // One-to-many relationship
    public DateTime DateTimeCreated { get; set; }
    public AssessmentType AssessmentType { get; set; }
    public int Value { get; set; }
}
