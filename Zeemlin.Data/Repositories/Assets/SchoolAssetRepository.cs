using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.Repositories.Assets;

public class SchoolAssetRepository : Repository<SchoolAsset>, ISchoolAssetRepository
{
    public SchoolAssetRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
