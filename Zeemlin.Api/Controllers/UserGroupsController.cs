using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.UserGroup;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class UserGroupsController : BaseController
{
    private readonly IUserGroupService _UserGroupService;

    public UserGroupsController(IUserGroupService userGroupService)
    {
        _UserGroupService = userGroupService;
    }

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserGroupForCreationDto dto)
        => Ok(await this._UserGroupService.CreateAsync(dto));

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._UserGroupService.RetrieveAllAsync());

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._UserGroupService.RetrieveIdAsync(id));

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._UserGroupService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserGroupForUpdateDto dto)
        => Ok(await this._UserGroupService.ModifyAsync(id, dto));
}
