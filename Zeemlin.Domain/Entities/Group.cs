using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Group : Auditable
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public long HeadTeacherId { get; set; }


    public ICollection<StudentGroup> StudentGroups { get; set; }
    public ICollection<TeacherGroup> TeacherGroups { get; set; }
}
