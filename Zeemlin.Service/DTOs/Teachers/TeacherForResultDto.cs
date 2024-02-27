using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForResultDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Consider hiding DateOfBirth unless necessary for specific purposes
        public DateTime? DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Biography { get; set; }

        public string DistrictName { get; set; }
        public string genderType { get; set; }
        public long SchoolNumber { get; set; }

        // Optionally include Group information if relevant
        public GroupForResultDto? Group { get; set; }

        // Consider adding additional properties like created/updated dates
        public DateTime CreatedAt { get; set; }
        public TeacherGroupForResultDto TeacherGroupForResult { get; set; }
        //public ScienceTeacherForResultDto ScienceTeacher { get; set; }
    }
}
