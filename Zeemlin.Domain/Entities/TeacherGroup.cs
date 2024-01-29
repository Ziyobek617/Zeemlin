namespace Zeemlin.Domain.Entities;

public class TeacherGroup
{
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    // Additional attributes specific to the teacher-group relationship
}
