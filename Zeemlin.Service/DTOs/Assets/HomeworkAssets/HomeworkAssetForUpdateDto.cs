using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets.HomeworkAssets;

public class HomeworkAssetForUpdateDto
{
    public IFormFile Path { get; set; }
    public long FileSize { get; set; }
    public long TeacherId { get; set; }
    public long GroupId { get; set; }
    public long HomeworkId { get; set; }
}
