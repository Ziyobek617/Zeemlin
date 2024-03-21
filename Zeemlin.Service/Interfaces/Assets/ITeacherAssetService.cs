using Microsoft.AspNetCore.Http;
using Zeemlin.Service.DTOs.Assets.HomeworkAssets;
using Zeemlin.Service.DTOs.Assets.TeacherAssets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ITeacherAssetService
{
    Task<bool> DeletePictureAsync(long teacherId);
    Task<TeacherAssetForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<TeacherAssetForResultDto>> RetrieveAllAsync();
    Task<TeacherAssetForResultDto> UploadAsync(TeacherAssetForCreationDto dto);
}


