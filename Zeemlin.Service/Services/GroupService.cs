using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GroupService : IGroupService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Group> _groupRepository;

    public GroupService(IRepository<Group> repository, IMapper mapper)
    {
        _mapper = mapper;
        _groupRepository = repository;
    }

    public async Task<GroupForResultDto> CreateAsync(GroupForCreationDto dto)
    {
        var groups = await _groupRepository.SelectAll()
            .Where(g => g.CourseId == dto.CourseId && g.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();

        if (groups is not null)
            throw new ZeemlinException(409, "Group with the same name already exists in the course.");

        var mappedGroup = _mapper.Map<Group>(dto);
        mappedGroup.CreatedAt = DateTime.UtcNow;

        var createdGroup = await _groupRepository.InsertAsync(mappedGroup);

        return _mapper.Map<GroupForResultDto>(createdGroup);
    }

    public async Task<GroupForResultDto> ModifyAsync(long id, GroupForUpdateDto dto)
    {
        var group = await _groupRepository.SelectAll()
            .Where (g => g.Id == id)
            .FirstOrDefaultAsync();
        
        if (group is null)
            throw new ZeemlinException(404, "User is not found");

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
            throw new ZeemlinException(404, "User is not found");

        await _groupRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<GroupForResultDto>> RetrieveAllAsync()
    {
        var group = await _groupRepository.SelectAll().Include(g=> g.UserGroups).ToListAsync();

        return _mapper.Map<IEnumerable<GroupForResultDto>>(group);
    }

    public async Task<GroupForResultDto> RetrieveIdAsync(long id)
    {
        var group = await _groupRepository.SelectAll()
            .Where(g => g.Id == id)
            .FirstOrDefaultAsync();

        if (group is null)
            throw new ZeemlinException(404, "User is not found");

        return _mapper.Map<GroupForResultDto>(group);
    }
}
