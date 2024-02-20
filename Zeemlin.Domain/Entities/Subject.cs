using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Subject : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set;}
    public long LessonId { get; set; }

}
