using System.ComponentModel.DataAnnotations;

namespace Zeemlin.Service.DTOs.Students;

public class StudentForCreationDto
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
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
}
