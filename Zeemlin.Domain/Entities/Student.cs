using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Student : Auditable
{
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string FatherName { get; set; }
    public GenderType genderType { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }

    // Address
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; } // Tuman nomi
    [Required]
    [MaxLength(50)]
    public string GeneralAddressMFY { get; set; } // MFY
    [Required]
    [MaxLength(100)]
    public string StreetName { get; set; } // Ko'cha nomi
    public short HouseNumber { get; set; } // Uy raqami (for non-apartment addresses)

    [Required]
    
    public string StudentUniqueId { get; set; }


    public ICollection<Grade> Grades { get; set; }
    public ICollection<StudentGroup> StudentGroups { get; set; }
    public ICollection<ParentStudent> ParentStudents { get; set; }
    public ICollection<LessonAttendance> LessonAttendances { get; set; }

}
