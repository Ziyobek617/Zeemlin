using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Users.SuperAdmins;

public class SuperAdminForCreationDto
{
    public string Username { get; set; }

    [Required]
    public string FirstName { get; set; } 

    [Required]
    public string LastName { get; set; } 

    [Required]
    public string Email { get; set; } 

    [Required]
    public string Password { get; set; } 
    public GenderType Gender { get; set; }
    public string PassportSeria { get; set; }
}
