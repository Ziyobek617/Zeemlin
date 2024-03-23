using Zeemlin.Domain.Enums.Events;

namespace Zeemlin.Service.DTOs.Events;

public class EventStatusUpdateDto
{
    public long EventId { get; set; } // ID of the event to update
    public EventStatus NewStatus { get; set; } // The new status to be assigned
    public long UpdaterId { get; set; }
}
