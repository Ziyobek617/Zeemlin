using Zeemlin.Domain.Enums;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.DTOs.GroupPermissions;

namespace Zeemlin.Service.Interfaces;

public interface IGroupPermissionService
{
    Task<bool> RemoveAsync(long id);
    Task<GroupPermissionForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<GroupPermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<GroupPermissionForResultDto> CreateAsync(GroupPermissionType type);
    Task<GroupPermissionForResultDto> ModifyAsync(long id, GroupPermissionType type);
}
