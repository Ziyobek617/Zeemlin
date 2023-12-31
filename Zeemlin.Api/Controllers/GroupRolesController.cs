﻿using Microsoft.AspNetCore.Mvc;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.Configurations;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class GroupRolesController : BaseController
{
    private readonly IGroupRoleService _groupRoleService;

    public GroupRolesController(IGroupRoleService groupRoleService)
    {
        this._groupRoleService = groupRoleService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Role chatRole)
        => Ok(await this._groupRoleService.CreateAsync(chatRole));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _groupRoleService.RetrieveAllAsync(@params));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._groupRoleService.RetrieveByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] Role chatRole)
        => Ok(await this._groupRoleService.ModifyAsync(id, chatRole));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._groupRoleService.RemoveAsync(id));
}
