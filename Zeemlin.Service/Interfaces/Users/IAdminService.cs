using Zeemlin.Service.DTOs.Users.Admins;
using Zeemlin.Service.DTOs.Users.SuperAdmins;

namespace Zeemlin.Service.Interfaces.Users;

public interface IAdminService
{
    Task<bool> RemoveAsync(long id);
    Task<AdminForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<AdminForResultDto>> RetrieveAllAsync();
    Task<AdminForResultDto> CreateAsync(AdminForCreationDto dto);
    Task<AdminForResultDto> ModifyAsync(long id, AdminForUpdateDto dto);
}
