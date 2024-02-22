using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Schools;

public class SchoolForCreationDto
{
    [Required] // Adjust MaxLength as needed
    public long SchoolNumber { get; set; }
    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [Required]
    [MaxLength(2000)]
    public string Description { get; set; }
    public long DirectorId { get; set; }

    // Address properties
    [Required]
    [MaxLength(50)]
    public string Country { get; set; }

    public Region Region { get; set; } // nullable to allow omission when creating

    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; }

    [Required]
    [MaxLength(50)]
    public string GeneralAddressMFY { get; set; }

    [Required]
    [MaxLength(50)]
    public string StreetName { get; set; }

    // Contact Information
    public string CallCenter { get; set; }
    public string EmailCenter { get; set; }
    public string? Website { get; set; } // nullable to allow omission when creating
}
