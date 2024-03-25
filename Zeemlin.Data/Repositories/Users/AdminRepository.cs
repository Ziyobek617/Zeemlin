using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.Repositories.Users;

public class AdminRepository : Repository<Admin>, IAdminRepository
{
    public AdminRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsByUsernameAsync(string username)
    {
        return await _dbContext.Admins.AnyAsync(a => a.Username == username);
    }

    public async Task<string> GetEmailByUsername(string username)
    {
        var Admin = await _dbContext.Admins
          .Where(u => u.Username == username)
          .Select(u => u.Email) // Select only the Email property
          .FirstOrDefaultAsync();

        return Admin; // Can be null if not found
    }
}
