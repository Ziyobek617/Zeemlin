using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class TeacherAssetService : ITeacherAssetService
{
    private readonly IMapper _mapper;
    private readonly ITeacherAssetRepository _repository;

    public TeacherAssetService(IMapper mapper, ITeacherAssetRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<bool> DeletePictureAsync(long teacherId)
    {
        var picture = await _repository.SelectAll()
            .AsNoTracking()
            .Where(p => p.TeacherId == teacherId)
            .FirstOrDefaultAsync();

        if (picture is null)
            throw new ZeemlinException(404, "Picture not found");

        await _repository.DeleteAsync(teacherId);
        return true;
    }

    public async Task<TeacherAssetForResultDto> UploadPictureAsync(TeacherAssetForUpdateDto dto)
    {
        // Get the teacher's gender
        var teacher = await _repository.SelectAll()
            .AsNoTracking()
            .Where(t => t.TeacherId == dto.TeacherId)
            .FirstOrDefaultAsync();

        if (teacher is null)
            throw new ZeemlinException(404, "Teacher not found");

        // Check for existing picture
        var existingPicture = await _repository.SelectAll()
            .AsNoTracking()
            .Where(p => p.TeacherId == dto.TeacherId)
            .FirstOrDefaultAsync();

        // Delete existing picture if present
        if (existingPicture != null)
        {
            await _repository.DeleteAsync(existingPicture.Id);
        }

        // Create new TeacherAsset entity
        var asset = new TeacherAsset
        {
            TeacherId = dto.TeacherId,
            Path = dto.File.ToString()
        };

        await _repository.InsertAsync(asset);

        var resultDto = _mapper.Map<TeacherAssetForResultDto>(asset);

        return resultDto;
    }

}
