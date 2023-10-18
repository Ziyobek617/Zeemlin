using Zeemlin.Service.DTOs.Course;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.Interfaces;

public interface ICourseService
{
    public Task<bool> RemoveAsync(long id);
    public Task<CourseForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync();
    public Task<CourseForResultDto> UpdateAsync(CourseForUpdateDto dto);
    public Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto);
}
