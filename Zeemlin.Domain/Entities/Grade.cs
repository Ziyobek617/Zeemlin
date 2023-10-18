using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Grade : Auditable
{
    public long UserId { get; set; }
    public User Users { get; set; }
    public long HomeworkId { get; set; }
    public Homework Homework { get; set; }
    public int Value { get; set; }
}
