using Zeemlin.Domain.Enums;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.DTOs.GroupRole;

namespace Zeemlin.Service.Interfaces;

public interface IGroupRoleService
{
    Task<bool> RemoveAsync(long id);
    Task<GroupRoleForResultDto> RetrieveByIdAsync(long id);
    Task<GroupRoleForResultDto> CreateAsync(Role chatRole);
    Task<IEnumerable<GroupRoleForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<GroupRoleForResultDto> ModifyAsync(long id, Role chatRole);
}
