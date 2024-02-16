using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.Assets.HomeworkAssets;

public class HomeworkAssetForResultDto
{
    public long Id { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public DateTime UploadedDate { get; set; }
    public long TeacherId { get; set; }
    public TeacherForResultDto Teacher { get; set; }
    public long GroupId { get; set; }
    public GroupForResultDto Group { get; set; }
    public long HomeworkId { get; set; }
    public HomeworkForResultDto Homework { get; set; }
}
