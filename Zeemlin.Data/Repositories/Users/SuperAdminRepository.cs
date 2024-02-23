using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.Repositories.Users;

public class SuperAdminRepository : Repository<SuperAdmin>, ISuperAdminRepository
{
    public SuperAdminRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
