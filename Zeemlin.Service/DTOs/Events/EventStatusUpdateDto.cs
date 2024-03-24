using Zeemlin.Domain.Enums.Events;

namespace Zeemlin.Service.DTOs.Events;

public class EventStatusUpdateDto
{
    public EventStatus NewStatus { get; set; } // The new status to be assigned
    public long UpdaterId { get; set; }
}
