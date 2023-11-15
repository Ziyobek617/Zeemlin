using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class HomeworksController : BaseController
{
    private readonly IHomeworkService _homeworkService;

    public HomeworksController(IHomeworkService homeworkService)
    {
        _homeworkService = homeworkService;
    }

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] HomeworkForCreationDto dto)
        => Ok(await this._homeworkService.CreateAsync(dto));

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._homeworkService.RetrieveAllAsync());

    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._homeworkService.RetrieveIdAsync(id));

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._homeworkService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] HomeworkForUpdateDto dto)
        => Ok(await this._homeworkService.ModifyAsync(id, dto));
}
