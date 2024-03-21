using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.Repositories.Assets;

public class SchoolLogoAssetRepository : Repository<SchoolLogoAsset>, ISchoolLogoAssetRepository
{
    public SchoolLogoAssetRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
