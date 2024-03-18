using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class LessonsController : BaseController
{
    private readonly ILessonService _lessonService;

    public LessonsController(ILessonService lessonService)
    {
        _lessonService = lessonService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] LessonForCreationDto dto)
        => Ok(await this._lessonService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._lessonService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._lessonService.RetrieveIdAsync(id));
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._lessonService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] LessonForUpdateDto dto)
        => Ok(await this._lessonService.ModifyAsync(id, dto));
}
