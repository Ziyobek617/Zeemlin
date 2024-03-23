using Zeemlin.Service.DTOs.Assets.EventAssets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface IEventAssetService
{
    Task<bool> DeletePictureAsync(long Id);
    Task<EventAssetForResultDto> RetrieveByIdAsync(long Id);
    Task<IEnumerable<EventAssetForResultDto>> RetrieveAllAsync();
    Task<EventAssetForResultDto> UploadAsync(EventAssetForCreationDto dto);
}
