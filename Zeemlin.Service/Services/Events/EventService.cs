using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Zeemlin.Data.IRepositries.Events;
using Zeemlin.Domain.Entities.Events;
using Zeemlin.Domain.Enums.Events;
using Zeemlin.Service.DTOs.Events;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Events;

namespace Zeemlin.Service.Services.Events;

public class EventService : IEventService
{
    private readonly IMapper _mapper;
    private readonly IEventRepository _eventRepository;

    public EventService(IMapper mapper, IEventRepository eventRepository)
    {
        _mapper = mapper;
        _eventRepository = eventRepository;
    }

    public async Task<EventForResultDto> CreateEventAsync(EventForCreationDto createDto)
    {
        // Check StartedAt and EndDate
        if (createDto.StartedAt < DateTime.UtcNow)
        {
            throw new ZeemlinException(400, "Event creation failed: Start date cannot be in the past.");
        }

        if (createDto.EndDate <= createDto.StartedAt)
        {
            throw new ZeemlinException(400, "Event creation failed: End date must be after the start date.");
        }

        if (createDto.Price.HasValue && createDto.Price.Value < 1000)
        {
            throw new ZeemlinException(400, "Event creation failed: Price cannot be less than 1000.");
        }

        var mapped = _mapper.Map<Event>(createDto);
        mapped.CreatedAt = DateTime.UtcNow;
        mapped.Status = EventStatus.InProcess;
        await _eventRepository.InsertAsync(mapped);

        return _mapper.Map<EventForResultDto>(mapped);
    }

    public async Task<bool> RemoveEventAsync(long eventId)
    {
        var IsValidId = await _eventRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == eventId)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        await _eventRepository.DeleteAsync(eventId);
        return true;
    }

    public async Task<IEnumerable<EventForPublicDto>> GetApprovedEventsForPublicAsync()
    {
        var approvedEvents = await _eventRepository.SelectAll()
            .Where(e => e.Status == EventStatus.Approved &&
            e.StartedAt >= DateTime.UtcNow)
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<EventForPublicDto>>(approvedEvents);
    }

    public async Task<EventForResultDto> GetEventByIdAsync(long eventId)
    {
        var IsValidId = await _eventRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == eventId)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        return _mapper.Map<EventForResultDto>(IsValidId);
    }

    public async Task<IEnumerable<EventForResultDto>> RetrieveAllInProccesAsync()
    {
        var approvedEvents = await _eventRepository.SelectAll()
            .Where(e => e.Status == EventStatus.InProcess &&
            e.StartedAt >= DateTime.UtcNow)
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<EventForResultDto>>(approvedEvents);
    }

    public async Task<EventForResultDto> UpdateEventAsync(long eventId, EventForUpdateDto updateDto)
    {
        var IsValidId = await _eventRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == eventId)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        if (updateDto.StartedAt < DateTime.UtcNow)
        {
            throw new ZeemlinException(400, "Event creation failed: Start date cannot be in the past.");
        }

        if (updateDto.EndDate <= updateDto.StartedAt)
        {
            throw new ZeemlinException(400, "Event creation failed: End date must be after the start date.");
        }

        if (updateDto.Price.HasValue && updateDto.Price.Value < 1000)
        {
            throw new ZeemlinException(400, "Event creation failed: Price cannot be less than 1000.");
        }

        var mapped = _mapper.Map(updateDto, IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _eventRepository.UpdateAsync(mapped);

        return _mapper.Map<EventForResultDto>(mapped);
    }

    public async Task<EventForResultDto> UpdateEventStatusAsync(EventStatusUpdateDto statusDto)
    {
        var IsValidId = await _eventRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == statusDto.EventId)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        // Update the status and potentially approver (if applicable)
        IsValidId.Status = statusDto.NewStatus;
        if (statusDto.NewStatus == EventStatus.Approved)
        {
            IsValidId.UpdaterId = statusDto.UpdaterId;
        }

        var mapped = _mapper.Map(statusDto,IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _eventRepository.UpdateAsync(mapped);

         return _mapper.Map<EventForResultDto>(mapped);
    }

    public async Task<IEnumerable<RejectedEventForSuperAdminDto>> RetrieveAllRejectedAsync()
    {
        // Use eager loading to include EventStatusUpdateDto
        var rejectedEvents = await _eventRepository.SelectAll()
            .Where(e => e.Status == EventStatus.Rejected &&
            e.StartedAt >= DateTime.UtcNow).AsNoTracking()
            .ToListAsync();
        
        return _mapper.Map<IEnumerable<RejectedEventForSuperAdminDto>>(rejectedEvents);
    }

    public async Task<IEnumerable<ApprovedEventForSuperAdminDto>> RetrieveAllApprovedAsync()
    {
        var rejectedEvents = await _eventRepository.SelectAll()
            .Where(e => e.Status == EventStatus.Approved)
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<ApprovedEventForSuperAdminDto>>(rejectedEvents);
    }
}
