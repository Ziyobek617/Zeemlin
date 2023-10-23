using Zeemlin.Service.DTOs.UserGroup;

namespace Zeemlin.Service.Interfaces;

public interface IUserGroupService
{
    public Task<bool> RemoveAsync(long id);
    public Task<UserGroupForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<UserGroupForResultDto>> RetrieveAllAsync();
    public Task<UserGroupForResultDto> ModifyAsync(long id, UserGroupForUpdateDto dto);
    public Task<UserGroupForResultDto> CreateAsync(UserGroupForCreationDto dto);
}
