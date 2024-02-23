using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;
using Zeemlin.Service.DTOs.Users.Admins;
using Zeemlin.Service.DTOs.Users.SuperAdmins;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Service.Services.Users;

public class AdminService : IAdminService
{
    private readonly IMapper _mapper;

    private readonly IAdminRepository _adminRepository;
    public AdminService(IMapper mapper, IAdminRepository adminRepository)
    {
        _mapper = mapper;
        _adminRepository = adminRepository;
    }

    public async Task<AdminForResultDto> CreateAsync(AdminForCreationDto dto)
    {
        var IsValidUsername = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Username.ToLower() == dto.Username.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUsername is not null)
            throw new ZeemlinException(409, "Username already exists");

        var IsValidUserEmail = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUserEmail is not null)
            throw new ZeemlinException(409, "Email already exists");

        var IsValidPassportSeria = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PassportSeria == dto.PassportSeria)
            .FirstOrDefaultAsync();

        if (IsValidPassportSeria is not null)
            throw new ZeemlinException(409, "PassportSeria already exists");

        //var IsValidSchoolNumber = await _adminRepository
        //    .SelectAll()
        //    .AsNoTracking()
        //    .Where(s => s.SchoolId == dto.SchoolId)
        //    .FirstOrDefaultAsync();

        //if (IsValidSchoolNumber is not null)
        //    throw new ZeemlinException(409, "School already exists");


        var mapped = _mapper.Map<Admin>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        await _adminRepository.InsertAsync(mapped);

        return _mapper.Map<AdminForResultDto>(mapped);
    }

    public async Task<AdminForResultDto> ModifyAsync(long id, AdminForUpdateDto dto)
    {
        var IsValidId = await _adminRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        var IsValidUsername = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Username.ToLower() == dto.Username.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUsername is not null)
            throw new ZeemlinException(409, "Username Not Found");

        var IsValidUserEmail = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .FirstOrDefaultAsync();

        if (IsValidUserEmail is not null)
            throw new ZeemlinException(404, "Email not found");

        var IsValidPassportSeria = await _adminRepository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PassportSeria == dto.PassportSeria)
            .FirstOrDefaultAsync();

        if (IsValidPassportSeria is not null)
            throw new ZeemlinException(404, "PassportSeria Not Found");

        //var IsValidSchoolNumber = await _adminRepository
        //    .SelectAll()
        //    .AsNoTracking()
        //    .Where(s => s.SchoolId == dto.SchoolId)
        //    .FirstOrDefaultAsync();

        //if (IsValidSchoolNumber is null)
        //    throw new ZeemlinException(404, "School Not Found");

        var mapped = _mapper.Map(dto, IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _adminRepository.UpdateAsync(mapped);

        return _mapper.Map<AdminForResultDto>(mapped);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var IsValidId = await _adminRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        await _adminRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<AdminForResultDto>> RetrieveAllAsync()
    {
        var SuperAdmins = await _adminRepository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<AdminForResultDto>>(SuperAdmins);
    }

    public async Task<AdminForResultDto> RetrieveByIdAsync(long id)
    {
        var IsValidId = await _adminRepository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        return _mapper.Map<AdminForResultDto>(IsValidId);
    }
}
