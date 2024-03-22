using Zeemlin.Service.DTOs.Group;

namespace Zeemlin.Service.Interfaces;

public interface IGroupService
{
    public Task<bool> RemoveAsync(long id);
    public Task<GroupForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<GroupForResultDto>> RetrieveAllAsync();
    public Task<GroupForResultDto> CreateAsync(GroupForCreationDto dto);
    Task<IEnumerable<GroupDataResultDto>> SearchGroupsAsync(string searchTerm);
    public Task<GroupForResultDto> ModifyAsync(long id, GroupForUpdateDto dto);
    
}
