using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zeemlin.Domain.Commons;

public class Registrate : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
}
