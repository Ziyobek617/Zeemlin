using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Users.Directors;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Api.Controllers.Users;

public class DirectorsController : BaseController
{
    private readonly IDirectorService _directorService;

    public DirectorsController(IDirectorService directorService)
    {
        _directorService = directorService;
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
}
