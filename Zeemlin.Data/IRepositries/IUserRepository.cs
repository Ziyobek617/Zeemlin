using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IUserRepository : IRepository<User>
{
    Task<IEnumerable<User>> GetSubscribedUsersAsync(long Id);
}
