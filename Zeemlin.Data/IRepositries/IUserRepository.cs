using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IUserRepository : IRepository<Student>
{
    Task<IEnumerable<Student>> GetSubscribedUsersAsync(long Id);
}
