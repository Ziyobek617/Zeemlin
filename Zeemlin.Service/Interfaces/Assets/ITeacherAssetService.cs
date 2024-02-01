using Microsoft.AspNetCore.Http;
using Zeemlin.Service.DTOs.Assets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ITeacherAssetService
{
    Task<TeacherAssetForResultDto> AddOrUpdatePictureAsync(TeacherAssetForCreationDto dto);
    Task<TeacherAssetForResultDto> GetPictureByIdAsync(long teacherId);
    Task DeletePictureAsync(long teacherId);
}

