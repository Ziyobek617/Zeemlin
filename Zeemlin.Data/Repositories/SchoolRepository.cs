using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.Repositories;

public class SchoolRepository : Repository<School>, ISchoolRepository
{
    public SchoolRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> ExistsAsync(long schoolNumber)
    {
        return await _dbContext.School.AnyAsync(s => s.SchoolNumber == schoolNumber);
    }
}
