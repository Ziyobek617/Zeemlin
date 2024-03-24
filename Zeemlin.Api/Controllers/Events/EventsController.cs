using Microsoft.AspNetCore.Mvc;
using Zeemlin.Api;
using Zeemlin.Service.DTOs.Events;
using Zeemlin.Service.Interfaces.Events;

public class EventsController : BaseController
{
    private readonly IEventService _eventService;

    public EventsController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] EventForCreationDto dto)
      => Ok(await _eventService.CreateEpicEventAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
      => Ok(await _eventService.RetrieveAllInProccesAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
      => Ok(await _eventService.GetEventByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
      => Ok(await _eventService.RemoveEventAsync(id));

    [HttpPatch("{id:long}")]  // Use HttpPatch for partial updates
    public async Task<IActionResult> UpdateEventStatus(
      [FromRoute(Name = "id")] long eventId, [FromBody] EventStatusUpdateDto statusDto)
    {
        var updatedEvent = await _eventService.UpdateEventStatusAsync(eventId, statusDto);
        return Ok(updatedEvent);
    }

    [HttpGet("approved")]
    public async Task<IActionResult> GetApprovedEventsForPublicAsync()
    {
        var approvedEvents = await _eventService.GetApprovedEventsForPublicAsync();
        return Ok(approvedEvents);
    }

    [HttpGet("approved/all")] // Consider a more descriptive route name
    public async Task<IActionResult> GetApprovedEventsForAdminAsync()
    {
        var events = await _eventService.RetrieveAllApprovedAsync();
        return Ok(events);
    }

    [HttpGet("rejected")]
    public async Task<IActionResult> GetRejectedEvents()
    {
        var events = await _eventService.RetrieveAllRejectedAsync();
        return Ok(events);
    }
}
