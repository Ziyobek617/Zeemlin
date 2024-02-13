using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Course : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long SchoolId { get; set; }
    public School School { get; set; }


    public ICollection<Group> Groups { get; set; }

}
