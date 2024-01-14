using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Parent : Auditable
{
    // Basic personal information:
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    // Contact information:
    [Phone]
    public string PhoneNumber { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }
    
    // Authentication:
    [PasswordPropertyText]
    [Required]
    public string Password { get; set; }
    public string StudentUniqueId { get; set; }

    // Address (options for structure):
    // Option 1: Separate properties
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

    // Option 2: Separate Address entity
    // public Address Address { get; set; } // Reference to an Address entity

    // Additional optional properties:
    public string Occupation { get; set; }
}
