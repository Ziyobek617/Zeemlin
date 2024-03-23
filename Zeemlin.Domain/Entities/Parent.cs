using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Parent : Auditable
{
    // Basic personal information:
    [Required] 
    public string FirstName { get; set; }
    [Required] 
    public string LastName { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }
    public GenderType Gender { get; set; }

    // Contact information:
    [Phone] 
    public string PhoneNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    // Authentication:
    [PasswordPropertyText]
    [Required]
    public string Password { get; set; }

    // Address 
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


    public ICollection<ParentStudent> ParentStudents { get; set; }
}
