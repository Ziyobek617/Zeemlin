using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;

public class SchoolLogoAssetForCreationDto
{
    public IFormFile Path { get; set; }
    public long SchoolId { get; set; }
}
