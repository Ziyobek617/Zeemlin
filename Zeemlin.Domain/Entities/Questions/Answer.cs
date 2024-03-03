using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Questions;

public class Answer : Auditable
{
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public long QuestionId { get; set; }
    public Question Question { get; set; }

}
