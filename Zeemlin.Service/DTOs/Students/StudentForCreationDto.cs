using DataAnnotationsExtensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Students;

public class StudentForCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string FatherName { get; set; }
    public GenderType genderType { get; set; }
    [Phone] 
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAttribute]
    public string Email { get; set; }
    public string Password { get; set; }

    // Address
    public string DistrictName { get; set; }
    public string GeneralAddressMFY { get; set; }
    public string StreetName { get; set; }
    public short HouseNumber { get; set; }
}
