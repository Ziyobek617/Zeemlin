using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.ScienceTeachers;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers.Users;

public class ScienceTeachersController : BaseController
{
    private readonly IScienceTeacherService _scienceTeacherService;

    public ScienceTeachersController(IScienceTeacherService scienceTeacherService)
    {
        _scienceTeacherService = scienceTeacherService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] ScienceTeacherForCreationDto dto)
        => Ok(await _scienceTeacherService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._scienceTeacherService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._scienceTeacherService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._scienceTeacherService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] ScienceTeacherForUpdateDto dto)
        => Ok(await this._scienceTeacherService.ModifyAsync(id, dto));
}
