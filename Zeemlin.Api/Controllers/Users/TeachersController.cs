using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Teachers;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers.Users;

[Authorize]
public class TeachersController : BaseController
{
    private readonly ITeacherService _teacherService;

    public TeachersController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] TeacherForCreationDto dto)
        => Ok(await _teacherService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._teacherService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._teacherService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._teacherService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] TeacherForUpdateDto dto)
        => Ok(await this._teacherService.ModifyAsync(id, dto));
}
