namespace Zeemlin.Service.DTOs.LessonAttendances;

public class LessonAttendanceReportDataDto
{
    public DateTime Date { get; set; }
    public string LessonName { get; set; }
    public string TeacherName { get; set; }
    public string GroupName { get; set; }
    public int TotalStudents { get; set; }
    public int PresentStudents { get; set; }
    public int AbsentStudents { get; set; }
    public int ExcusedAbsences { get; set; }
    public int LateStudents { get; set; }
    // Optional: Add additional fields specific to your reports (e.g., absence reasons, notes)
}
