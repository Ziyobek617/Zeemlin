using Microsoft.AspNetCore.Mvc;
using Zeemlin.Api.Models;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;


public class UsersController : BaseController
{
    private readonly IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserForCreationDto dto)
        => Ok(new Response()
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.AddAsync(dto)
        });

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(new Response()
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RetrieveAllAsync()
        });

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(new Response()
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RetrieveByIdAsync(id)
        });


    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RemoveAsync(id)
        });

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserForUpdateDto dto)
        => Ok(new Response()
        {
            StatusCode = 200,
            Message = "Succes",
            Data = await this.userService.ModifyAsync(id, dto)
        });

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmailAsync(string email)
        => Ok(new Response()
        {
            StatusCode = 200,
            Message = "Success",
            Data = await this.userService.RetrieveByEmailAsync(email)
        });
}