using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.LessonAttendances;

public class StudentAttendanceReportDto
{
    public long StudentId { get; set; }
    public string StudentName { get; set; }
    public string StudentSurname { get; set; }
    public DateTime Date { get; set; }
    public string AttendanceType { get; set; }
}
