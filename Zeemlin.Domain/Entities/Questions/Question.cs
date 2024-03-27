using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities.Questions
{
    public class Question : Auditable
    {
        public string Text { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public AnswerType Type { get; set; }
        public string Description { get; set; }
        public long QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public long TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<QuestionAsset> QuestionAssets { get; set; }
        public ICollection<Answer> Answers { get; set; }

    }

}
