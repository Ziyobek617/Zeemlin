using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
    private readonly DbSet<Student> _students; // Add this line

    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
        _students = dbContext.Students; // Initialize _students here
    }

    public async Task<bool> ExistsAsync(string studentUniqueId)
    {
        return await _students.AnyAsync(s => s.StudentUniqueId == studentUniqueId);
    }
}

