using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets;

public class TeacherAssetForUpdateDto
{
    public long TeacherId { get; set; }
    public IFormFile File { get; set; }
}
