using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.Interfaces;

public interface IAuthService
{
    Task<LoginForResult> AuthenticateAsync(LoginDto login);
}
