using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

    public SchoolService(ISchoolRepository schoolRepository, IMapper mapper)
    {
        _schoolRepository = schoolRepository;
        _mapper = mapper;
    }


    public async Task<SchoolForResultDto> AddAsync(SchoolForCreationDto dto)
    {
        if (dto.SchoolNumber < 0)
        {
            throw new ZeemlinException(400, "Invalid school number");
        }

        var existingSchoolWithSameNumberAndStreet = await _schoolRepository
            .SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolNumber == dto.SchoolNumber
            && s.StreetName.Equals(dto.StreetName))
            .AnyAsync();

        if (existingSchoolWithSameNumberAndStreet)
            throw new ZeemlinException(409,
                "A school with the same number already exists on that street.");

        var school = _mapper.Map<School>(dto);
        school.CreatedAt = DateTime.UtcNow;
        await _schoolRepository.InsertAsync(school);

        return _mapper.Map<SchoolForResultDto>(school);
    }



    public async Task<SchoolForResultDto> ModifyAsync(long id, SchoolForUpdateDto dto)
    {
        var school = await _schoolRepository.SelectAll()
            .AsNoTracking()
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();

        if (school is null)
            throw new ZeemlinException(404, "School not found");

        var existingSchoolWithSameNumberAndStreet = await _schoolRepository
            .SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolNumber == dto.SchoolNumber
            && s.StreetName.Equals(dto.StreetName))
            .AnyAsync();

        if (existingSchoolWithSameNumberAndStreet)
            throw new ZeemlinException(409, "A school with the same number already exists on that street.");

        school.UpdatedAt = DateTime.UtcNow;
        var s = _mapper.Map(dto, school);
        await _schoolRepository.UpdateAsync(s);
        return _mapper.Map<SchoolForResultDto>(s);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var school = await _schoolRepository.SelectAll()
            .AsNoTracking()
            .Where(s => s.Id == id)
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
            .AsNoTracking()
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();
        if (school is null)
            throw new ZeemlinException(404, "School not found");

        return _mapper.Map<SchoolForResultDto>(school);
    }
}