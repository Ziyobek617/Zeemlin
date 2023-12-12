using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.DTOs.GroupRole;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GroupRoleService : IGroupRoleService
{
    private readonly IMapper _mapper;
    private readonly IGroupRoleRepository _groupRoleRepository;

    public GroupRoleService(IMapper mapper, IGroupRoleRepository groupRoleRepository)
    {
        _mapper = mapper;
        _groupRoleRepository = groupRoleRepository;
    }

    public async Task<GroupRoleForResultDto> CreateAsync(Role chatRole)
    {
        var groupRole = await _groupRoleRepository.SelectAll()
            .Where(gr => gr.Role == chatRole)
            .FirstOrDefaultAsync();

        if (groupRole is not null)
            throw new ZeemlinException(409, "grouprole is already exixts");

        var mappedGroupRole = new GroupRole()
        {
            Role = chatRole,
            CreatedAt = DateTime.UtcNow
        };
        var addedGroupRole = await _groupRoleRepository.InsertAsync(mappedGroupRole);

        return _mapper.Map<GroupRoleForResultDto>(addedGroupRole);
    }

    public async Task<GroupRoleForResultDto> ModifyAsync(long id, Role chatRole)
    {
        var groupRole = await _groupRoleRepository.SelectAll()
            .Where(gr => gr.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (groupRole is null)
            throw new ZeemlinException(404, "GroupRole not found");

        var result = new GroupRole()
        {
            Id = id,
            Role = chatRole,
            UpdatedAt = DateTime.UtcNow
        };

        await _groupRoleRepository.UpdateAsync(result);

        return _mapper.Map<GroupRoleForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var groupRole = await _groupRoleRepository.SelectAll()
            .Where(gr => gr.Id == id)
            .FirstOrDefaultAsync();
        if (groupRole is null)
            throw new ZeemlinException(404, "GroupRole is not found");

        await _groupRoleRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<GroupRoleForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var groupRoles = await _groupRoleRepository.SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<GroupRoleForResultDto>>(groupRoles);
    }

    public async Task<GroupRoleForResultDto> RetrieveByIdAsync(long id)
    {
        var groupRole = await _groupRoleRepository.SelectAll()
            .Where(gr => gr.Id == id)
            .FirstOrDefaultAsync();
        if (groupRole is null)
            throw new ZeemlinException(404, "GroupRole is not found");

        return _mapper.Map<GroupRoleForResultDto>(groupRole);
    }
}
