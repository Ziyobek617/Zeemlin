using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Course : Auditable
{
    public string Name { get; set; }
    public ICollection<Group> Group { get; set; }
}
