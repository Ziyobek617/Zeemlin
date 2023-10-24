using Zeemlin.Service.DTOs.Course;

namespace Zeemlin.Service.Interfaces;

public interface ICourseService
{
    public Task<bool> RemoveAsync(long id);
    public Task<CourseForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync();
    public Task<CourseForResultDto> ModifyAsync(long id, CourseForUpdateDto dto);
    public Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto);
}
