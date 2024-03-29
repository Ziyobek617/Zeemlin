﻿using Zeemlin.Service.DTOs.Events;

namespace Zeemlin.Service.Interfaces.Events;

public interface IEventService
{
    Task<bool> RemoveEventAsync(long eventId);
    Task<EventForResultDto> GetEventByIdAsync(long eventId);
    Task<IEnumerable<EventForResultDto>> RetrieveAllInProccesAsync(); // For super admins
    Task<IEnumerable<RejectedEventForSuperAdminDto>> RetrieveAllRejectedAsync(); // For super admins
    Task<IEnumerable<ApprovedEventForSuperAdminDto>> RetrieveAllApprovedAsync(); // For super admins
    Task<IEnumerable<EventForPublicDto>> GetApprovedEventsForPublicAsync(); // For regular users
    Task<EventForResultDto> CreateEpicEventAsync(EventForCreationDto createDto);
    Task<EventForResultDto> UpdateEventAsync(long eventId, EventForUpdateDto updateDto);
    Task<EventForResultDto> UpdateEventStatusAsync(long eventId, EventStatusUpdateDto statusDto);
}
