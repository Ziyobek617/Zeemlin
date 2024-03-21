using Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface ISchoolLogoAssetService
{
    Task<bool> DeletePictureAsync(long Id);
    Task<SchoolLogoAssetForResultDto> RetrieveByIdAsync(long Id);
    Task<IEnumerable<SchoolLogoAssetForResultDto>> RetrieveAllAsync();
    Task<SchoolLogoAssetForResultDto> UploadAsync(SchoolLogoAssetForCreationDto dto);
}
