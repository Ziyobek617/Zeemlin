using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Assets;

public class TeacherAsset : Auditable
{
    public long TeacherId { get; set; }
    public string Filename { get; set; }
    public string Path { get; set; }
    public string ContentType { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }

    public Teacher Teacher { get; set; } // Navigational property to associated teacher
}

