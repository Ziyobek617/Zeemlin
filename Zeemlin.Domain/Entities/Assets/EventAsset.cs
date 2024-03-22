using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Events;

namespace Zeemlin.Domain.Entities.Assets;

public class EventAsset : Auditable
{
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long EventId { get; set; }
    public Event Event { get; set; }
}
