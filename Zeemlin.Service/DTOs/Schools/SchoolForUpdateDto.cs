using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Schools;

public class SchoolForUpdateDto
{
    // Include properties you want to allow updating
    // (You can choose specific properties or all, depending on your needs)
    [Required]
    public long SchoolNumber { get; set; }
    [MaxLength(255)]
    public string Name { get; set; }

    [MaxLength(2000)]
    public string Description { get; set; }

    // Address properties
    [MaxLength(50)]
    public string Country { get; set; }

    public Region Region { get; set; } // nullable to allow omission when updating

    [MaxLength(50)]
    public string DistrictName { get; set; }

    [MaxLength(50)]
    public string GeneralAddressMFY { get; set; }

    [MaxLength(50)]
    public string StreetName { get; set; }

    // Contact Information
    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string? Website { get; set; } // nullable to allow omission when updating
}

