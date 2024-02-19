using Microsoft.AspNetCore.Http;
using Zeemlin.Service.DTOs.Assets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ITeacherAssetService
{
    Task UpdatePictureAsync(long assetId, TeacherAssetForUpdateDto dto);
    Task<bool> DeletePictureAsync(long teacherId);
}


