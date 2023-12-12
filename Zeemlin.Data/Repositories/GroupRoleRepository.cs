using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class GroupRoleRepository : Repository<GroupRole>, IGroupRoleRepository
{
    public GroupRoleRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
