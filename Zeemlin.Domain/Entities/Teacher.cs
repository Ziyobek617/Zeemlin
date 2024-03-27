using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Entities.Questions;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Domain.Entities;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
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
    public ScienceType ScienceType { get; set; }
    public GenderType genderType { get; set; }

    public long? TeacherAssetId { get; set; }
    public TeacherAsset? TeacherAsset { get; set; }

    public ICollection<TeacherGroup> TeacherGroups { get; set; }
    public ICollection<Question> Questions { get; set; }
}
