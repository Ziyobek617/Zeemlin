using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Assets;

public class SchoolAsset : Auditable
{
    public string Path { get; set; }
    public string ContentType { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }
    public long SchoolId { get; set; }
    public School School { get; set; }
}
