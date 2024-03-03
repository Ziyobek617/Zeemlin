using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GradeService : IGradeService
{
    private readonly IMapper _mapper;
    private readonly IGradeRepository _gradeRepository;

    public GradeService(IMapper mapper, IGradeRepository gradeRepository)
    {
        _mapper = mapper;
        _gradeRepository = gradeRepository;
    }


    public async Task<GradeForResultDto> CreateAsync(GradeForCreationDto dto)
    {

        var gradeLessonId = await _gradeRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.LessonId == dto.LessonId)
            .FirstOrDefaultAsync();
        if (gradeLessonId is not null)
            throw new ZeemlinException(409, "Lesson already exist");

        var gradeUserId = await _gradeRepository
            .SelectAll()
            .Where(u => u.UserId == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (gradeUserId is not null)
            throw new ZeemlinException(409, "Student already exists");

        var value = await _gradeRepository.SelectAll()
            .Where(i => i.Value == dto.Value)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (value is not null)
            throw new ZeemlinException(409, "Value already exists");

        var mappedGrade = _mapper.Map<Grade>(dto);
        mappedGrade.CreatedAt = DateTime.UtcNow;
        mappedGrade.DateTimeCreated = DateTime.UtcNow;
        var createGrade = await _gradeRepository.InsertAsync(mappedGrade);

        return _mapper.Map<GradeForResultDto>(createGrade);

    }

    public async Task<GradeForResultDto> ModifyAsync(long id, GradeForUpdateDto dto)
    {
        var gradeId = await _gradeRepository.SelectAll()
            .Where(g => g.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (gradeId is null)
            throw new ZeemlinException(404, "Grade Not Found");

        var gradeUserId = await _gradeRepository
            .SelectAll()
            .Where(u => u.UserId == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (gradeUserId is null)
            throw new ZeemlinException(404, "Student Not Found");

        var gradeLessonId = await _gradeRepository.SelectAll()
            .AsNoTracking()
            .Where(u => u.LessonId == dto.LessonId)
            .FirstOrDefaultAsync();
        if (gradeLessonId is null)
            throw new ZeemlinException(404, "Lesson Not Found");

        gradeId.UpdatedAt = DateTime.UtcNow;
        var baho = _mapper.Map(dto, gradeId);
        await _gradeRepository.UpdateAsync(baho);

        return _mapper.Map<GradeForResultDto>(baho);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var grade = await _gradeRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (grade is null)
            throw new ZeemlinException(404, "Not found");

        await _gradeRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<GradeForResultDto>> RetrieveAllAsync()
    {
        var grades = await _gradeRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<GradeForResultDto>>(grades);
    }

    public async Task<GradeForResultDto> RetrieveIdAsync(long id)
    {
        var grade = await _gradeRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (grade is null)
            throw new ZeemlinException(404, "Not found");

        return _mapper.Map<GradeForResultDto>(grade);
    }
}
