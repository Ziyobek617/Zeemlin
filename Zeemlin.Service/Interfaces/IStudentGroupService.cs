using Zeemlin.Service.DTOs.StudentGroups;

namespace Zeemlin.Service.Interfaces;

public interface IStudentGroupService
{
    Task<bool> RemoveAsync(long id);
    Task<StudentGroupForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<StudentGroupForResultDto>> RetrieveAllAsync();
    Task<StudentGroupForResultDto> AddAsync(StudentGroupForCreationDto dto);
    Task<StudentGroupForResultDto> ModifyAsync(long id, StudentGroupForUpdateDto dto);
}
