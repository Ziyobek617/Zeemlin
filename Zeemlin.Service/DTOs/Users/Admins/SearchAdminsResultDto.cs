using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.DTOs.Users.Admins;

public class SearchAdminsResultDto
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
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}
