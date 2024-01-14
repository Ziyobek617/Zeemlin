using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.Interfaces;

public interface ISchoolService
{
    Task<SchoolForResultDto> AddAsync(SchoolForCreationDto schoolDto);
    Task<SchoolForResultDto> ModifyAsync(long id, SchoolForUpdateDto schoolDto);
    Task<bool> RemoveAsync(long id);
    Task<IEnumerable<SchoolForResultDto>> RetrieveAllAsync();
    Task<SchoolForResultDto> RetrieveByIdAsync(long id);
    // Consider adding other methods as needed (e.g., search, filtering)
    // Later search and Filter
}
