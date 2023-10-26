using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IGroupRepository : IRepository<Group>
{
    Task<IEnumerable<Group>> GetSubscribedGroupsAsync(long Id);
}
