using Zeemlin.Service.DTOs.StudentGroups;

namespace Zeemlin.Service.DTOs.Students;

public class StudentForResultDto
{
    public long Id { get; set; }
    public string StudentUniqueId { get; set; }
    public long SchoolNumber { get; set; }
    public long GroupId { get; set; }
    public string FatherName { get; set; }
    public string DistrictName { get; set; }
    public string GeneralAddressMFY { get; set; }
    public string StreetName { get; set; }
    public short? BuildingNumber { get; set; }
    public short? EntranceNumber { get; set; }
    public short? Floor { get; set; }
    public short HouseNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public StudentGroupForResultDto Group { get; set; }
}
