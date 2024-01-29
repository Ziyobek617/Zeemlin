using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class StudentGroupRepository : Repository<StudentGroup>, IStudentGroupRepository
{
    public StudentGroupRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
