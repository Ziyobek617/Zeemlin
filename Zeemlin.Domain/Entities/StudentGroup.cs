using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Domain.Entities;

public class StudentGroup : Auditable
{
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
}