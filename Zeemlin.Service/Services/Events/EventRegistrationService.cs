
using Zeemlin.Service.DTOs.Events.EventRegistrations;
using Zeemlin.Service.Interfaces.Events.EventsRegistrations;

namespace Zeemlin.Service.Services.Events;

public class EventRegistrationService : IEventRegistrationService
{
    //private readonly IMapper _mapper;
    //private readonly IEventRegistrationRepository _eventRegistrationRepository;

    //public EventRegistrationService(
    //    IMapper mapper, 
    //    IEventRegistrationRepository eventRegistrationRepository)
    //{
    //    _mapper = mapper;
    //    _eventRegistrationRepository = eventRegistrationRepository;
    //}

    public async Task<EventRegistrationResultDto> CreateAsync(EventRegistrationCreationDto dto)
    {
        //var isValidEventId = await _eventRegistrationRepository.SelectAll()
        //    .AsNoTracking()
        //    .Where(e => e.EventId == dto.EventId)   
        //    .FirstOrDefaultAsync();

        //if (isValidEventId is not null)
        //    throw new ZeemlinException(409, "Event is already exists");

        //var entity = _mapper.Map<EventRegistration>(dto);
        //entity.CreatedAt = DateTime.UtcNow;
        //await _eventRegistrationRepository.InsertAsync(entity);

        //return _mapper.Map<EventRegistrationResultDto>(entity);
        throw new NotImplementedException();

    }

    public async Task<bool> DeleteAsync(long id)
    {
        //var isValidId = await _eventRegistrationRepository
        //    .SelectAll()
        //    .AsNoTracking()
        //    .Where(d => d.Id == id)
        //    .FirstOrDefaultAsync();
        //if (isValidId is null)
        //    throw new ZeemlinException(404, "Event is not Found");

        //await _eventRegistrationRepository.DeleteAsync(id);
        //return true;
        throw new NotImplementedException();


    }

    public async Task<List<EventRegistrationResultDto>> GetByEmailAsync(string email)
    {
        //var user = await _eventRegistrationRepository.SelectAll()
        //    .Where(u => u.Email.ToLower() == email.ToLower())
        //    .AsNoTracking()
        //    .FirstOrDefaultAsync();
        //if (user is null)
        //    throw new ZeemlinException(404, "User Not Found");

        //return _mapper.Map<List<EventRegistrationResultDto>>(user);
        throw new NotImplementedException();

    }

    public Task<List<EventRegistrationResultDto>> GetByEventIdAsync(long eventId)
    {

        throw new NotImplementedException();
    }

    public Task<EventRegistrationResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<EventRegistrationResultDto>> GetByPhoneNumberAsync(string phoneNumber)
    {
        //var userPhoneNumber = await _eventRegistrationRepository.SelectAll()
        //    .Where(u => u.PhoneNumber == phoneNumber)
        //    .AsNoTracking()
        //    .FirstOrDefaultAsync();
        //if (userPhoneNumber is null)
        //    throw new ZeemlinException(404, "User Not Found");

        //return _mapper.Map<List<EventRegistrationResultDto>>(userPhoneNumber);
        throw new NotImplementedException();

    }

    public Task<EventRegistrationResultDto> UpdateAsync(long id, EventRegistrationUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
