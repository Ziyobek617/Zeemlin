using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Homework : Auditable
{
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public ICollection<Grade> Grades { get; set; }
}
