using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Students;

namespace Zeemlin.Service.Interfaces;

public interface IStudentService
{
    Task<bool> RemoveAsync(long id);
    Task<List<Student>> RetrieveByDataAsync(string data);
    Task<StudentForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<StudentForResultDto>> RetrieveAllAsync();
    Task<StudentForResultDto> AddAsync(StudentForCreationDto dto);
    Task<StudentForResultDto> ModifyAsync(long id, StudentForUpdateDto dto);
}
