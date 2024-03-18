using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.DTOs.Assets.SchoolAssets;

public class SchoolAssetForResultDto
{
    public long Id { get; set; }
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long SchoolId { get; set; }
    public SchoolForResultDto School { get; set; }
}
