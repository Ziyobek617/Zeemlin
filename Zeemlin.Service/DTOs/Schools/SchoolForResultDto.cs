namespace Zeemlin.Service.DTOs.Schools;

public class SchoolForResultDto
{
    public long Id { get; set; }

    public long SchoolNumber { get; set; } // Expose SchoolNumber if needed in API responses

    public string Name { get; set; }

    public string Description { get; set; }

    // Address properties
    public string Country { get; set; }

    public string Region { get; set; } // Use string representation of the enum value

    public string DistrictName { get; set; }

    public string GeneralAddressMFY { get; set; }

    public string StreetName { get; set; }

    // Contact Information
    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string? Website { get; set; }
}
