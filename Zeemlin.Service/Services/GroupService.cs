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
            .AsNoTracking()
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

    public async Task<GroupForResultDto> RetrieveByIdAsync(long id)
    {
        var group = await _groupRepository.SelectAll()
            .Include(g => g.TeacherGroups)
                .ThenInclude(tg => tg.Teacher) // Eagerly load Teacher within TeacherGroups
            .Include(g => g.Course) // Include Course for details
            .Include(g => g.StudentGroups) // Include StudentGroups
            .Where(g => g.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (group is null)
        {
            throw new ZeemlinException(404, "Group Not Found");
        }

        // Map to GroupForResultDto, including related entities
        var groupDto = _mapper.Map<GroupForResultDto>(group);

        // Handle GroupDataResultDto mapping (optional, adjust based on your logic)
        if (group.TeacherGroups.Any()) // Check if there are TeacherGroups
        {
            groupDto.GroupData = group.TeacherGroups.Select(tg => new GroupDataResultDto
            {
                GroupId = tg.GroupId, // Assuming GroupId exists in TeacherGroup
                GroupName = tg.Group?.Name, // Access Group Name through relationship (if applicable)
                TeacherFirstName = tg.Teacher?.FirstName,
                TeacherLastName = tg.Teacher?.LastName,
                GroupStudentCount = tg.Group.StudentGroups.Count ,
                CourseName = tg.Group?.Course?.Name,
                GroupAgeInDays = tg.Group.CreatedAt.ToString()
            }).ToList();
        }
        else
        {
            groupDto.GroupData = new List<GroupDataResultDto>(); // Empty collection
        }

        return groupDto;
    }


    public async Task<IEnumerable<GroupDataResultDto>> SearchGroupsAsync(string searchTerm)
    {
        var groupTerm = await _groupRepository.SelectAll()
            .Where(g => g.Name.ToLower().Contains(searchTerm.ToLower()))
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (groupTerm is null)
            throw new ZeemlinException(404, "Not Found");

        var groups = await _groupRepository.SelectAll()
            .Include(g => g.TeacherGroups)
                .ThenInclude(tg => tg.Teacher)
            .Include(g => g.Course)
            .Include(g => g.StudentGroups)  
            .Where(g => g.Name.ToLower().Contains(searchTerm.ToLower()))
            .AsNoTracking()
            .ToListAsync();


        return groups.Select(g => new GroupDataResultDto
        {
            GroupId = g.Id,
            GroupName = g.Name,
            TeacherFirstName = g.TeacherGroups.FirstOrDefault()?.Teacher?.FirstName,    
            TeacherLastName = g.TeacherGroups.FirstOrDefault()?.Teacher?.LastName,
            GroupStudentCount = g.StudentGroups.Count,
            CourseName = g.Course?.Name,
            GroupAgeInDays = g.CreatedAt.ToString()
        });
    }





}
