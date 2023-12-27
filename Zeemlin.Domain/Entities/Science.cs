using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Science : Auditable
{
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public ScienceType ScienceType { get; set; }

    public long? TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    
}
