using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Users.SuperAdmins;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Service.Services.Users;

public class SuperAdminService : ISuperAdminService
{
    private readonly IMapper _mapper;
    private readonly ISuperAdminRepository _repository;
    public SuperAdminService(ISuperAdminRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SuperAdminForResultDto> CreateAsync(SuperAdminForCreationDto dto)
    {
        var IsValidUsername = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Username.ToLower() == dto.Username.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUsername is not null)
            throw new ZeemlinException(409, "Username already exists");

        var IsValidUserEmail = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUserEmail is not null)
            throw new ZeemlinException(409, "Email already exists");

        var IsValidPassportSeria = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PassportSeria == dto.PassportSeria)
            .FirstOrDefaultAsync();

        if (IsValidPassportSeria is not null)
            throw new ZeemlinException(409, "PassportSeria already exists");


        var mapped = _mapper.Map<SuperAdmin>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        await _repository.InsertAsync(mapped);

        return _mapper.Map<SuperAdminForResultDto>(mapped);
    }

    public async Task<SuperAdminForResultDto> ModifyAsync(long id, SuperAdminForUpdateDto dto)
    {
        var IsValidId = await _repository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        var IsValidUsername = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Username.ToLower() == dto.Username.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUsername is not null)
            throw new ZeemlinException(409, "Username already exists");

        var IsValidUserEmail = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUserEmail is not null)
            throw new ZeemlinException(404, "Email not found");

        var IsValidPassportSeria = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PassportSeria == dto.PassportSeria)
            .FirstOrDefaultAsync();

        if (IsValidPassportSeria is not null)
            throw new ZeemlinException(404, "PassportSeria already exists");

        var mapped = _mapper.Map(dto, IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mapped);

        return _mapper.Map<SuperAdminForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var IsValidId = await _repository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<SuperAdminForResultDto>> RetrieveAllAsync()
    {
        var SuperAdmins = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<SuperAdminForResultDto>>(SuperAdmins);
    }

    public async Task<SuperAdminForResultDto> RetrieveByIdAsync(long id)
    {
        var IsValidId = await _repository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        return _mapper.Map<SuperAdminForResultDto>(IsValidId);
    }
}
