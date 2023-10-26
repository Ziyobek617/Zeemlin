using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class GroupRepository : Repository<Group>, IGroupRepository
{
    public GroupRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Group>> GetSubscribedGroupsAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
