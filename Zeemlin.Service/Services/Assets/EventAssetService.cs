using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Data.IRepositries.Events;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets.EventAssets;
using Zeemlin.Service.DTOs.Assets.TeacherAssets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Helpers;
using Zeemlin.Service.Interfaces.Assets;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Zeemlin.Service.Services.Assets;

public class EventAssetService : IEventAssetService
{
    private readonly IMapper _mapper;
    private readonly long _maxSizeInBytes;
    private readonly IEventRepository _eventRepository;
    private readonly IEventAssetRepository _eventAssetRepository;
    private readonly string[] _allowedExtensions = { ".jpg", ".jpeg", ".png" };

    public EventAssetService(
        IMapper mapper,
        IEventRepository eventRepository,
        IEventAssetRepository eventAssetRepository)
    {
        _mapper = mapper;
        _maxSizeInBytes = 5 * 1024 * 1024;
        _eventRepository = eventRepository;
        _eventAssetRepository = eventAssetRepository;
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

    public async Task<bool> DeletePictureAsync(long Id)
    {
        var delete = await _eventAssetRepository.SelectAll()
           .Where(u => u.Id == Id)
           .AsNoTracking()
           .FirstOrDefaultAsync();

        if (delete is null)
            throw new ZeemlinException(404, "Event Asset not found");

        await _eventAssetRepository.DeleteAsync(Id);
        return true;
    }

    public async Task<IEnumerable<EventAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _eventAssetRepository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<EventAssetForResultDto>>(assets);
    }

    public async Task<EventAssetForResultDto> RetrieveByIdAsync(long Id)
    {
        var delete = await _eventAssetRepository.SelectAll()
           .Where(u => u.Id == Id)
           .AsNoTracking()
           .FirstOrDefaultAsync();

        if (delete is null)
            throw new ZeemlinException(404, "Event Asset not found");

        return _mapper.Map<EventAssetForResultDto>(delete);
    }

    public async Task<EventAssetForResultDto> UploadAsync(EventAssetForCreationDto dto)
    {
        var IsValidEventId = await _eventRepository.SelectAll()
            .Where(e => e.Id == dto.EventId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (IsValidEventId is null)
            throw new ZeemlinException(404, "Event not found");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "EventAssets");
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Path.FileName);
        var fullPath = Path.Combine(WwwRootPath, fileName);
        await ValidateImageAsync(dto.Path);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Path.CopyToAsync(stream);
        }

        string resultImage = Path.Combine("EventAssets", fileName);

        var mapped = _mapper.Map<EventAsset>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.UploadedDate = DateTime.UtcNow;
        mapped.Path = resultImage;
        await _eventAssetRepository.InsertAsync(mapped);

        return _mapper.Map<EventAssetForResultDto>(mapped);
    }
}
