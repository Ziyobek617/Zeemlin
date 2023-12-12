using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class GroupPermissionRepository : Repository<GroupPermission>, IGroupPermissionRepository
{
    public GroupPermissionRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
