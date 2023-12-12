using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class GroupRolePermission : Auditable
{
    public long RoleId { get; set; }
    public GroupRole Role { get; set; }

    public long PermissionId { get; set; }
    public GroupPermission Permission { get; set; }
}
