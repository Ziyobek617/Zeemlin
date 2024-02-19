using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Questions;

public class QuestionForResultDto
{
    public long Id { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public AnswerType Type { get; set; }
    public string Description { get; set; }
    //public IList<AnswerForResultDto> Answers { get; set; }
}
