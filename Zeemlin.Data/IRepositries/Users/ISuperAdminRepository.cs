using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.IRepositries.Users;

public interface ISuperAdminRepository : IRepository<SuperAdmin>
{
    Task<bool> ExistsByUsernameAsync(string username);
    Task<string> GetEmailByUsername(string username);
    Task<IDictionary<long, string>> GetAllUsernamesByIds(IEnumerable<long> superAdminIds);
}
