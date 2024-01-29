using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class StudentGroupService : IStudentGroupService
{
    private readonly IMapper _mapper;
    private readonly IStudentGroupRepository _studentGroupRepository;
    public StudentGroupService(IMapper mapper, IStudentGroupRepository studentGroupRepository)
    {
        _mapper = mapper;
        _studentGroupRepository = studentGroupRepository;
    }

    public async Task<StudentGroupForResultDto> AddAsync(StudentGroupForCreationDto dto)
    {
        var group = await _studentGroupRepository.SelectAll()
        .Where(u => u.GroupId == dto.GroupId)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (group is not null)
            throw new ZeemlinException(400, "Group already exists");

        var student = await _studentGroupRepository.SelectAll()
        .Where(s => s.StudentId == dto.StudentId)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (student is not null)
            throw new ZeemlinException(400, "Studeny already exists");

        var mappedStudentGroup = _mapper.Map<StudentGroup>(dto);
        mappedStudentGroup.CreatedAt = DateTime.UtcNow;
        await _studentGroupRepository.InsertAsync(mappedStudentGroup);

        return _mapper.Map<StudentGroupForResultDto>(mappedStudentGroup);

    }

    public async Task<StudentGroupForResultDto> ModifyAsync(long id, StudentGroupForUpdateDto dto)
    {
        var user = await _studentGroupRepository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "Not found");

        var mappedStudentGroup = _mapper.Map(dto,user);
        mappedStudentGroup.UpdatedAt = DateTime.UtcNow;
        await _studentGroupRepository.UpdateAsync(mappedStudentGroup);

        return _mapper.Map<StudentGroupForResultDto>(mappedStudentGroup);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await _studentGroupRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "Not found");

        await _studentGroupRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<StudentGroupForResultDto>> RetrieveAllAsync()
    {
        var users = await _studentGroupRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<StudentGroupForResultDto>>(users);
    }

    public async Task<StudentGroupForResultDto> RetrieveByIdAsync(long id)
    {
        var student = await _studentGroupRepository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (student is null)
            throw new ZeemlinException(404, "Student not found");

        return _mapper.Map<StudentGroupForResultDto>(student);
    }
}
