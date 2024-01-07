using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Parent : Auditable
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
