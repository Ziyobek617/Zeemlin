using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.Repositories.Assets;

public class HomeworkAssetRepository : Repository<HomeworkAsset>, IHomeworkAssetRepository
{
    public HomeworkAssetRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
