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

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] GradeForCreationDto dto)
        => Ok(await this._gradeService.CreateAsync(dto));

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._gradeService.RetrieveAllAsync());

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._gradeService.RetrieveIdAsync(id));

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._gradeService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] GradeForUpdateDto dto)
        => Ok(await this._gradeService.ModifyAsync(id, dto));
}
