using Zeemlin.Service.DTOs.Assets.HomeworkAssets;
using Zeemlin.Service.DTOs.Sciences;

namespace Zeemlin.Service.Interfaces.Assets;

public interface IHomeworkAssetService
{
    Task<bool> RemoveAsync(long id);
    Task<HomeworkAssetForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<HomeworkAssetForResultDto>> RetrieveAllAsync();
    Task<HomeworkAssetForResultDto> UploadAsync(HomeworkAssetForCreationDto dto);
}
