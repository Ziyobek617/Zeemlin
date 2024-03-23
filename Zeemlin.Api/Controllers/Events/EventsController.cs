using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Events;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Events;

namespace Zeemlin.Api.Controllers.Events;

public class EventsController : BaseController
{
    private readonly IEventService _eventService;

    public EventsController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] EventForCreationDto dto)
        => Ok(await _eventService.CreateEventAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _eventService.RetrieveAllInProccesAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await _eventService.GetEventByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _eventService.RemoveEventAsync(id));

    [HttpPatch("status")]
    public async Task<IActionResult> UpdateEventStatus(EventStatusUpdateDto statusDto)
    {
        var updatedEvent = await _eventService.UpdateEventStatusAsync(statusDto);
        return Ok(updatedEvent);
    }

    [HttpGet("approved")]
    public async Task<IActionResult> GetApprovedEvents()
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
