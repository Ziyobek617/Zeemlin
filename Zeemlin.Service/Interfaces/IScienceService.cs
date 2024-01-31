using Zeemlin.Service.DTOs.Sciences;

namespace Zeemlin.Service.Interfaces;

public interface IScienceService
{
    Task<bool> RemoveAsync(long id);
    Task<ScienceForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<ScienceForResultDto>> RetrieveAllAsync();
    Task<ScienceForResultDto> AddAsync(ScienceForCreationDto dto);
    Task<ScienceForResultDto> ModifyAsync(long id, ScienceForUpdateDto dto);
}
