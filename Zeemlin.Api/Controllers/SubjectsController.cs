using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Subjects;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class SubjectsController : BaseController
{
    private readonly ISubjectService _subjectService;

    public SubjectsController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SubjectForCreationDto dto)
        => Ok(await this._subjectService.AddAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this._subjectService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._subjectService.RetrieveByIdAsync(id));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this._subjectService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] SubjectForUpdateDto dto)
        => Ok(await this._subjectService.ModifyAsync(id, dto));
}
