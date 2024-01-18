using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Schools;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class SchoolService : ISchoolService
{
    private readonly ISchoolRepository _schoolRepository;
    private readonly IMapper _mapper;
    private readonly AppDbContext _dbContext;

    public SchoolService(ISchoolRepository schoolRepository, IMapper mapper, AppDbContext dbContext)
    {
        _schoolRepository = schoolRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }


    public async Task<SchoolForResultDto> AddAsync(SchoolForCreationDto dto)
    {
        // Validation:
        if (string.IsNullOrEmpty(dto.Name))
        {
            throw new ZeemlinException(400, "School name is required");
        }

        if (dto.SchoolNumber < 0)
        {
            throw new ZeemlinException(400, "Invalid school number");
        }

        // Check for duplicate email:
        var existingSchoolWithEmail = await _schoolRepository
            .SelectAll()
            .Where(e => e.Email.ToLower() == dto.Email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (existingSchoolWithEmail != null)
        {
            throw new ZeemlinException(409, "Email is already in use.");
        }

        // Check for duplicate school number (optional):
        if (await _schoolRepository.ExistsAsync(dto.SchoolNumber))
        {
            throw new ZeemlinException(400, "School with the same number already exists");
        }

        // Map DTO to entity:
        var school = _mapper.Map<School>(dto);

        // Set default values:
        school.CreatedAt = DateTime.UtcNow;

        // Insert the school:
        await _schoolRepository.InsertAsync(school);

        // Map back to result DTO:
        return _mapper.Map<SchoolForResultDto>(school);
    }



    public async Task<SchoolForResultDto> ModifyAsync(long id, SchoolForUpdateDto dto)
    {
        var school = await _schoolRepository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (school is null)
            throw new ZeemlinException(404, "School not found");

        school.UpdatedAt = DateTime.UtcNow;
        var s = _mapper.Map(dto, school);
        await _schoolRepository.UpdateAsync(s);
        return _mapper.Map<SchoolForResultDto>(s);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var school = await _schoolRepository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (school is null)
            throw new ZeemlinException(404, "School not found");

        await _schoolRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<SchoolForResultDto>> RetrieveAllAsync()
    {
        var schools = await _schoolRepository.SelectAll().ToListAsync();
        return _mapper.Map<IEnumerable<SchoolForResultDto>>(schools);
    }

    public async Task<SchoolForResultDto> RetrieveByIdAsync(long id)
    {
        var school = await _schoolRepository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (school is null)
            throw new ZeemlinException(404, "School not found");

        return _mapper.Map<SchoolForResultDto>(school);
    }
}

