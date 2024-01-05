using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Students;

namespace Zeemlin.Service.Interfaces;

public interface IStudentService
{
    public Task<bool> RemoveAsync(long id);
    public Task<StudentForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<StudentForResultDto>> RetrieveAllAsync();
    public Task<StudentForResultDto> AddAsync(StudentForCreationDto dto);
    public Task<Student> RetrieveByEmailAsync(string email);
    public Task<Student> RetrieveByPhoneNumberAsync(string phoneNumber);
    public Task<StudentForResultDto> ModifyAsync(long id, StudentForUpdateDto dto);
}
