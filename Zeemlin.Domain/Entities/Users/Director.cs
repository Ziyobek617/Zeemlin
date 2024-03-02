using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities.Users
{
    public class Director : Auditable
    {
        [Required]
        public string Username { get; set; } // Username for authentication

        [Required]
        public string FirstName { get; set; } // Director's first name

        [Required]
        public string LastName { get; set; } // Director's last name
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // Password for authentication (securely hashed!)
        public GenderType Gender { get; set; }
        [Required]
        public string PassportSeria { get; set; }

        // List of Director's schools, ensuring bidirectional relationship
        public ICollection<School> Schools { get; set; }

        
    }
}
