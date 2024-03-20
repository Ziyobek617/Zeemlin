using Zeemlin.Service.DTOs.LessonAttendances;

namespace Zeemlin.Service.Interfaces;

public interface ILessonAttendanceService
{
    Task<bool> RemoveAsync(long id);
    
    Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync();
    Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto);
    Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto);
    Task<IEnumerable<StudentAttendanceReportDto>> GetStudentAttendanceReportAsync(
        string studentFullName, DateTime startDate, DateTime endDate);
    Task<IEnumerable<StudentAttendanceReportDto>> GetLessonAttendanceReportAsync(
        long groupId, long lessonId, DateTime startDate, DateTime endDate);
}
