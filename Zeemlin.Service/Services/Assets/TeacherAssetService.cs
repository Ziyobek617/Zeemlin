using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class TeacherAssetService : ITeacherAssetService
{
    private readonly IMapper _mapper;
    private readonly ITeacherAssetRepository _repository;
    private readonly string _wwwRootPath;
    private readonly long _maxSizeInBytes;
    private readonly string[] _allowedExtensions = { ".jpg", ".jpeg", ".png" };


    public TeacherAssetService(
      IMapper mapper,
      ITeacherAssetRepository repository,
      IConfiguration configuration
      )
    {
        _mapper = mapper;
        _repository = repository;
        _wwwRootPath = configuration["TeacherAssetsPath"];
        _maxSizeInBytes = long.Parse(configuration["TeacherAssetMaxSizeInBytes"]);
    }

    

    public async Task<bool> DeletePictureAsync(long teacherId)
    {
        var picture = await _repository.SelectByIdAsync(teacherId);

        if (picture == null)
        {
            var defaultImagePath = "C:\\Users\\mahka\\Pictures\\Saved Pictures\\imzo.jpg"; // Replace with configurable path
            picture = new TeacherAsset
            {
                TeacherId = teacherId,
                Path = defaultImagePath
            };
            await _repository.InsertAsync(picture);
        }
        else
        {

            await _repository.DeleteAsync(picture.Id);
        }

        return true;
    }

    public async Task UpdatePictureAsync(long assetId, TeacherAssetForUpdateDto dto)
    {
        await ValidateImageAsync(dto.File);

        var existingPicture = await _repository.SelectByIdAsync(assetId);

        var asset = await _repository.SelectByIdAsync(assetId);
        await SaveImageAsync(asset, dto.File);

        asset.Path = dto.File.ToString();
        await _repository.UpdateAsync(asset);
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

    private async Task SaveImageAsync(TeacherAsset asset, IFormFile file)
    {
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(file.FileName);
        var fullPath = Path.Combine(_wwwRootPath, fileName);

        try
        {
            await using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
        catch (Exception ex)
        {
            throw new ZeemlinException(500, "Error saving teacher picture: " + ex.Message);
        }

        asset.Path = fileName;

    }
}