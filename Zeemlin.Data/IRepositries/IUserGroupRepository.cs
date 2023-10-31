using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IUserGroupRepository : IRepository<UserGroup>
{
    Task<IEnumerable<UserGroup>> GetSubscribedUserGroupsAsync(long Id);
}
