using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Events;
using Zeemlin.Domain.Entities.Events;

namespace Zeemlin.Data.Repositories.Events;

public class EventRepository : Repository<Event>, IEventRepository
{
    public EventRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
    