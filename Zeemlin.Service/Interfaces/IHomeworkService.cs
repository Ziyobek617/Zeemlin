using Zeemlin.Service.DTOs.Homework;

namespace Zeemlin.Service.Interfaces;

public interface IHomeworkService
{
    public Task<bool> RemoveAsync(long id);
    public Task<HomeworkForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<HomeworkForResultDto>> RetrieveAllAsync();
    public Task<HomeworkForResultDto> UpdateAsync(HomeworkForUpdateDto dto);
    public Task<HomeworkForResultDto> CreateAsync(HomeworkForCreationDto dto);
}
