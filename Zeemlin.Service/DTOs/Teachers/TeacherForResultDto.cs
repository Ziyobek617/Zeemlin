using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForResultDto
    {
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // Consider hiding DateOfBirth unless necessary for specific purposes
        public DateTime? DateOfBirth { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Biography { get; set; }

        [Required]
        [MaxLength(50)]
        public string DistrictName { get; set; }
        [Required]
        public GenderType genderType { get; set; }

        [Required]
        public long SchoolNumber { get; set; }

        // Optionally include Group information if relevant
        public GroupForResultDto? Group { get; set; } // Use GroupForResultDto to avoid circular dependencies

        // Consider adding additional properties like created/updated dates
        public DateTime CreatedAt { get; set; }
        public TeacherGroupForResultDto TeacherGroupForResult { get; set; }
        //public ScienceTeacherForResultDto ScienceTeacher { get; set; }
    }
}
