using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zeemlin.Api.Controllers.Assets;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Service.DTOs.Assets;
using Zeemlin.Service.Interfaces.Assets;
using Zeemlin.Service.Exceptions;

namespace Zeemlin.Api.Controllers.Assets
{

    public class TeacherAssetsController : BaseController
    {
        private readonly ITeacherAssetService _assetService;
        private readonly IMapper _mapper;

        public TeacherAssetsController(ITeacherAssetService assetService, IMapper mapper)
        {
            _assetService = assetService;
            _mapper = mapper;
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long Id, [FromForm] TeacherAssetForUpdateDto dto)
            => Ok(this._assetService.UpdatePictureAsync(Id,dto));

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long teacherId)
            => Ok(this._assetService.DeletePictureAsync(teacherId));
    }
}
