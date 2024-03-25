using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.IRepositries.Users;

public interface IAdminRepository : IRepository<Admin>
{
    Task<bool> ExistsByUsernameAsync(string username);
    Task<string> GetEmailByUsername(string username);
}
