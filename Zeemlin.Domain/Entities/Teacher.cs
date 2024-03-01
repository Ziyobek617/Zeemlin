using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
    public string Biography { get; set; }
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; }
    [Required]
    public long SchoolNumber { get; set; }
    public ScienceType ScienceType { get; set; }
    public GenderType genderType { get; set; }


    public ICollection<TeacherGroup> TeacherGroups { get; set; }
    public ICollection<ScienceTeacher> scienceTeachers { get; set; }
}
