using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities.Questions
{
    public class Question : Auditable
    {
        public string Text { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public AnswerType Type { get; set; }
        public string Description { get; set; }
        public long TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Answer> Answers { get; set; }

        public Question(string text, DifficultyLevel difficulty, AnswerType type)
        {
            Text = text;
            Difficulty = difficulty;
            Type = type;

            // Choose the appropriate answer list based on type
            switch (Type)
            {
                case AnswerType.TrueFalse:
                    Answers = new List<TrueFalseAnswer>().Cast<Answer>().ToList();
                    break;
                case AnswerType.MissingWord:
                    Answers = new List<MissingWordAnswer>().Cast<Answer>().ToList();
                    break;
                case AnswerType.Variant:
                    Answers = new List<OptionAnswer>().Cast<Answer>().ToList();
                    break;
                default:
                    throw new ArgumentException("Invalid answer type");
            }
        }
    }


}
