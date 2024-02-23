using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.Repositories.Users;

public class DirectorRepository : Repository<Director>, IDirectorRepository
{
    public DirectorRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
