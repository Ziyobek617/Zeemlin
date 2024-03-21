using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets.TeacherAssets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class TeacherAssetService : ITeacherAssetService
{
    private readonly IMapper _mapper;
    private readonly ITeacherAssetRepository _repository;
    private readonly AppDbContext _context;
    private readonly string _wwwRootPath;
    private readonly long _maxSizeInBytes;
    private readonly string[] _allowedExtensions = { ".jpg", ".jpeg", ".png" };


    public TeacherAssetService(
      IMapper mapper,
      ITeacherAssetRepository repository,
      IConfiguration configuration,
      AppDbContext context)
    {
        _mapper = mapper;
        _repository = repository;
        _maxSizeInBytes = 5 * 1024 * 1024;
        _context = context;
    }



    public async Task<bool> DeletePictureAsync(long id)
    {
        var delete = await _repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == id)
           .FirstOrDefaultAsync();
        if (delete is null)
            throw new ZeemlinException(404, "Teacher Asset not found");

        await _repository.DeleteAsync(id);

        return true;
    }

    private async Task ValidateImageAsync(IFormFile file)
    {
        if (file.Length > _maxSizeInBytes)
        {
            throw new ZeemlinException(400, "Image size exceeds maximum allowed size.");
        }

        var extension = Path.GetExtension(file.FileName).ToLower();
        if (!_allowedExtensions.Contains(extension))
        {
            throw new ZeemlinException(400, "Invalid image format. Only jpg, jpeg, and png are allowed.");
        }

    }

    

    public async Task<TeacherAssetForResultDto> UploadAsync(TeacherAssetForCreationDto dto)
    {
        var IsValidTeacherId = await _context.Teachers.FirstOrDefaultAsync(h => h.Id == dto.TeacherId);

        if (IsValidTeacherId is null)
            throw new ZeemlinException(404, "Teacher not found");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "TeacherAssets");
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var fullPath = Path.Combine(WwwRootPath, fileName);
        await ValidateImageAsync(dto.Path);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Path.CopyToAsync(stream);
        }

        string resultImage = Path.Combine("TeacherAssets", fileName);

        var mapped = _mapper.Map<TeacherAsset>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.UploadedDate = DateTime.UtcNow;
        mapped.Path = resultImage;
        await _repository.InsertAsync(mapped);

        return _mapper.Map<TeacherAssetForResultDto>(mapped);
    }

    public async Task<TeacherAssetForResultDto> RetrieveByIdAsync(long id)
    {
        var update = await _repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == id)
           .FirstOrDefaultAsync();
        if (update is null)
            throw new ZeemlinException(404, "Teacher Asset not found");

        return _mapper.Map<TeacherAssetForResultDto>(update);
    }

    public async Task<IEnumerable<TeacherAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<TeacherAssetForResultDto>>(assets);
    }
}