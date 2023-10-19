using Zeemlin.Service.DTOs.Grade;

namespace Zeemlin.Service.Interfaces;

public interface IGradeService
{
    public Task<bool> RemoveAsync(long id);
    public Task<GradeForResultDto> RetrieveIdAsync(long id);
    public Task<IEnumerable<GradeForResultDto>> RetrieveAllAsync();
    public Task<GradeForResultDto> UpdateAsync(GradeForUpdateDto dto);
    public Task<GradeForResultDto> CreateAsync(GradeForCreationDto dto);
}
