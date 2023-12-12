using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.GroupPermissions;

public class GroupPermissionForResultDto
{
    public long Id { get; set; }
    public GroupPermissionType Type { get; set; }
}
