using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers.Users;

public class StudentGroupsController : BaseController
{
    private readonly IStudentGroupService _studentGroupService;

    public StudentGroupsController(IStudentGroupService studentGroupService)
    {
        _studentGroupService = studentGroupService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] StudentGroupForCreationDto dto)
        => Ok(await _studentGroupService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._studentGroupService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentGroupService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentGroupService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] StudentGroupForUpdateDto dto)
        => Ok(await this._studentGroupService.ModifyAsync(id, dto));
}
