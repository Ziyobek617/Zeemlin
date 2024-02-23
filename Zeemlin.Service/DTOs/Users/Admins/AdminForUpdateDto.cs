using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Users.Admins;

public class AdminForUpdateDto
{
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public GenderType Gender { get; set; }
    public string PassportSeria { get; set; }
    public long SchoolId { get; set; }
}
