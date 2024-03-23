using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Teachers;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class TeacherService : ITeacherService
{
    private readonly IMapper _mapper;
    private readonly ITeacherRepository _repository;
    private readonly AppDbContext appDbContext;

    public TeacherService(
        IMapper mapper,
        ITeacherRepository repository,
        AppDbContext appDbContext)
    {
        _mapper = mapper;
        _repository = repository;
        this.appDbContext = appDbContext;
    }

    public async Task<TeacherForResultDto> CreateAsync(TeacherForCreationDto dto)
    {
        var TeacherEmailExist = await _repository.SelectAll()
            .AsNoTracking()
            .Where(t => t.Email.ToLower() == dto.Email.ToLower() 
            || t.PhoneNumber == dto.PhoneNumber)
            .FirstOrDefaultAsync();
        
        if(TeacherEmailExist is not null)
            throw new ZeemlinException
                (409, "Teacher is already exist.");

        var mapped = _mapper.Map<Teacher>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        var created = await _repository.InsertAsync(mapped);

        return _mapper.Map<TeacherForResultDto>(created);

    }

    public async Task<TeacherForResultDto> ModifyAsync(long id, TeacherForUpdateDto dto)
    {
        var Teacher = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(t => t.Id == id)
            .FirstOrDefaultAsync();

        if (Teacher is null)
            throw new ZeemlinException(404, "Teacher is not found.");

        var TeacherEmailExist = await _repository.SelectAll()
            .AsNoTracking()
            .Where(t => t.Email.ToLower() == dto.Email.ToLower() 
            || t.PhoneNumber == dto.PhoneNumber)
            .FirstOrDefaultAsync();


        if (TeacherEmailExist is not null)
            throw new ZeemlinException(409, "Teacher is already exist.");

        Teacher.UpdatedAt = DateTime.UtcNow;
        var person = _mapper.Map(dto,Teacher);
        await _repository.UpdateAsync(person);

        return _mapper.Map<TeacherForResultDto>(person);

    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(t => t.Id == id)
            .FirstOrDefaultAsync();

        if (user is null)
            throw new ZeemlinException(404, "Teacher is not found.");

        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<TeacherForResultDto>> RetrieveAllAsync()
    {
        var users = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<TeacherForResultDto>>(users);

    }

    public async Task<TeacherForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(t => t.Id == id)
            .FirstOrDefaultAsync();

        if (user is null)
            throw new ZeemlinException(404, "Teacher is not found.");

        return _mapper.Map<TeacherForResultDto>(user);
    
    }
}
