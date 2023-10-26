using Microsoft.AspNetCore.Mvc;
using Zeemlin.Api.Models;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;


public class UsersController : BaseController
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        this._userService = userService;
    }

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserForCreationDto dto)
        => Ok(await this._userService.AddAsync(dto));

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._userService.RetrieveAllAsync());

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._userService.RetrieveByIdAsync(id));


    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._userService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserForUpdateDto dto)
        => Ok(await this._userService.ModifyAsync(id, dto));

    [HttpPatch("{id}")]
    public async Task<IActionResult> ChangeAsync([FromRoute(Name = "id")] long id, [FromBody] Role role)
        => Ok(await this._userService.ChangeUserRoleAsynch(id, role));

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmailAsync(string email)
        => Ok(await this._userService.RetrieveByEmailAsync(email));
}