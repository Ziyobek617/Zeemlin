using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class UserGroupRepository : Repository<UserGroup>, IUserGroupRepository
{
    public UserGroupRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<UserGroup>> GetSubscribedUserGroupsAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
