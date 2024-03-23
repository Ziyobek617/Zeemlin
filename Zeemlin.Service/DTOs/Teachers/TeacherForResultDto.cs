using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.DTOs.Teachers
{
    public class TeacherForResultDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Consider hiding DateOfBirth unless necessary for specific purposes
        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Biography { get; set; }

        public string DistrictName { get; set; }
        public string ScienceType { get; set; }
        public string genderType { get; set; }

        public DateTime CreatedAt { get; set; }
        public ICollection<TeacherGroupForResultDto> TeacherGroupForResult { get; set; }
    }
}
