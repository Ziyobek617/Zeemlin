using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Subject : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
}
