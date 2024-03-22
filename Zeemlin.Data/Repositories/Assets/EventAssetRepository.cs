using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.Repositories.Assets;

public class EventAssetRepository : Repository<EventAsset>, IEventAssetRepository
{
    public EventAssetRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
