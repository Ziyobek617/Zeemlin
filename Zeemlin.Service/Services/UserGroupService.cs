using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.UserGroup;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class UserGroupService : IUserGroupService
{
    private readonly IMapper _mapper;
    private readonly IRepository<StudentGroup> _usergroupRepository;

    public UserGroupService(IMapper mapper, IRepository<StudentGroup> usergroupRepository)
    {
        _mapper = mapper;
        _usergroupRepository = usergroupRepository;
    }

    public async Task<UserGroupForResultDto> CreateAsync(UserGroupForCreationDto dto)
    {
        var ug = await _usergroupRepository.SelectAll()
            .Where(ug => ug.GroupId == dto.GroupId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (ug is not null)
            throw new ZeemlinException(409, "User is already exist");

        var mappedUsergroup = _mapper.Map<StudentGroup>(dto);
        mappedUsergroup.CreatedAt = DateTime.UtcNow;

        var createdUsergroup = await _usergroupRepository.InsertAsync(mappedUsergroup);
        return _mapper.Map<UserGroupForResultDto>(mappedUsergroup);
    }

    public async Task<UserGroupForResultDto> ModifyAsync(long id, UserGroupForUpdateDto dto)
    {
        var user = await _usergroupRepository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User not found");

        user.UpdatedAt = DateTime.UtcNow;
        var person = _mapper.Map(dto, user);

        await _usergroupRepository.UpdateAsync(person);

        return _mapper.Map<UserGroupForResultDto>(person);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await _usergroupRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        await _usergroupRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<UserGroupForResultDto>> RetrieveAllAsync()
    {
        var usergroup = await _usergroupRepository.SelectAll()
            .Include(ug => ug.Users)
            .Include(ug => ug.Group)
            .ToListAsync();


        return _mapper.Map<IEnumerable<UserGroupForResultDto>>(usergroup);
    }

    public async Task<UserGroupForResultDto> RetrieveIdAsync(long id)
    {
        var users = await _usergroupRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (users is null)
            throw new ZeemlinException(404, "User is not found");

        return _mapper.Map<UserGroupForResultDto>(users);
    }
}
