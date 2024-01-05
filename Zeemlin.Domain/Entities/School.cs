using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class School : Auditable
{
    [Required] // Adjust MaxLength as needed
    public long SchoolNumber { get; set; }

    [Required]
    [MaxLength(255)] // Adjust MaxLength as needed
    public string Name { get; set; }
    [Required]
    [MaxLength(2000)]
    public string Description { get; set; }

    // Address
    [Required]
    [MaxLength(50)]
    public string Country { get; set; }
    public Region Region { get; set; }
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
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
}
