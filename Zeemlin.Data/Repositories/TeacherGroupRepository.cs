using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class TeacherGroupRepository : Repository<TeacherGroup>, ITeacherGroupRepository
{
    public TeacherGroupRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
