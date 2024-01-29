using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.DTOs.TeacherGroups;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class TeacherGroupService : ITeacherGroupService
{
    private readonly IMapper _mapper;
    private readonly ITeacherGroupRepository _repository;

    public TeacherGroupService(IMapper mapper, ITeacherGroupRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<TeacherGroupForResultDto> AddAsync(TeacherGroupForCreationDto dto)
    {
        var group = await _repository.SelectAll()
        .Where(u => u.GroupId == dto.GroupId)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (group is not null)
            throw new ZeemlinException(400, "Group already exists");

        var teacher = await _repository.SelectAll()
        .Where(s => s.TeacherId == dto.TeacherId)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (teacher is not null)
            throw new ZeemlinException(400, "Teacher already exists");

        var mappedStudentGroup = _mapper.Map<TeacherGroup>(dto);
        mappedStudentGroup.CreatedAt = DateTime.UtcNow;
        await _repository.InsertAsync(mappedStudentGroup);

        return _mapper.Map<TeacherGroupForResultDto>(mappedStudentGroup);
    }

    public async Task<TeacherGroupForResultDto> ModifyAsync(long id, TeacherGroupForUpdateDto dto)
    {
        var group = await _repository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (group is null)
            throw new ZeemlinException(404, "Not found");

        var mappedTeacherGroup = _mapper.Map(dto, group);
        mappedTeacherGroup.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mappedTeacherGroup);

        return _mapper.Map<TeacherGroupForResultDto>(mappedTeacherGroup);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var group = await _repository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (group is null)
            throw new ZeemlinException(404, "Not found");

        await _repository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<TeacherGroupForResultDto>> RetrieveAllAsync()
    {
        var users = await _repository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<TeacherGroupForResultDto>>(users);
    }

    public async Task<TeacherGroupForResultDto> RetrieveByIdAsync(long id)
    {
        var group = await _repository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (group is null)
            throw new ZeemlinException(404, "Not found");

        return _mapper.Map<TeacherGroupForResultDto>(id);
    }
}
