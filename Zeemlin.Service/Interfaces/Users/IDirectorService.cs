using Zeemlin.Service.DTOs.Users.Admins;
using Zeemlin.Service.DTOs.Users.Directors;

namespace Zeemlin.Service.Interfaces.Users;

public interface IDirectorService
{
    Task<bool> RemoveAsync(long id);
    Task<DirectorForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<DirectorForResultDto>> RetrieveAllAsync();
    Task<DirectorForResultDto> CreateAsync(DirectorForCreationDto dto);
    Task<DirectorForResultDto> ModifyAsync(long id, DirectorForUpdateDto dto);
}
