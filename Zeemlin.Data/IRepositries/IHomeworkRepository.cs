using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface IHomeworkRepository : IRepository<Homework>
{
    Task<IEnumerable<Homework>> GetSubscribedHomeworksAsync(long Id);
}
