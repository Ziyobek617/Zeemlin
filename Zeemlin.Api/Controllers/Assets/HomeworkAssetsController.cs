using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.DTOs.Assets.HomeworkAssets;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Api.Controllers.Assets;

public class HomeworkAssetsController : BaseController
{
    private readonly IHomeworkAssetService _homeworkAssetService;

    public HomeworkAssetsController(IHomeworkAssetService homeworkAssetService)
    {
        _homeworkAssetService = homeworkAssetService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] HomeworkAssetForCreationDto dto)
            => Ok(await _homeworkAssetService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _homeworkAssetService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute(Name = "id")] long id)
        => Ok(await _homeworkAssetService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _homeworkAssetService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromForm] HomeworkAssetForUpdateDto dto)
        => Ok(await this._homeworkAssetService.ModifyAsync(id, dto));
}
