using Zeemlin.Service.DTOs.Assets.SchoolAssets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ISchoolAssetService
{
    Task<bool> DeletePictureAsync(long Id);
    Task<SchoolAssetForResultDto> RetrieveByIdAsync(long Id);
    Task<IEnumerable<SchoolAssetForResultDto>> RetrieveAllAsync();
    Task<SchoolAssetForResultDto> UploadAsync(SchoolAssetForCreationDto dto);
}
