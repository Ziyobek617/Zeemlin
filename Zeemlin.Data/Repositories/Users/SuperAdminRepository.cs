using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.Repositories.Users;

public class SuperAdminRepository : Repository<SuperAdmin>, ISuperAdminRepository
{
    public SuperAdminRepository(AppDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<bool> ExistsByUsernameAsync(string username)
    {
        return await _dbContext.SuperAdmins.AnyAsync(a => a.Username == username);
    }

    public async Task<string> GetEmailByUsername(string username)
    {
        var superAdmin = await _dbContext.SuperAdmins
          .Where(u => u.Username == username)
          .Select(u => u.Email) // Select only the Email property
          .FirstOrDefaultAsync();

        return superAdmin; // Can be null if not found
    }

    public async Task<IDictionary<long, string>> GetAllUsernamesByIds(IEnumerable<long> superAdminIds)
    {
        var usernames = await _dbContext.SuperAdmins
          .Where(u => superAdminIds.Contains(u.Id))
          .ToDictionaryAsync(u => u.Id, u => u.Username);

        return usernames;
    }
}
