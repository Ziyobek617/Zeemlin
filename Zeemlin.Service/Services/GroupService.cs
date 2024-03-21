using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GroupService : IGroupService
{
    private readonly IMapper _mapper;
    private readonly IGroupRepository _groupRepository;
    private readonly ICourseRepository _courseRepository;

    public GroupService(
        IGroupRepository repository,
        IMapper mapper,
        ICourseRepository courseRepository)
    {
        _mapper = mapper;
        _groupRepository = repository;
        _courseRepository = courseRepository;
    }

    public async Task<GroupForResultDto> CreateAsync(GroupForCreationDto dto)
    {
        var course = await _courseRepository.SelectAll()
            .Where(c => c.Id == dto.CourseId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (course is null)
            throw new ZeemlinException(404, "Course not found");

        var groupName = await _groupRepository.SelectAll()
            .Where(gn => gn.CourseId == dto.CourseId 
            && gn.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (groupName is not null)
            throw new ZeemlinException(409, $"Group with same name already exists in this {course.Name}");

        var mappedGroup = _mapper.Map<Group>(dto);
        mappedGroup.CreatedAt = DateTime.UtcNow;
        var createdGroup = await _groupRepository.InsertAsync(mappedGroup);

        return _mapper.Map<GroupForResultDto>(createdGroup);
    }

    public async Task<GroupForResultDto> ModifyAsync(long id, GroupForUpdateDto dto)
    {
        var group = await _groupRepository.SelectAll()
            .AsNoTracking()
            .Where (g => g.Id == id)
            .FirstOrDefaultAsync();
        
        if (group is null)
            throw new ZeemlinException(404, "Group Not Found");

        var course = await _courseRepository.SelectAll()
            .Where(c => c.Id == dto.CourseId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (course is null)
            throw new ZeemlinException(404, "Course not found");

        var groupNameUpdate = await _groupRepository.SelectAll()
            .Where(gn => gn.CourseId == dto.CourseId
            && gn.Name.ToLower() == dto.Name.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (groupNameUpdate is not null)
            throw new ZeemlinException(409, $"Group with same name already exists in this {course.Name}");

        group.UpdatedAt = DateTime.UtcNow;
        var groups = _mapper.Map(dto,group);
        await _groupRepository.UpdateAsync(groups);
        
        return _mapper.Map<GroupForResultDto>(groups);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var group = await _groupRepository.SelectAll()
            .Where (g => g.Id == id)
            .FirstOrDefaultAsync();

        if (group is null)
            throw new ZeemlinException(404, "Group Not Found");

        await _groupRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<GroupForResultDto>> RetrieveAllAsync()
    {
        var group = await _groupRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<GroupForResultDto>>(group);
    }

    public async Task<GroupForResultDto> RetrieveIdAsync(long id)
    {
        var group = await _groupRepository.SelectAll()
            .Where(g => g.Id == id)
            .FirstOrDefaultAsync();

        if (group is null)
            throw new ZeemlinException(404, "Group Not Found");

        return _mapper.Map<GroupForResultDto>(group);
    }

    public async Task<IEnumerable<GroupForResultDto>> SearchGroupsAsync(string searchTerm)
    {
        var groups = await _groupRepository.SelectAll()
            .Where(g => g.Name.ToLower().Contains(searchTerm.ToLower()))
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<GroupForResultDto>>(groups);
    }

}
