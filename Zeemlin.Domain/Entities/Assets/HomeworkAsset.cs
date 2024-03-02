using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Assets;

public class HomeworkAsset : Auditable
{
    public string Path { get; set; }
    public string ContentType { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }
    public long HomeworkId { get; set; }
    public Homework Homework { get; set; }
}
