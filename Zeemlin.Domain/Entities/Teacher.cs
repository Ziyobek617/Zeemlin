using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Teacher : Registrate
{
    
    public string Biography { get; set; }
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; }
    [Required]
    public long SchoolNumber { get; set; }
    [Required]
    public long GroupId { get; set; }
    public Group Group { get; set; }
}
