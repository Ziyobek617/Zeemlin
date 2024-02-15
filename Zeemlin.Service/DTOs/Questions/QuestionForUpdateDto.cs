using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Questions;

public class QuestionForUpdateDto
{
    public string Text { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public AnswerType Type { get; set; }
    public string Description { get; set; }
}
