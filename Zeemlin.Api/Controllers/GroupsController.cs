﻿using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class GroupsController : BaseController
{
    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] GroupForCreationDto dto)
        => Ok(await this._groupService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._groupService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._groupService.RetrieveIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._groupService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] GroupForUpdateDto dto)
        => Ok(await this._groupService.ModifyAsync(id, dto));
}
