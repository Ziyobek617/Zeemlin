using AutoMapper;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Data.Repositories.Users;
using Zeemlin.Domain.Entities.Users;
using Zeemlin.Service.DTOs.Users.Admins;
using Zeemlin.Service.DTOs.Users.Directors;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Service.Services.Users;

public class DirectorService : IDirectorService
{
    private readonly IMapper _mapper;
    private readonly IDirectorRepository _repository;

    public DirectorService(IMapper mapper, IDirectorRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<DirectorForResultDto> CreateAsync(DirectorForCreationDto dto)
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

        var IsValidUserPhoneNumber = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PhoneNumber == dto.PhoneNumber)
            .FirstOrDefaultAsync();

        if (IsValidUserPhoneNumber is not null)
            throw new ZeemlinException(409, "Phone number already exists");

        var IsValidPassportSeria = await _repository
            .SelectAll()
            .AsNoTracking()
            .Where(u => u.PassportSeria == dto.PassportSeria)
            .FirstOrDefaultAsync();

        if (IsValidPassportSeria is not null)
            throw new ZeemlinException(409, "PassportSeria already exists");

        var mapped = _mapper.Map<Director>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        await _repository.InsertAsync(mapped);

        return _mapper.Map<DirectorForResultDto>(mapped);
    }

    public async Task<DirectorForResultDto> ModifyAsync(long id, DirectorForUpdateDto dto)
    {
        var IsValidId = await _repository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        var mapped = _mapper.Map(dto, IsValidId);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mapped);

        return _mapper.Map<DirectorForResultDto>(mapped);
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

    public async Task<IEnumerable<DirectorForResultDto>> RetrieveAllAsync()
    {
        var Directors = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<DirectorForResultDto>>(Directors);

    }

    public async Task<DirectorForResultDto> RetrieveByIdAsync(long id)
    {
        var IsValidId = await _repository
            .SelectAll().AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();

        if (IsValidId is null)
            throw new ZeemlinException(404, "Not Found");

        return _mapper.Map<DirectorForResultDto>(IsValidId);
    }

    public async Task<List<Director>> RetrieveByUsernameAsync(string search, AppDbContext context)
    {
        var query = context.Directors.Where(a =>
            a.Username.Contains(search) ||
            a.PassportSeria.Contains(search) ||
            a.Email.Contains(search) ||
            a.PhoneNumber.Contains(search));
        return await query.ToListAsync();
    }
}
