using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForUpdateDto
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        [Phone(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Biography { get; set; }
        [Required]
        [MaxLength(50)]
        public string DistrictName { get; set; }
        public ScienceType ScienceType { get; set; }
        public GenderType genderType { get; set; }
    }
}
