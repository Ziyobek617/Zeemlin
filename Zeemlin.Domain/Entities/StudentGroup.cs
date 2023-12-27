using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Domain.Entities;

public class StudentGroup : Auditable
{
    public long UserId { get; set; }
    public Student Users { get; set; }

    public long GroupId { get; set; }
    public Group Group { get; set; }
}
