using Microsoft.AspNetCore.Http;
using Zeemlin.Service.DTOs.Assets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ITeacherAssetService
{
    Task<TeacherAssetForResultDto> UploadPictureAsync(TeacherAssetForUpdateDto dto);
    Task<bool> DeletePictureAsync(long teacherId);
}


