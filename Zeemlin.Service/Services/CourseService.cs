using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Zeemlin.Data.DbContexts;
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
    private readonly AppDbContext _context;

    public CourseService(IMapper mapper, ICourseRepository courseRepository, AppDbContext context)
    {
        _mapper = mapper;
        _courseRepository = courseRepository;
        _context = context;
    }


    public async Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto)
    {
        // Validate SchoolId range
        if (dto.SchoolId < 1) // Adjust the range based on your valid school IDs
        {
            throw new ZeemlinException(400, "Invalid SchoolId. School ID must be between 1 and 100.");
        }

        // Check for duplicate course name within the same school
        var existingCourse = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(c => c.Name.ToLower() == dto.Name.ToLower() && c.SchoolId == dto.SchoolId)
            .FirstOrDefaultAsync();

        if (existingCourse is not null)
        {
            throw new ZeemlinException(409, "Course with the same name already exists in this school.");
        }

        var IsValidSchoolNumber = await _context.School.FirstOrDefaultAsync(s => s.Id == dto.SchoolId);

        if (IsValidSchoolNumber is null)
            throw new ZeemlinException(404, "School Not Found");

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

        var existingCourse = await _courseRepository.SelectAll()
        .AsNoTracking()
        .Where(c => c.Name.ToLower() == dto.Name.ToLower() && c.SchoolId == dto.SchoolId)
        .FirstOrDefaultAsync();

        if (existingCourse is not null)
        {
            throw new ZeemlinException(409, "Course with the same name already exists in this school.");
        }

        var school = await _courseRepository.SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolId == dto.SchoolId)
            .FirstOrDefaultAsync();

        if (school is null)
            throw new ZeemlinException(404, "School Not Found");

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
        var courses = await _courseRepository.SelectAll().AsNoTracking().ToListAsync();
        return _mapper.Map<IEnumerable<CourseForResultDto>>(courses);
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