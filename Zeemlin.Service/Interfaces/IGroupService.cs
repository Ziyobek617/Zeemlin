using Zeemlin.Service.DTOs.Group;

namespace Zeemlin.Service.Interfaces;

public interface IGroupService
{
    public Task<bool> RemoveAsync(long id);
    public Task<GroupForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<GroupForResultDto>> RetrieveAllAsync();
    public Task<GroupForResultDto> UpdateAsync(GroupForUpdateDto dto);
    public Task<GroupForResultDto> CreateAsync(GroupForCreationDto dto);
}
