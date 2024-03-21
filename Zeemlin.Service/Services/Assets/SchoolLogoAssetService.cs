using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class SchoolLogoAssetService : ISchoolLogoAssetService
{
    private readonly ISchoolLogoAssetRepository _schoolLogoAssetRepository;
    private readonly ISchoolRepository _schoolRepository;
    private readonly IMapper _mapper;

    public SchoolLogoAssetService(
        ISchoolLogoAssetRepository schoolLogoAssetRepository,
        ISchoolRepository schoolRepository,
        IMapper mapper)
    {
        _schoolLogoAssetRepository = schoolLogoAssetRepository;
        _schoolRepository = schoolRepository;
        _mapper = mapper;
    }

    public async Task<bool> DeletePictureAsync(long Id)
    {
        var delete = await _schoolLogoAssetRepository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == Id)
           .FirstOrDefaultAsync();
        if (delete is null)
            throw new ZeemlinException(404, "School Logo not found");

        await _schoolLogoAssetRepository.DeleteAsync(Id);

        return true;
    }

    public async Task<IEnumerable<SchoolLogoAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _schoolLogoAssetRepository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<SchoolLogoAssetForResultDto>>(assets);
    }

    public async Task<SchoolLogoAssetForResultDto> RetrieveByIdAsync(long Id)
    {
        var getById = await _schoolLogoAssetRepository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == Id)
           .FirstOrDefaultAsync();
        if (getById is null)
            throw new ZeemlinException(404, "School Asset not found");

        return _mapper.Map<SchoolLogoAssetForResultDto>(getById);
    }

    public async Task<SchoolLogoAssetForResultDto> UploadAsync(SchoolLogoAssetForCreationDto dto)
    {
        var school = await _schoolRepository.SelectAll()
            .Where(s => s.Id == dto.SchoolId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (school is null)
            throw new ZeemlinException(404, "School not found");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "SchoolLogoAssets");
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var fullPath = Path.Combine(WwwRootPath, fileName);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Path.CopyToAsync(stream);
        }

        string resultImage = Path.Combine("SchoolLogoAssets", fileName);

        var mapped = _mapper.Map<SchoolLogoAsset>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.UploadedDate = DateTime.UtcNow;
        mapped.Path = resultImage;
        await _schoolLogoAssetRepository.InsertAsync(mapped);

        return _mapper.Map<SchoolLogoAssetForResultDto>(mapped);
    }
}
