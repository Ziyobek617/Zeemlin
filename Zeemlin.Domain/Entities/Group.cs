using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Group : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public ICollection<StudentGroup> StudentGroups { get; set; }
}
