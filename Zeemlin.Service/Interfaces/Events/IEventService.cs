using Zeemlin.Service.DTOs.Events;

namespace Zeemlin.Service.Interfaces.Events;

public interface IEventService
{
    Task<bool> RemoveEventAsync(long eventId);
    Task<EventForResultDto> GetEventByIdAsync(long eventId);
    Task<IEnumerable<EventForResultDto>> RetrieveAllInProccesAsync(); // For super admins
    Task<IEnumerable<RejectedEventForSuperAdminDto>> RetrieveAllRejectedAsync(); // For super admins
    Task<IEnumerable<ApprovedEventForSuperAdminDto>> RetrieveAllApprovedAsync(); // For super admins
    Task<IEnumerable<EventForPublicDto>> GetApprovedEventsForPublicAsync(); // For regular users
    Task<EventForResultDto> CreateEventAsync(EventForCreationDto createDto);
    Task<EventForResultDto> UpdateEventStatusAsync(EventStatusUpdateDto statusDto);
    Task<EventForResultDto> UpdateEventAsync(long eventId, EventForUpdateDto updateDto);
}
