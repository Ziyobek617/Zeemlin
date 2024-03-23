using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities.Users;

public class Admin : Auditable
{
    public string Username { get; set; } // Username for authentication
    public string FirstName { get; set; } // Admin's first name
    public string LastName { get; set; } // Admin's last name
    public string Email { get; set; } // Admin's email address
    public string Password { get; set; } // Password for authentication (securely hashed!)
    public GenderType Gender { get; set; }
    [Required]
    [StringLength(100)]
    public string PassportSeria { get; set; }
    public long SchoolId { get; set; }
    public School School { get; set; }

}
