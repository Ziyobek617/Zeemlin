using Microsoft.AspNetCore.Mvc;
using Zeemlin.Api.Models;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }

    //GetAll
    [HttpGet]
    public async Task<ActionResult> GetAllAsync()
    {
        var response = new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RetrieveAllAsync()
        };
        return Ok(response);
    }

    //GetById
    [HttpGet("{id}")]
    public async Task<ActionResult> GetAsync(long id)
    {
        var response = new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RetrieveIdAsync(id)
        };
        return Ok(response);
    }

    //Create
    [HttpPost]
    public async Task<ActionResult> PostAsync(UserForCreationDto dto)
    {
        var response = new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.CreateAsync(dto)
        };
        return Ok(response);
    }

    //Delete
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        var response = new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.RemoveAsync(id)
        };
        return Ok(response);
    }
    
    //Update
    [HttpPut]
    public async Task<ActionResult> PutAsync(UserForUpdateDto dto)
    {
        var response = new Response
        {
            StatusCode = 200,
            Message = "succes",
            Data = await this.userService.UpdateAsync(dto)
        };
        return Ok(response);
    }
}

