using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Group : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
    public Student User { get; set; }
    public long CourseId { get; set; }
    public Course Course { get; set; }
    public ICollection<StudentGroup> UserGroups { get; set; }
}
