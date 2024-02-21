using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

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

        [Required]
        public string Email { get; set; } // Director's email address

        [Required]
        public string Password { get; set; } // Password for authentication (securely hashed!)

        // List of Director's schools, ensuring bidirectional relationship
        public ICollection<School> Schools { get; set; } = new HashSet<School>();

        // Method to access a specific school by ID
        public School GetSchoolByName(string SchoolName)
        {
            return Schools.FirstOrDefault(s => s.Name == SchoolName);
        }

        public Director(string username, string firstName, string lastName, string email, string password)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
