using Zeemlin.Service.DTOs.LessonAttendances;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.Interfaces;

public interface ILessonAttendanceService
{
    public Task<bool> RemoveAsync(long id);
    public Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync();
    public Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto);
    public Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto);
}
