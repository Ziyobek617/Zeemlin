using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Users.SuperAdmins;

namespace Zeemlin.Service.Interfaces.Users;

public interface ISuperAdminService
{
    Task<bool> RemoveAsync(long id);
    Task<SuperAdminForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<SuperAdminForResultDto>> RetrieveAllAsync();
    Task<SuperAdminForResultDto> CreateAsync(SuperAdminForCreationDto dto);
    Task<SuperAdminForResultDto> ModifyAsync(long id, SuperAdminForUpdateDto dto);
}
