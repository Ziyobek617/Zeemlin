using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Science : Auditable
{
    [Required]
    public ScienceType ScienceType { get; set; }
    public string Description { get; set; }

    public ICollection<ScienceTeacher> scienceTeachers { get; set; }

}
