using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;
using Zeemlin.Service.DTOs.Schools;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class SchoolService : ISchoolService
{
    private readonly IMapper _mapper;
    private readonly ISchoolRepository _schoolRepository;
    private readonly IDirectorRepository _directorRepository;

    public SchoolService(
        IMapper mapper,
        ISchoolRepository schoolRepository,
        IDirectorRepository directorRepository)
    {
        _mapper = mapper;
        _schoolRepository = schoolRepository;
        _directorRepository = directorRepository;
    }


    public async Task<SchoolForResultDto> AddAsync(SchoolForCreationDto dto)
    {
        if (dto.SchoolNumber <= 0)
        {
            throw new ZeemlinException(400, "Invalid school number");
        }

        var existingSchoolWithSameNumberAndStreet = await _schoolRepository
            .SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolNumber == dto.SchoolNumber
            && s.DistrictName.ToLower().Equals(dto.DistrictName.ToLower()))
            .AnyAsync();

        if (existingSchoolWithSameNumberAndStreet)
            throw new ZeemlinException(409,
                "A school with the same number already exists on that street.");

        var director = await _directorRepository.SelectAll()
            .Where(d => d.Id == dto.DirectorId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (director is null)
            throw new ZeemlinException(404, "Director not found");

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

        if (dto.SchoolNumber < 0)
            throw new ZeemlinException(400, "Invalid school number");

        var existingSchoolWithSameNumberAndStreet = await _schoolRepository
            .SelectAll()
            .AsNoTracking()
            .Where(s => s.SchoolNumber == dto.SchoolNumber
            && s.DistrictName.ToLower().Equals(dto.DistrictName.ToLower()))
            .AnyAsync();

        if (existingSchoolWithSameNumberAndStreet)
            throw new ZeemlinException
                (409, $"A school with the same {school.SchoolNumber} already exists on that {school.DistrictName} district.");

        var director = await _directorRepository.SelectAll()
            .Where(d => d.Id == dto.DirectorId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (director is null)
            throw new ZeemlinException(404, "Director not found");

        var mapped = _mapper.Map(dto, school);
        mapped.UpdatedAt = DateTime.UtcNow;
        await _schoolRepository.UpdateAsync(mapped);

        return _mapper.Map<SchoolForResultDto>(mapped);
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
        var query = _schoolRepository.SelectAll()
          .Include(s => s.SchoolLogoAsset) // Include SchoolLogoAsset in the query
          .AsNoTracking();

        var schools = await query.ToListAsync();

        // Project schools and include SchoolLogoAsset information using AutoMapper
        var schoolDtos = schools.Select(school =>
        {
            var schoolDto = _mapper.Map<SchoolForResultDto>(school);

            // Handle SchoolLogoAsset (avoid cyclical references during serialization)
            schoolDto.SchoolLogoAsset = school.SchoolLogoAsset != null ? _mapper.Map<SchoolLogoAssetForResultDto>(school.SchoolLogoAsset) : null;

            return schoolDto;
        });

        return schoolDtos;
    }


    public async Task<SchoolForResultDto> RetrieveByIdAsync(long id)
    {
        var school = await _schoolRepository.SelectAll()
          .Include(s => s.SchoolLogoAsset) // Include SchoolLogoAsset in the query
          .AsNoTracking()
          .Where(s => s.Id == id)
          .FirstOrDefaultAsync();

        if (school is null)
        {
            throw new ZeemlinException(404, "School not found");
        }

        // Map School to SchoolForResultDto
        var schoolDto = _mapper.Map<SchoolForResultDto>(school);

        // If SchoolLogoAsset exists, map it to SchoolLogoAssetForResultDto
        schoolDto.SchoolLogoAsset = school.SchoolLogoAsset != null ? _mapper.Map<SchoolLogoAssetForResultDto>(school.SchoolLogoAsset) : null;

        return schoolDto;
    }


    public async Task<IEnumerable<SchoolForResultDto>> FilterByRegionAsync(Region region, SchoolType? schoolType = null)
    {
        var query = _schoolRepository.SelectAll()
          .Include(s => s.SchoolLogoAsset) // Include SchoolLogoAsset in the query
          .AsNoTracking()
          .Where(s => s.Region == region);

        // Apply school type filter (optional)
        if (schoolType != null)
        {
            query = query.Where(s => s.SchoolType == schoolType);
        }

        var schools = await query.ToListAsync();

        // Project schools and include SchoolLogoAsset information using AutoMapper
        var schoolDtos = schools.Select(school =>
        {
            var schoolDto = _mapper.Map<SchoolForResultDto>(school);

            // Handle SchoolLogoAsset (avoid cyclical references during serialization)
            schoolDto.SchoolLogoAsset = school.SchoolLogoAsset != null ? _mapper.Map<SchoolLogoAssetForResultDto>(school.SchoolLogoAsset) : null;

            return schoolDto;
        });

        return schoolDtos;
    }




}