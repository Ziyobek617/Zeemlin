using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForCreationDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [PasswordPropertyText]
        [Required]
        public string Password { get; set; }

        public string Biography { get; set; }

        [Required]
        [MaxLength(50)]
        public string DistrictName { get; set; }

        [Required]
        public long SchoolNumber { get; set; }

    }
}
