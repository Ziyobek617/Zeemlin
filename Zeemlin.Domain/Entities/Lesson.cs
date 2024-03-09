using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Lesson : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }


    public ICollection<Homework> Homework { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}
