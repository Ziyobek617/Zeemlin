using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
