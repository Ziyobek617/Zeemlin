using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Events;
using Zeemlin.Domain.Entities.Events;

namespace Zeemlin.Data.Repositories.Events;

public class EventRegistrationRepository : Repository<EventRegistration>, IEventRegistrationRepository
{
    public EventRegistrationRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
