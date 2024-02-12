using Zeemlin.Service.DTOs.Subjects;

namespace Zeemlin.Service.Interfaces;

public interface ISubjectService
{
    Task<bool> RemoveAsync(long id);
    Task<SubjectForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<SubjectForResultDto>> RetrieveAllAsync();
    Task<SubjectForResultDto> AddAsync(SubjectForCreationDto dto);
    Task<SubjectForResultDto> ModifyAsync(long id, SubjectForUpdateDto dto);
}
