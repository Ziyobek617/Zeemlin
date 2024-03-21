using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Users.Directors;

public class DirectorForCreationDto
{
    public string Username { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAttribute]
    public string Email { get; set; }
    [PhoneAttribute]
    public string PhoneNumber { get; set; }
    public string Password { get; set; }    
    public GenderType Gender { get; set; }
    public string PassportSeria { get; set; }
}
