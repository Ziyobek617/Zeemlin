using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Sciences;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class ScienceService : IScienceService
{
    private readonly IMapper _mapper;
    private readonly IScienceRepository _repository;

    public ScienceService(IMapper mapper, IScienceRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ScienceForResultDto> AddAsync(ScienceForCreationDto dto)
    {
        var science = _mapper.Map<Science>(dto);
        science.CreatedAt = DateTime.UtcNow;
        await _repository.InsertAsync(science);

        return _mapper.Map<ScienceForResultDto>(science);
    }

    public async Task<ScienceForResultDto> ModifyAsync(long id, ScienceForUpdateDto dto)
    {
        var modigyScience = await _repository.SelectAll()
            .AsNoTracking() // Apply AsNoTracking first
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();

        if (modigyScience is null)
            throw new ZeemlinException(404, "Science not found");

        // Update entity properties
        var mappedscience = _mapper.Map(dto, modigyScience);
        mappedscience.UpdatedAt = DateTime.UtcNow;
        await _repository.UpdateAsync(mappedscience);

        return _mapper.Map<ScienceForResultDto>(mappedscience);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var modigyScience = await _repository.SelectAll()
            .AsNoTracking() // Apply AsNoTracking first
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();

        if (modigyScience is null)
            throw new ZeemlinException(404, "Science not found");

        await _repository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<ScienceForResultDto>> RetrieveAllAsync()
    {
        var sciences = await _repository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<ScienceForResultDto>>(sciences);
    }   

    public async Task<ScienceForResultDto> RetrieveByIdAsync(long id)
    {
        var modigyScience = await _repository.SelectAll()
            .AsNoTracking() // Apply AsNoTracking first
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();

        if (modigyScience is null)
            throw new ZeemlinException(404, "Science not found");

        return _mapper.Map<ScienceForResultDto>(modigyScience);
    }
}
