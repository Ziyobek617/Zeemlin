using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.ScienceTeachers;
using Zeemlin.Service.DTOs.Students;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class ScienceTeacherService : IScienceTeacherService
{
    private readonly IMapper _mapper;
    private readonly IScienceTeacherRepository _repository;

    public ScienceTeacherService(IMapper mapper, IScienceTeacherRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ScienceTeacherForResultDto> AddAsync(ScienceTeacherForCreationDto dto)
    {
        var Science = await _repository.SelectAll()
            .Where(s => s.ScienceId == dto.ScienceId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Science is not null)
            throw new ZeemlinException(400, "Science already exists");

        var Teacher = await _repository.SelectAll()
            .Where(t => t.TeacherId == dto.TeacherId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Teacher is not null)
            throw new ZeemlinException(400, "Teacher already exists");

        var mapped = _mapper.Map<ScienceTeacher>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        await _repository.InsertAsync(mapped);

        return _mapper.Map<ScienceTeacherForResultDto>(mapped);
    }

    public async Task<ScienceTeacherForResultDto> ModifyAsync(long id, ScienceTeacherForUpdateDto dto)
    {
        var Science = await _repository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Science is null)
            throw new ZeemlinException(404, "Not Found");

        var mapped = _mapper.Map(dto, Science);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mapped);

        return _mapper.Map<ScienceTeacherForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var Science = await _repository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Science is null)
            throw new ZeemlinException(404, "Not Found");

        await _repository.DeleteAsync(id);  

        return true;
    }

    public async Task<IEnumerable<ScienceTeacherForResultDto>> RetrieveAllAsync()
    {
        var users = await _repository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<ScienceTeacherForResultDto>>(users);
    }

    public async Task<ScienceTeacherForResultDto> RetrieveByIdAsync(long id)
    {
        var Science = await _repository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Science is null)
            throw new ZeemlinException(404, "Not Found");

        return _mapper.Map<ScienceTeacherForResultDto>(Science);
    }
}
