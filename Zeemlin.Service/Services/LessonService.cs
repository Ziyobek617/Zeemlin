using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class LessonService : ILessonService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Lesson> _lessonRepository;

    public LessonService(IMapper mapper, IRepository<Lesson> lessonRepository)
    {
        this._mapper = mapper;
        this._lessonRepository = lessonRepository;
    }


    public async Task<LessonForResultDto> CreateAsync(LessonForCreationDto dto)
    {
        var lesson = await _lessonRepository.SelectAll()
            .Where(l => l.Title.ToLower() == dto.Title.ToLower())
            .FirstOrDefaultAsync();

        if (lesson is null)
            throw new ZeemlinException(409, "Course is already exist.");

        var mappedLesson = _mapper.Map<Lesson>(dto);
        mappedLesson.CreatedAt = DateTime.UtcNow;

        var createLesson = await _lessonRepository.InsertAsync(mappedLesson);
        return _mapper.Map<LessonForResultDto>(mappedLesson);

    }

    public async Task<LessonForResultDto> ModifyAsync(long id, LessonForUpdateDto dto)
    {
        var lessons = await _lessonRepository.SelectAll()
            .Where(l => l.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (lessons is null)
            throw new ZeemlinException(404, "Lesson is not found");

        lessons.UpdatedAt = DateTime.UtcNow;
        var lesson = _mapper.Map(dto, lessons);

        await _lessonRepository.UpdateAsync(lesson);

        return _mapper.Map<LessonForResultDto>(lesson);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var lessons = await _lessonRepository.SelectAll()
        .Where(l => l.Id == id)
        .FirstOrDefaultAsync();
        if (lessons is null)
            throw new ZeemlinException(404, "Lesson is not found");

        await _lessonRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<LessonForResultDto>> RetrieveAllAsync()
    {
        var lessons = await _lessonRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<LessonForResultDto>>(lessons);
    }

    public async Task<LessonForResultDto> RetrieveIdAsync(long id)
    {
        var lessons = await _lessonRepository.SelectAll()
        .Where(u => u.Id == id)
        .FirstOrDefaultAsync();
        if (lessons is null)
            throw new ZeemlinException(404, "User is not found");

        return _mapper.Map<LessonForResultDto>(lessons);
    }
}
