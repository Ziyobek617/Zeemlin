namespace Zeemlin.Domain.Entities.Questions;

public class OptionAnswer : Answer
{
    public IList<string> Options { get; set; } = new List<string>();
}
