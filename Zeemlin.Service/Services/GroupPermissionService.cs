using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.DTOs.GroupPermissions;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GroupPermissionService : IGroupPermissionService
{
    private readonly IMapper _mapper;

    private readonly IGroupPermissionRepository _groupPermissionRepository;
    public GroupPermissionService(IMapper mapper, IGroupPermissionRepository groupPermissionRepository)
    {
        _mapper = mapper;
        _groupPermissionRepository = groupPermissionRepository;
    }

    public async Task<GroupPermissionForResultDto> CreateAsync(GroupPermissionType Type)
    {
        var groupPermission = await _groupPermissionRepository.SelectAll()
            .Where(gp => gp.PermissionType == Type)
            .FirstOrDefaultAsync();

        if (groupPermission is not null)
            throw new ZeemlinException(409, "GroupPermission already exist");

        var mappedGroupPermission = new GroupPermission()
        {
            PermissionType = Type,
            CreatedAt = DateTime.UtcNow,
        };

        var result = await _groupPermissionRepository.InsertAsync(mappedGroupPermission);

        return _mapper.Map<GroupPermissionForResultDto>(result);
    }

    public async Task<GroupPermissionForResultDto> ModifyAsync(long id, GroupPermissionType Type)
    {
        var groupPermission = await _groupPermissionRepository.SelectAll()
            .Where(gp => gp.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (groupPermission is null)
            throw new ZeemlinException(404, "groupPermission is not found");

        var mappedGroupPermission = new GroupPermission()
        {
            Id = id,
            PermissionType = Type,
            UpdatedAt = DateTime.UtcNow,
        };
        var mapped = await _groupPermissionRepository.UpdateAsync(mappedGroupPermission);

        return _mapper.Map<GroupPermissionForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var groupPermission = await _groupPermissionRepository.SelectAll()
            .Where(gp => gp.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (groupPermission is null)
            throw new ZeemlinException(404, "group permission is not found");

        await _groupPermissionRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<GroupPermissionForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var groupPermissions = await _groupPermissionRepository.SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<GroupPermissionForResultDto>>(groupPermissions);
    }

    public async Task<GroupPermissionForResultDto> RetrieveByIdAsync(long id)
    {
        var groupPermission = await _groupPermissionRepository.SelectAll()
            .Where(gp => gp.Id == id)
            .FirstOrDefaultAsync();

        if (groupPermission is null)
            throw new ZeemlinException(404, "GroupPermission is not found");

        return _mapper.Map<GroupPermissionForResultDto>(groupPermission);
    }
}
