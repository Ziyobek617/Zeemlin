using Zeemlin.Service.DTOs.Assets.HomeworkAssets;

namespace Zeemlin.Service.Interfaces.Assets;

public interface IHomeworkAssetService
{
    Task<bool> RemoveAsync(long id);
    Task<HomeworkAssetForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<HomeworkAssetForResultDto>> RetrieveAllAsync();
    Task<HomeworkAssetForResultDto> UploadAsync(HomeworkAssetForCreationDto dto);
}
