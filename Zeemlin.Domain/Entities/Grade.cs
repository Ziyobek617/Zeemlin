using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Grade : Auditable
{
    public long UserId { get; set; }
    public Student User { get; set; } // One-to-many relationship
    public long HomeworkId { get; set; }
    public Homework Homework { get; set; } // One-to-many relationship
    public int Value { get; set; }
}
