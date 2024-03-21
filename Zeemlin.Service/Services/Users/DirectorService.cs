using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities.Users;
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
        var directors = await _repository.SelectAll().AsNoTracking().ToListAsync();

        return _mapper.Map<IEnumerable<DirectorForResultDto>>(directors);
    }




    public async Task<DirectorForResultDto> RetrieveByIdAsync(long id)
    {
        var director = await _repository.SelectAll()
            .Include(d => d.Schools) 
            .AsNoTracking()
            .Where(d => d.Id == id)
            .FirstOrDefaultAsync();

        if (director is null)
            throw new ZeemlinException(404, "Not Found");

        return new DirectorForResultDto
        {
            Id = director.Id,
            Username = director.Username,
            FirstName = director.FirstName,
            LastName = director.LastName,
            Email = director.Email,
            PhoneNumber = director.PhoneNumber,
            Gender = director.Gender.ToString(),
            PassportSeria = director.PassportSeria,
            schools = director.Schools != null ? director.Schools.Select(s => new SchoolForDirectorDto
            {
                Id = s.Id,
                SchoolNumber = s.SchoolNumber,
                SchoolType = s.SchoolType.ToString(),
                Name = s.Name,
                Region = s.Region.ToString(),
                DistrictName = s.DistrictName,
                GeneralAddressMFY = s.GeneralAddressMFY,
                StreetName = s.StreetName
            }).ToList() : null
        };
    }


    public async Task<IEnumerable<DirectorForResultDto>> RetrieveByUsernameAsync(string search, AppDbContext context)
    {
        // Use Include method for eager loading
        var directors = await context.Directors
            .Include(d => d.Schools) // Include the School navigation property
            .AsNoTracking()
            .Where(a =>
                a.Username.Contains(search) ||
                a.PassportSeria.Contains(search) ||
                a.Email.Contains(search) ||
                a.PhoneNumber.Contains(search))
            .ToListAsync();

        if (!directors.Any()) // Check if any directors found
        {
            throw new ZeemlinException(404, "Not Found");
        }

        // Map to DirectorForResultDto with SchoolForDirectorDto
        return directors.Select(director => new DirectorForResultDto
        {
            Id = director.Id,
            Username = director.Username,
            FirstName = director.FirstName,
            LastName = director.LastName,
            Email = director.Email,
            PhoneNumber = director.PhoneNumber,
            Gender = director.Gender.ToString(),
            PassportSeria = director.PassportSeria,
            schools = director.Schools != null ? director.Schools.Select(s => new SchoolForDirectorDto
            {
                Id = s.Id,
                SchoolNumber = s.SchoolNumber,
                SchoolType = s.SchoolType.ToString(),
                Name = s.Name,
                Region = s.Region.ToString(),
                DistrictName = s.DistrictName,
                GeneralAddressMFY = s.GeneralAddressMFY,
                StreetName = s.StreetName
            }).ToList() : null
        });
    }

}
