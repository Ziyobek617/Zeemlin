using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class GroupRole : Auditable
{
    public Role Role { get; set; }
}
