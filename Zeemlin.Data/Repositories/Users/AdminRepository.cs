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
}
