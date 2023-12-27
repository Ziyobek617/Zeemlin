using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class UserRepository : Repository<Student>, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Student>> GetSubscribedUsersAsync(long Id)
    {
        throw new NotImplementedException();
    }
}
