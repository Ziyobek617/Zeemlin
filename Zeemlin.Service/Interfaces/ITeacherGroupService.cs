using Zeemlin.Service.DTOs.TeacherGroups;

namespace Zeemlin.Service.Interfaces;

public interface ITeacherGroupService
{
    Task<bool> RemoveAsync(long id);
    Task<TeacherGroupForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<TeacherGroupForResultDto>> RetrieveAllAsync();
    Task<TeacherGroupForResultDto> AddAsync(TeacherGroupForCreationDto dto);
    Task<TeacherGroupForResultDto> ModifyAsync(long id, TeacherGroupForUpdateDto dto);
}
