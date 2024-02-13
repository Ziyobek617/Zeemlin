using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Subjects;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class SubjectService : ISubjectService
{
    private readonly IMapper _mapper;
    private readonly ISubjectRepository _subjectRepository;

    public SubjectService(IMapper mapper, ISubjectRepository subjectRepository)
    {
        _mapper = mapper;
        _subjectRepository = subjectRepository;
    }

    public async Task<SubjectForResultDto> AddAsync(SubjectForCreationDto dto)
    {
        var name = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(n => n.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();

        if (name is not null)
            throw new ZeemlinException(409, "Subject already exists");

        var group = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(g => g.GroupId == dto.GroupId)
            .FirstOrDefaultAsync();
        if (group is not null)
            throw new ZeemlinException(409, "Group already exists");

        var teacher = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(t => t.TeacherId == dto.TeacherId)
            .FirstOrDefaultAsync();
        if (teacher is not null)
            throw new ZeemlinException(409, "Teacher already exists");

        var lesson = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.LessonId == dto.LessonId)
            .FirstOrDefaultAsync();
        if (lesson is not null)
            throw new ZeemlinException(409, "Lesson already exists");


        var mapped = _mapper.Map<Subject>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        await _subjectRepository.InsertAsync(mapped);

        return _mapper.Map<SubjectForResultDto>(mapped);
    }

    public async Task<SubjectForResultDto> ModifyAsync(long id, SubjectForUpdateDto dto)
    {
        var update = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(n => n.Id == id)
            .FirstOrDefaultAsync();

        if (update is null)
            throw new ZeemlinException(404, "Subject Not Found");

        var group = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(g => g.GroupId == dto.GroupId)
            .FirstOrDefaultAsync();
        if (group is null)
            throw new ZeemlinException(404, "Group not found");

        var teacher = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(t => t.TeacherId == dto.TeacherId)
            .FirstOrDefaultAsync();
        if (teacher is null)
            throw new ZeemlinException(404, "Teacher not found");

        var lesson = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.LessonId == dto.LessonId)
            .FirstOrDefaultAsync();
        if (lesson is null)
            throw new ZeemlinException(404, "Lesson not found");

        var mappedsubject = _mapper.Map(dto, update);
        mappedsubject.UpdatedAt = DateTime.UtcNow;
        await _subjectRepository.UpdateAsync(mappedsubject);

        return _mapper.Map<SubjectForResultDto>( mappedsubject);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var update = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(n => n.Id == id)
            .FirstOrDefaultAsync();

        if (update is null)
            throw new ZeemlinException(404, "Subject Not Found");

        await _subjectRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<SubjectForResultDto>> RetrieveAllAsync()
    {
        var subjects = await _subjectRepository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<SubjectForResultDto>>(subjects);
        throw new NotImplementedException();
    }

    public async Task<SubjectForResultDto> RetrieveByIdAsync(long id)
    {
        var update = await _subjectRepository.SelectAll()
            .AsNoTracking()
            .Where(n => n.Id == id)
            .FirstOrDefaultAsync();

        if (update is null)
            throw new ZeemlinException(404, "Subject Not Found");

        return _mapper.Map<SubjectForResultDto>(update);
    }
}
