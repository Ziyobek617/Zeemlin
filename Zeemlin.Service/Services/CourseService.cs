using AutoMapper;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Course;
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
    public Task<CourseForResultDto> CreateAsync(CourseForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CourseForResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CourseForResultDto> RetrieveIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<CourseForResultDto> ModifyAsync(long id, CourseForUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
