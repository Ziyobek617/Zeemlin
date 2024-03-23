using Zeemlin.Service.DTOs.Events;

namespace Zeemlin.Service.DTOs.Assets.EventAssets;

public class EventAssetForResultDto
{
    public long Id { get; set; }
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long EventId { get; set; }
    public EventForResultDto EventForResultDto { get; set; }

}
