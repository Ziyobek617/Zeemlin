using Zeemlin.Service.DTOs.LessonAttendances;

namespace Zeemlin.Service.Interfaces;

public interface ILessonAttendanceService
{
    public Task<bool> RemoveAsync(long id);
    Task<IEnumerable<LessonAttendanceReportDataDto>> GenerateReportAsync(DateTime? startDate = null,
    DateTime? endDate = null,
    long? lessonId = null,
    long? studentId = null);
    public Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync();
    public Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto);
    public Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto);
    Task<IEnumerable<StudentAttendanceDataDto>> GetStudentAttendancesByNameAsync(string studentFullName);
}
