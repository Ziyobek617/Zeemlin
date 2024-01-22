using Microsoft.AspNetCore.Mvc;
using Zeemlin.Data.IRepositries;
using Zeemlin.Service.DTOs.Homework;
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

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._schoolService.RetrieveAllAsync());

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._schoolService.RetrieveByIdAsync(id));

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._schoolService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] SchoolForUpdateDto dto)
        => Ok(await this._schoolService.ModifyAsync(id, dto));
}
