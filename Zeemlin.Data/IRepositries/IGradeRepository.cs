using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IGradeRepository : IRepository<Grade>
{
    Task<IEnumerable<Grade>> GetSubscribedGradesAsync(long Id);
}
