using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Users.Directors;

public class DirectorForUpdateDto
{
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public GenderType Gender { get; set; }
    public string PassportSeria { get; set; }
}
