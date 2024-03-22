using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForUpdateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; } // Make nullable for optional updates

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; } // Allow optional password updates

        public string Biography { get; set; }

        public string DistrictName { get; set; } // Allow optional updates
        [Required]
        public GenderType genderType { get; set; }
        public long? SchoolNumber { get; set; }  // Allow optional updates
    }
}
