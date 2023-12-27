using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IUserGroupRepository : IRepository<StudentGroup>
{
    Task<IEnumerable<StudentGroup>> GetSubscribedUserGroupsAsync(long Id);
}
