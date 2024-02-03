using Microsoft.AspNetCore.Http;

namespace Zeemlin.Service.DTOs.Assets;

public class TeacherAssetForCreationDto
{
    public long TeacherId { get; set; } // ID of the associated teacher
    public IFormFile Path { get; set; } // The uploaded file itself
}
