using Zeemlin.Service.DTOs.Events.EventRegistrations;

namespace Zeemlin.Service.Interfaces.Events.EventsRegistrations;

public interface IEventRegistrationService
{
    Task<EventRegistrationResultDto> CreateAsync(EventRegistrationCreationDto dto);
    Task<EventRegistrationResultDto> UpdateAsync(long id, EventRegistrationUpdateDto dto);
    Task<bool> DeleteAsync(long id);
    Task<EventRegistrationResultDto> GetByIdAsync(long id);
    Task<List<EventRegistrationResultDto>> GetByEventIdAsync(long eventId);
    Task<List<EventRegistrationResultDto>> GetByPhoneNumberAsync(string phoneNumber);
    Task<List<EventRegistrationResultDto>> GetByEmailAsync(string email);
}

