using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.StudentGroups;

namespace Zeemlin.Service.DTOs.Students;

public class StudentForResultDto
{
    public long Id { get; set; }
    public string StudentUniqueId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public string FatherName { get; set; }
    public string genderType { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Address
    public string DistrictName { get; set; }
    public string GeneralAddressMFY { get; set; }
    public string StreetName { get; set; }
    public short HouseNumber { get; set; }
    public StudentGroupForResultDto StudentGroup { get; set; }
}
