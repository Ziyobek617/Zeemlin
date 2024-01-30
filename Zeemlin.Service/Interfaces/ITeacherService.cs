using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.Interfaces;

public interface ITeacherService
{
    Task<bool> RemoveAsync(long id);
    Task<TeacherForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<TeacherForResultDto>> RetrieveAllAsync();
    Task<TeacherForResultDto> ModifyAsync(long id, TeacherForUpdateDto dto);
    Task<TeacherForResultDto> CreateAsync(TeacherForCreationDto dto);
}
