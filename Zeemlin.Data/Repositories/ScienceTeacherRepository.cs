using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class ScienceTeacherRepository : Repository<ScienceTeacher>, IScienceTeacherRepository
{
    public ScienceTeacherRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
