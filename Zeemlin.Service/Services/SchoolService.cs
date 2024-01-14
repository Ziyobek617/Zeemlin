using AutoMapper;
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
        // Comprehensive validation:
        if (string.IsNullOrEmpty(dto.Name))
        {
            throw new ZeemlinException(400, "School name is required");
        }

        if (dto.SchoolNumber <= 0)
        {
            throw new ZeemlinException(400, "Invalid school number");
        }

        // ... Add more validation rules as needed, e.g., for description length, phone number format, email validity ...

        // Check for duplicate school number (optional, based on your requirements):
        if (await _schoolRepository.ExistsAsync(dto.SchoolNumber))
        {
            throw new ZeemlinException(400, "School with the same number already exists");
        }

        // Map DTO to entity:
        var school = _mapper.Map<School>(dto);

        // Set default values or apply additional logic if needed:
        school.CreatedAt = DateTime.UtcNow;
        school.UpdatedAt = DateTime.UtcNow; // Consider tracking updates as well
                                            // ... other defaults or logic ...

        // Insert the school:
        await _schoolRepository.InsertAsync(school);

        // Map back to result DTO:
        return _mapper.Map<SchoolForResultDto>(school);
    }


    public async Task<SchoolForResultDto> ModifyAsync(long id, SchoolForUpdateDto dto)
    {
        var school = await _schoolRepository.Re(id);
        if (school == null)
        {
            throw new ZeemlinException(404, "School not found");
        }

        _mapper.Map(dto, school);
        // Apply any specific update logic or validation
        await _schoolRepository.UpdateAsync(school);
        return _mapper.Map<SchoolForResultDto>(school);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var school = await _schoolRepository.RetrieveByIdAsync(id);
        if (school == null)
        {
            throw new ZeemlinException(404, "School not found");
        }

        await _schoolRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<SchoolForResultDto>> RetrieveAllAsync()
    {
        var schools = await _schoolRepository.RetrieveAllAsync();
        return _mapper.Map<IEnumerable<SchoolForResultDto>>(schools);
    }

    public async Task<SchoolForResultDto> RetrieveByIdAsync(long id)
    {
        var school = await _schoolRepository.RetrieveByIdAsync(id);
        if (school == null)
        {
            throw new ZeemlinException(404, "School not found");
        }

        return _mapper.Map<SchoolForResultDto>(school);
    }
}

