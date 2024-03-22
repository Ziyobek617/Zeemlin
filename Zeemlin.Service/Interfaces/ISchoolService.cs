using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.Interfaces;

public interface ISchoolService
{
    Task<bool> RemoveAsync(long id);
    Task<SchoolForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<SchoolForResultDto>> RetrieveAllAsync();
    Task<SchoolForResultDto> AddAsync(SchoolForCreationDto schoolDto);
    Task<IEnumerable<SchoolForResultDto>> FilterByRegionAsync(Region region);
    Task<SchoolForResultDto> ModifyAsync(long id, SchoolForUpdateDto schoolDto);
}
