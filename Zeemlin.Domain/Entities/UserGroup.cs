using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Domain.Entities;

public class UserGroup : Auditable
{
    public long UserId { get; set; }
    public User Users { get; set; }

    public long GroupId { get; set; }
    public Group Group { get; set; }
}
