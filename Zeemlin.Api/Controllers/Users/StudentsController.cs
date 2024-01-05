using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Students;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers.Users;

public class StudentsController : BaseController
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public async Task<IActionResult> PostAsync([FromBody] StudentForCreationDto dto)
        => Ok(await this._studentService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._studentService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._studentService.RemoveAsync(id));

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmailAsync(string email)
        => Ok(await this._studentService.RetrieveByEmailAsync(email));

    [HttpGet("PhoneNumber")]
    public async Task<IActionResult> GetByPhoneNumberAsync(string phoneNumber)
        => Ok(await this._studentService.RetrieveByPhoneNumberAsync(phoneNumber));
}
