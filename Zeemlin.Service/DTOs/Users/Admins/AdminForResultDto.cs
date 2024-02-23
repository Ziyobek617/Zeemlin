using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.DTOs.Users.Admins;

public class AdminForResultDto
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string PassportSeria { get; set; }
    public long SchoolId { get; set; }
    public SchoolForResultDto SchoolForResultDto { get; set; }
}
