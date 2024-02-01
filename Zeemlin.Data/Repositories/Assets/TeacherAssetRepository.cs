using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.Repositories.Assets;

public class TeacherAssetRepository : Repository<TeacherAsset>, ITeacherAssetRepository
{
    public TeacherAssetRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
