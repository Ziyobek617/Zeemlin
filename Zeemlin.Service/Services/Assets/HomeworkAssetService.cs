using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets.HomeworkAssets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class HomeworkAssetService : IHomeworkAssetService
{
    private readonly IMapper _mapper;

    private readonly IHomeworkAssetRepository _repository;
    public HomeworkAssetService(IMapper mapper, IHomeworkAssetRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<HomeworkAssetForResultDto> UploadAsync(HomeworkAssetForCreationDto dto)
    {

        var IsValidHomeworkId = await _repository.SelectAll()
            .AsNoTracking()
            .Where(h => h.HomeworkId == dto.HomeworkId)
            .FirstOrDefaultAsync();

        if (IsValidHomeworkId is not null)
            throw new ZeemlinException(409, "Homework already exists");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "HomeworkAssets");
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var fullPath = Path.Combine(WwwRootPath, fileName);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Path.CopyToAsync(stream);
        }

        var mappedHomeworkAsset = _mapper.Map<HomeworkAsset>(dto);
        mappedHomeworkAsset.CreatedAt = DateTime.UtcNow;
        mappedHomeworkAsset.UploadedDate = DateTime.UtcNow;
        await _repository.InsertAsync(mappedHomeworkAsset);

        return _mapper.Map<HomeworkAssetForResultDto>(mappedHomeworkAsset);
    }

    public async Task<HomeworkAssetForResultDto> ModifyAsync(long id, HomeworkAssetForUpdateDto dto)
    {
        var update = await _repository.SelectAll()
            .AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (update is null)
            throw new ZeemlinException(404, "Homework not found");

        var imageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, update.Path);

        if (File.Exists(imageFullPath))
            File.Delete(imageFullPath);

        var imageFileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var imageRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Homeworks", "Assets", imageFileName);
        using (var stream = new FileStream(imageRootPath, FileMode.Create))
        {
            await dto.Path.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string imageResult = Path.Combine("Media", "Homeworks", "Assets", imageFileName);

        var mapped = _mapper.Map(dto, update);
        mapped.UpdatedAt = DateTime.UtcNow;
        mapped.Path = imageResult;
        await _repository.UpdateAsync(mapped);

        return _mapper.Map<HomeworkAssetForResultDto>(mapped);

    }

    public async Task<bool> RemoveAsync(long id)
    {
        var update = await _repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == id)
           .FirstOrDefaultAsync();
        if (update is null)
            throw new ZeemlinException(404, "Homework not found");

        await _repository.DeleteAsync(id);
        return true; 
    }

    public async Task<IEnumerable<HomeworkAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<HomeworkAssetForResultDto>>(assets);
    }

    public async Task<HomeworkAssetForResultDto> RetrieveByIdAsync(long id)
    {
        var update = await _repository.SelectAll()
           .AsNoTracking()
           .Where(u => u.Id == id)
           .FirstOrDefaultAsync();
        if (update is null)
            throw new ZeemlinException(404, "Homework not found");

        return _mapper.Map<HomeworkAssetForResultDto>(update);
    }
}
