using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
}
