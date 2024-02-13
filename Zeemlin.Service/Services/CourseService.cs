using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Courses;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;
using Zeemlin.Service.Interfaces.Caches;

namespace Zeemlin.Service.Services;

public class CourseService : ICourseServices
{
    private readonly IMapper _mapper;
    private readonly ICourseRepository _courseRepository;
    private readonly ICacheService _cacheService;
    public CourseService(IMapper mapper, ICourseRepository courseRepository, ICacheService cacheService)
    {
        _mapper = mapper;
        _courseRepository = courseRepository;
        _cacheService = cacheService;
    }


    public async Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto)
    {
        var name = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(n => n.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();

        if (name is not null)
            throw new ZeemlinException(409, "Course already exists");

        var school = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolId == dto.SchoolId)
            .FirstOrDefaultAsync();

        if (school is not null)
            throw new ZeemlinException(409, "School already exists");

        var mappedCourse = _mapper.Map<Course>(dto);
        mappedCourse.CreatedAt = DateTime.UtcNow;
        await _courseRepository.InsertAsync(mappedCourse);

        return _mapper.Map<CourseForResultDto>(mappedCourse);
    }

    public async Task<CourseForResultDto> ModifyAsync(long id, CourseForUpdateDto dto)
    {
        var IsValidId = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Course not found");

        var mapped = _mapper.Map(dto, IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _courseRepository.UpdateAsync(mapped);

        return _mapper.Map<CourseForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var IsValidId = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Course not found");

        await _courseRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync()
    {
        const string cacheKey = "allCourses";

        return await _cacheService.GetAsync(cacheKey, async () =>
        {
            var courses = await _courseRepository.SelectAll().AsNoTracking().ToListAsync();
            return _mapper.Map<IEnumerable<CourseForResultDto>>(courses);
        });
    }


    public async Task<CourseForResultDto> RetrieveIdAsync(long id)
    {
        var IsValidId = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Course not found");

        return _mapper.Map<CourseForResultDto>(IsValidId);
    }
}