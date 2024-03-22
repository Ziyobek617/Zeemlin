using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets.EventAssets;

public class EventAssetForCreationDto
{
    public IFormFile Path { get; set; }
    public long EventId { get; set; }
}
