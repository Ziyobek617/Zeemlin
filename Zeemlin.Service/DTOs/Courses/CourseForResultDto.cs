namespace Zeemlin.Service.DTOs.Courses;

public class CourseForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long SchoolId { get; set; }
    public int GroupCount { get; set; } // Number of associated groups
}
