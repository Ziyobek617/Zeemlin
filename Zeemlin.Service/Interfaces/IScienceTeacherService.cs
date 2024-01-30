using Zeemlin.Service.DTOs.ScienceTeachers;

namespace Zeemlin.Service.Interfaces;

public interface IScienceTeacherService
{
    Task<bool> RemoveAsync(long id);
    Task<ScienceTeacherForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<ScienceTeacherForResultDto>> RetrieveAllAsync();
    Task<ScienceTeacherForResultDto> AddAsync(ScienceTeacherForCreationDto dto);
    Task<ScienceTeacherForResultDto> ModifyAsync(long id, ScienceTeacherForUpdateDto dto);
}
