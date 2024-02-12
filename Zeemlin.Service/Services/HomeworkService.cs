using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class HomeworkService : IHomeworkService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Homework> _homeworkRepository;

    public HomeworkService(IMapper mapper, IRepository<Homework> homeworkRepository)
    {
        _mapper = mapper;
        _homeworkRepository = homeworkRepository;
    }

    public async Task<HomeworkForResultDto> CreateAsync(HomeworkForCreationDto dto)
    {
        var lesson = await _homeworkRepository.SelectAll()
            .Where(h => h.LessonId == dto.LessonId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (lesson is not null)
            throw new ZeemlinException(409, "Homework is already exists.");

        var science = await _homeworkRepository.SelectAll()
            .Where(h => h.ScienceId == dto.ScienceId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (science is not null)
            throw new ZeemlinException(409, "science is already exists.");

        var teacher = await _homeworkRepository.SelectAll()
            .Where(h => h.TeacherId == dto.TeacherId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (teacher is not null)
            throw new ZeemlinException(409, "Teacher is already exists.");

        var group = await _homeworkRepository.SelectAll()
            .AsNoTracking()
            .Where(g => g.GroupId == dto.GroupId)
            .FirstOrDefaultAsync();

        if (group is not null)
            throw new ZeemlinException(409, "Group already exists.");

        var mappedHomework = _mapper.Map<Homework>(dto);
        mappedHomework.CreatedAt = DateTime.UtcNow;
        await _homeworkRepository.InsertAsync(mappedHomework);

        return _mapper.Map<HomeworkForResultDto>(mappedHomework);
    }

    public async Task<HomeworkForResultDto> ModifyAsync(long id, HomeworkForUpdateDto dto)
    {
        var homework = await _homeworkRepository.SelectAll()
            .Where (h => h.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (homework is null)
            throw new ZeemlinException(404, "Homework not found");

        var science = await _homeworkRepository.SelectAll()
            .Where(h => h.ScienceId == dto.ScienceId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (science is null)
            throw new ZeemlinException(404, "science not found");

        var teacher = await _homeworkRepository.SelectAll()
            .Where(h => h.TeacherId == dto.TeacherId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (teacher is null)
            throw new ZeemlinException(404, "Teacher not found");

        var group = await _homeworkRepository.SelectAll()
            .AsNoTracking()
            .Where(g => g.GroupId == dto.GroupId)
            .FirstOrDefaultAsync();

        if (group is null)
            throw new ZeemlinException(404, "Group not found.");

        homework.UpdatedAt = DateTime.UtcNow;
        var vazifa = _mapper.Map(dto, homework);
        await _homeworkRepository.UpdateAsync(vazifa);

        return _mapper.Map<HomeworkForResultDto>(vazifa);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var homework = await _homeworkRepository.SelectAll()
            .Where(h => h.Id == id)
            .FirstOrDefaultAsync();
        if (homework is null)
            throw new ZeemlinException(404, "Homework not found");

        await _homeworkRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<HomeworkForResultDto>> RetrieveAllAsync()
    {
        var homeworks = await _homeworkRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<HomeworkForResultDto>>(homeworks);
    }

    public async Task<HomeworkForResultDto> RetrieveIdAsync(long id)
    {
        var homework = await _homeworkRepository.SelectAll()
            .Where(h => h.Id == id)
            .FirstOrDefaultAsync();
        if (homework is null)
            throw new ZeemlinException(404, "Homework not found");

        return _mapper.Map<HomeworkForResultDto>(homework);
    }
}
