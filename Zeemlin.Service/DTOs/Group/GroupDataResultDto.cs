namespace Zeemlin.Service.DTOs.Group;

public class GroupDataResultDto
{
    public long GroupId {  get; set; }   
    public string GroupName { get; set; }
    public string TeacherFirstName { get; set; }
    public string TeacherLastName { get; set; }
    public int GroupStudentCount { get; set; }
    public string CourseName { get; set; }
    public string GroupAgeInDays { get; set; }
}
