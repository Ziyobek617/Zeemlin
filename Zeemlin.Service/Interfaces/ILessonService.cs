using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.DTOs.Lesson;

namespace Zeemlin.Service.Interfaces;

public interface ILessonService
{
    public Task<bool> RemoveAsync(long id);
    public Task<LessonForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<LessonForResultDto>> RetrieveAllAsync();
    public Task<LessonForResultDto> ModifyAsync(long id, LessonForUpdateDto dto);
    public Task<LessonForResultDto> CreateAsync(LessonForCreationDto dto);
}
