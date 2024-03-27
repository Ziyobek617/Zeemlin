using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Questions;

namespace Zeemlin.Domain.Entities.Assets;

public class QuestionAsset : Auditable
{
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long QuestionId { get; set; }
    public Question Question { get; set; }
}
