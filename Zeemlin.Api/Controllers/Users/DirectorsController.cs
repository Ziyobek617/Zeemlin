using Microsoft.AspNetCore.Mvc;
using Zeemlin.Data.DbContexts;
using Zeemlin.Service.DTOs.Users.Directors;
using Zeemlin.Service.Interfaces.Users;
using Zeemlin.Service.Services.Users;

namespace Zeemlin.Api.Controllers.Users;

public class DirectorsController : BaseController
{
    private readonly IDirectorService _directorService;
    private readonly AppDbContext appDbContext;

    public DirectorsController(IDirectorService directorService, AppDbContext appDbContext)
    {
        _directorService = directorService;
        this.appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] DirectorForCreationDto dto)
        => Ok(await _directorService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._directorService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._directorService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._directorService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] DirectorForUpdateDto dto)
        => Ok(await this._directorService.ModifyAsync(id, dto));

    [HttpGet("username|PassportSeria|Email|PhoneNumber")]
    public async Task<IActionResult> SearchAdminsTerm(string director)
    {
        return Ok(await _directorService.RetrieveByUsernameAsync(director, appDbContext));
    }
}
