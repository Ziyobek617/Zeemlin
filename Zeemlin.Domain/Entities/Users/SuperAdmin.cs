using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities.Users
{
    public class SuperAdmin : Auditable
    {
        [Required]
        public string Username { get; set; } // For authentication

        [Required]
        public string FirstName { get; set; } // SuperAdmin's first name

        [Required]
        public string LastName { get; set; } // SuperAdmin's last name

        [Required]
        public string Email { get; set; } // SuperAdmin's email address

        [Required]
        public string Password { get; set; } // Securely hashed password
        public GenderType Gender { get; set; }
        public string PassportSeria { get; set; }

        // Consider role-based access control for granular permissions

        // Methods for managing schools and admins (assuming one-to-many relationships)
        public ICollection<School> Schools { get; set; } = new HashSet<School>();
        public ICollection<Admin> Admins { get; set; } = new HashSet<Admin>();

    }
}
