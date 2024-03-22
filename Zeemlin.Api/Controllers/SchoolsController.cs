using Microsoft.AspNetCore.Mvc;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.Schools;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class SchoolsController : BaseController
{
    private readonly ISchoolService _schoolService;

    public SchoolsController(ISchoolService schoolService)
    {
        _schoolService = schoolService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SchoolForCreationDto dto)
        => Ok(await this._schoolService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._schoolService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._schoolService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._schoolService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] SchoolForUpdateDto dto)
        => Ok(await this._schoolService.ModifyAsync(id, dto));

    [HttpGet("{Region}")]
    public async Task<IActionResult> GetSchoolsByRegion(Region region)
    {
        var schools = await _schoolService.FilterByRegionAsync(region);
        return Ok(schools);
    }

}
