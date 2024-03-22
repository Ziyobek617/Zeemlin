using Zeemlin.Service.DTOs.Courses;

namespace Zeemlin.Service.Interfaces;

public interface ICourseServices
{
    public Task<bool> RemoveAsync(long id);
    public Task<CourseForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync();
    public Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto);
    public Task<CourseForResultDto> ModifyAsync(long id, CourseForUpdateDto dto);
}
