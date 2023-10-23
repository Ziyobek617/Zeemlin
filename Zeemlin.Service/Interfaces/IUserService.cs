using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.Interfaces;

public interface IUserService
{
    public Task<bool> RemoveAsync(long id);
    public Task<UserForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
    public Task<UserForResultDto> AddAsync(UserForCreationDto dto);
    public Task<UserForResultDto> RetrieveByEmailAsync(string email);
    public Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
}