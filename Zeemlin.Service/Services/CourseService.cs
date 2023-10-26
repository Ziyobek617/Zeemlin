using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Course;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class CourseService : ICourseService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Course> _courseRepository;

    public CourseService(IMapper mapper,IRepository<Course> repository)
    {
        this._mapper = mapper;
        this._courseRepository = repository;
    }
    public async Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto)
    {
        var courses = await _courseRepository.SelectAll()
            .Where(u => u.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();

        if (courses is not null)
            throw new ZeemlinException(409, "Course is already exist.");

        var mappedCourse = _mapper.Map<Course>(dto);
        mappedCourse.CreatedAt = DateTime.UtcNow;

        var createdUser = await _courseRepository.InsertAsync(mappedCourse);
        return _mapper.Map<CourseForResultDto>(mappedCourse);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var courses = await _courseRepository.SelectAll()
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
        if (courses is null)
            throw new ZeemlinException(404, "Course is not found");

        await _courseRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync()
    {
        var courses = await _courseRepository.SelectAll().Include(c => c.Groups).ToListAsync();

        return _mapper.Map<IEnumerable<CourseForResultDto>>(courses);
    }

    public async Task<CourseForResultDto> RetrieveByIdAsync(long id)
    {
        var courses = await _courseRepository.SelectAll()
            .Where (c => c.Id == id)
            .FirstOrDefaultAsync();
        if (courses is null)
            throw new ZeemlinException(404, "Course is not found");

        return _mapper.Map<CourseForResultDto>(courses); 
    }

    public async Task<CourseForResultDto> ModifyAsync(long id, CourseForUpdateDto dto)
    {
        var courses = await _courseRepository.SelectAll()
            .Where(c =>  c.Id == id)
            .FirstOrDefaultAsync();
        if (courses is null)
            throw new ZeemlinException(404, "Course is not found");

        courses.UpdatedAt = DateTime.UtcNow;
        var course = _mapper.Map(dto, courses);

        await _courseRepository.UpdateAsync(course);

        return _mapper.Map<CourseForResultDto>(course);

    }
}
