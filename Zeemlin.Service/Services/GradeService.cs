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
    private readonly IRepository<Grade> _gradeRepository;

    public GradeService(IMapper mapper, IRepository<Grade> gradeRepository)
    {
        _mapper = mapper;
        _gradeRepository = gradeRepository;
    }


    public async Task<GradeForResultDto> CreateAsync(GradeForCreationDto dto)
    {
        var grade = await _gradeRepository.SelectAll()
            .Where(u => u.UserId == dto.UserId && u.HomeworkId == dto.HomeworkId)
            .FirstOrDefaultAsync();
        if (grade is not null)
            throw new ZeemlinException(409, "Already exist");

        var mappedGrade = _mapper.Map<Grade>(dto);
        mappedGrade.CreatedAt = DateTime.UtcNow;

        var createGrade = await _gradeRepository.InsertAsync(mappedGrade);

        return _mapper.Map<GradeForResultDto>(createGrade);

    }

    public async Task<GradeForResultDto> ModifyAsync(long id, GradeForUpdateDto dto)
    {
        var grade = await _gradeRepository.SelectAll()
            .Where(u => u.UserId == dto.UserId && u.HomeworkId == dto.HomeworkId)
            .FirstOrDefaultAsync();
        if (grade is null)
            throw new ZeemlinException(404, "Not found");

        grade.UpdatedAt = DateTime.UtcNow;
        var baho = _mapper.Map(dto, grade);

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
        var grade = await _gradeRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<GradeForResultDto>>(grade);
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
