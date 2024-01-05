using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Grade : Auditable
{
    public long StudentId { get; set; }
    public Student Student { get; set; } // One-to-many relationship
    public long HomeworkId { get; set; }
    public Homework Homework { get; set; } // One-to-many relationship
    public int Value { get; set; }
}
