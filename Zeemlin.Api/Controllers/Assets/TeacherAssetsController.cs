using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Assets.TeacherAssets;
using Zeemlin.Service.Interfaces.Assets;
using Zeemlin.Service.Services.Assets;

namespace Zeemlin.Api.Controllers.Assets
{

    public class TeacherAssetsController : BaseController
    {
        private readonly ITeacherAssetService _assetService;

        public TeacherAssetsController(ITeacherAssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] TeacherAssetForCreationDto dto)
            => Ok(await _assetService.UploadAsync(dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await _assetService.DeletePictureAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        => Ok(await _assetService.RetrieveAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute(Name = "id")] long id)
            => Ok(await _assetService.RetrieveByIdAsync(id));
    }
}
