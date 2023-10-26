using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class GroupPermission : Auditable
{
    public GroupPermissionType PermissionType { get; set; }
}
