using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Users.Directors;

public class DirectorForResultDto
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public string PassportSeria { get; set; }

    public ICollection<School> schools { get; set; }

}
