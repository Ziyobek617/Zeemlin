using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Student : Registrate
{
    [Required]
    public long SchoolNumber { get; set; }

    [Required]
    public long GroupId { get; set; }
    public Group Group { get; set; }

    [Required]
    [MaxLength(50)]
    public string FatherName { get; set; }
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; }
    [Required]
    [MaxLength(50)]
    public string GeneralAddressMFY { get; set; }
    [Required]
    [MaxLength(50)]
    public string StreetName { get; set; }
    [Required]
    public short HouseNumber { get; set; }
}
