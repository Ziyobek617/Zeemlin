using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Assets;

public class TeacherAsset : Auditable
{
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}

