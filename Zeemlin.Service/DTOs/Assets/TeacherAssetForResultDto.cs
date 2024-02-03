using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.Assets;

public class TeacherAssetForResultDto
{
    public long Id { get; set; }
    public long TeacherId { get; set; }
    public string Path { get; set; }
    public string ContentType { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }
    public TeacherForResultDto TeacherForResultDto { get; set; }
}
