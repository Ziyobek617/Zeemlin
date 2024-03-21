using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Api.Controllers.Assets;

public class SchoolLogoAssetsController : BaseController
{
    private readonly ISchoolLogoAssetService _schoolLogoAssetService;

    public SchoolLogoAssetsController(ISchoolLogoAssetService schoolLogoAssetService)
    {
        _schoolLogoAssetService = schoolLogoAssetService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] SchoolLogoAssetForCreationDto dto)
    => Ok(await _schoolLogoAssetService.UploadAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _schoolLogoAssetService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute(Name = "id")] long id)
        => Ok(await _schoolLogoAssetService.RetrieveByIdAsync(id));


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _schoolLogoAssetService.DeletePictureAsync(id));
}
