using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets.SchoolAssets;

public class SchoolAssetForCreationDto
{
    public IFormFile Path { get; set; }
    public long SchoolId { get; set; }

}
