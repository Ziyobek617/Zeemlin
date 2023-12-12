using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class AuthController : BaseController
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("autenticate")]
    public async Task<IActionResult> PostAsync(LoginDto dto)
    {
        var token = await _authService.AuthenticateAsync(dto);

        return Ok(token);
    }
}
