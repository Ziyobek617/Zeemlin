using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets;
using Zeemlin.Service.DTOs.Assets.SchoolAssets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class SchoolAssetService : ISchoolAssetService
{
    private readonly IMapper mapper;
    private readonly AppDbContext _context;
    private readonly ISchoolAssetRepository repository;

    public SchoolAssetService(IMapper mapper, ISchoolAssetRepository repository, AppDbContext context)
    {
        this.mapper = mapper;
        this.repository = repository;
        _context = context;
    }

    public async Task<bool> DeletePictureAsync(long Id)
    {
        var delete = await repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == Id)
           .FirstOrDefaultAsync();
        if (delete is null)
            throw new ZeemlinException(404, "School Asset not found");

        await repository.DeleteAsync(Id);

        return true;
    }

    public async Task<IEnumerable<SchoolAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await repository.SelectAll().AsNoTracking().ToListAsync();

        return mapper.Map<IEnumerable<SchoolAssetForResultDto>>(assets);
    }

    public async Task<SchoolAssetForResultDto> RetrieveByIdAsync(long Id)
    {
        var update = await repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == Id)
           .FirstOrDefaultAsync();
        if (update is null)
            throw new ZeemlinException(404, "School Asset not found");

        return mapper.Map<SchoolAssetForResultDto>(update);
    }

    public async Task<SchoolAssetForResultDto> UploadAsync(SchoolAssetForCreationDto dto)
    {
        var IsValidTeacherId = await _context.School.FirstOrDefaultAsync(h => h.Id == dto.SchoolId);

        if (IsValidTeacherId is null)
            throw new ZeemlinException(404, "School not found");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "SchoolAssets");
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var fullPath = Path.Combine(WwwRootPath, fileName);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Path.CopyToAsync(stream);
        }

        string resultImage = Path.Combine("SchoolAssets", fileName);

        var mapped = mapper.Map<SchoolAsset>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.UploadedDate = DateTime.UtcNow;
        mapped.Path = resultImage;
        await repository.InsertAsync(mapped);

        return mapper.Map<SchoolAssetForResultDto>(mapped);
    }
}
