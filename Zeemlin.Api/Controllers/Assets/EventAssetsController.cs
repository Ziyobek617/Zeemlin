using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Assets.EventAssets;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Api.Controllers.Assets;

public class EventAssetsController : BaseController
{
    private readonly IEventAssetService _eventAssetService;

    public EventAssetsController(IEventAssetService eventAssetService)
    {
        _eventAssetService = eventAssetService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] EventAssetForCreationDto dto)
    => Ok(await _eventAssetService.UploadAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _eventAssetService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute(Name = "id")] long id)
        => Ok(await _eventAssetService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _eventAssetService.DeletePictureAsync(id));
}
