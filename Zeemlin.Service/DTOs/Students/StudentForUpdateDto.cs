using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Students;

public class StudentForUpdateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string FatherName { get; set; }
    public GenderType genderType { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    // Address
    public string DistrictName { get; set; }
    public string GeneralAddressMFY { get; set; }
    public string StreetName { get; set; }
    public short HouseNumber { get; set; }
}
