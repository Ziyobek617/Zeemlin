using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Assets.SchoolAssets;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Api.Controllers.Assets;

public class SchoolAssetsController : BaseController
{
    private readonly ISchoolAssetService _schoolAssetService;

    public SchoolAssetsController(ISchoolAssetService schoolAssetService)
    {
        _schoolAssetService = schoolAssetService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] SchoolAssetForCreationDto dto)
    => Ok(await _schoolAssetService.UploadAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _schoolAssetService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute(Name = "id")] long id)
        => Ok(await _schoolAssetService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _schoolAssetService.DeletePictureAsync(id));
}
