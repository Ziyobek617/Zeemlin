using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Student : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
    [Required]
    public long SchoolNumber { get; set; }

    [Required]
    public long GroupId { get; set; }
    public Group Group { get; set; }

    [Required]
    [MaxLength(50)]
    public string FatherName { get; set; }

    // Address
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; } // Tuman nomi
    [Required]
    [MaxLength(50)]
    public string GeneralAddressMFY { get; set; } // MFY
    [Required]
    [MaxLength(50)]
    public string StreetName { get; set; } // Ko'cha nomi

    // Properties for apartment building details:
    public short? BuildingNumber { get; set; } // Bino raqami (optional)
    public short? EntranceNumber { get; set; } // Kirish raqami (optional)
    public short? Floor { get; set; } // Qavat raqami (optional)

    [Required]
    public short HouseNumber { get; set; } // Uy raqami (for non-apartment addresses)
    public string StudentUniqueId { get; set; }

}
