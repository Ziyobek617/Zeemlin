using Zeemlin.Service.DTOs.Homework;

namespace Zeemlin.Service.DTOs.Assets.HomeworkAssets;

public class HomeworkAssetForResultDto
{
    public long Id { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }
    public long HomeworkId { get; set; }
    public HomeworkForResultDto Homework { get; set; }
}
