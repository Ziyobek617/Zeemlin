using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.DTOs.TeacherGroups;
using Zeemlin.Service.Interfaces;
using Zeemlin.Service.Services;

namespace Zeemlin.Api.Controllers.Users;

public class TeacherGroupsController : BaseController
{
    private readonly ITeacherGroupService _service;

    public TeacherGroupsController(ITeacherGroupService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] TeacherGroupForCreationDto dto)
        => Ok(await _service.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._service.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._service.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._service.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] TeacherGroupForUpdateDto dto)
        => Ok(await this._service.ModifyAsync(id, dto));
}
