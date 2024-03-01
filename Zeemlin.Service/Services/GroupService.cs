using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class GroupService : IGroupService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Group> _groupRepository;
    private readonly AppDbContext _context;


    public GroupService(IRepository<Group> repository, IMapper mapper, AppDbContext context)
    {
        _mapper = mapper;
        _groupRepository = repository;
        _context = context;
    }

    public async Task<GroupForResultDto> CreateAsync(GroupForCreationDto dto)
    {
        var groupTeacherId = await _context
            .Teachers
            .FirstOrDefaultAsync(t => t.Id == dto.HeadTeacherId);

        if (groupTeacherId is null)
            throw new ZeemlinException(404, "Teacher Not Found");

        //var groupSchoolId = await _groupRepository
        //    .SelectAll()
        //    .AsNoTracking()
        //    .Where(t => t.SchoolId == dto.SchoolId)
        //    .FirstOrDefaultAsync();

        //if (groupSchoolId is not null)
            //throw new ZeemlinException(404, "School Not Found");

        //var IsValidGroupInSchool = await _groupRepository.SelectAll()
        //    .Where(g=> g.Name.ToLower() == dto.Name.ToLower() 
        //    && g.SchoolId == dto.SchoolId)
        //    .FirstOrDefaultAsync();

        //if (IsValidGroupInSchool is not null)
        //    throw new ZeemlinException(409, "Group name already exists in School");

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

        var groupName = await _groupRepository.SelectAll()
            .Where(g => g.Name.ToLower() == dto.Name.ToLower())
            .FirstOrDefaultAsync();

        if (groupName is not null)
            throw new ZeemlinException(409, "Group name already exists");

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
}
