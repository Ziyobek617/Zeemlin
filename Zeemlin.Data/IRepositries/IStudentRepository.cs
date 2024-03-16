using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IStudentRepository : IRepository<Student>
{
    Task<bool> ExistsAsync(string studentUniqueId);
}
