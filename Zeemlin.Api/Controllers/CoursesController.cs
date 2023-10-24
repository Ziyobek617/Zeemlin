using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Course;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class CoursesController : BaseController
{
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    //Create
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] CourseForCreationDto dto)
        => Ok(await this._courseService.CreateAsync(dto));

    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._courseService.RetrieveAllAsync());


    //GetById
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._courseService.RetrieveByIdAsync(id));

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._courseService.RemoveAsync(id));

    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] CourseForUpdateDto dto)
        => Ok(await this._courseService.ModifyAsync(id, dto));
}
