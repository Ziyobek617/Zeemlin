using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zeemlin.Data.DbContexts;
using Zeemlin.Service.DTOs.Students;
using Zeemlin.Service.DTOs.Teachers;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers.Users;

//[Authorize]
public class StudentsController : BaseController
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] StudentForCreationDto dto)
        => Ok(await this._studentService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._studentService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] StudentForUpdateDto dto)
        => Ok(await this._studentService.ModifyAsync(id, dto));

    [HttpGet("FirstName-LastName-Email-PhoneNumber")]
    public async Task<IActionResult> SearchStudentsTerm(string student)
    {
        return Ok(await _studentService.RetrieveByDataAsync(student));
    }
}
