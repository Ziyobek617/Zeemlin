using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class GradesController : BaseController
{
    private readonly IGradeService _gradeService;

    public GradesController(IGradeService gradeService)
    {
        _gradeService = gradeService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] GradeForCreationDto dto)
        => Ok(await this._gradeService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._gradeService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._gradeService.RetrieveIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._gradeService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] GradeForUpdateDto dto)
        => Ok(await this._gradeService.ModifyAsync(id, dto));
}
