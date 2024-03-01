using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Group : Auditable
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    public string Description { get; set; }
    public long CourseId { get; set; }
    public Course Course { get; set; }


    public ICollection<StudentGroup> StudentGroups { get; set; }
    public ICollection<TeacherGroup> TeacherGroups { get; set; }
}
