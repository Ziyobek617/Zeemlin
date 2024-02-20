using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.LessonAttendances;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class LessonAttendencesController : BaseController
{
    private readonly ILessonAttendanceService _lessonAttendanceService;

    public LessonAttendencesController(ILessonAttendanceService lessonAttendanceService)
    {
        _lessonAttendanceService = lessonAttendanceService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] LessonAttendanceForCreationDto dto)
        => Ok(await _lessonAttendanceService.CreateAsync(dto));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(long id, [FromBody] LessonAttendanceForUpdateDto dto)
        => Ok(await _lessonAttendanceService.ModifyAsync(id, dto));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(await _lessonAttendanceService.RemoveAsync(id));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await _lessonAttendanceService.RetrieveAllAsync());

    [HttpGet("report")]
    public async Task<IActionResult> GenerateReportAsync(
        [FromQuery] DateTime? startDate = null,
        [FromQuery] DateTime? endDate = null,
        [FromQuery] long? lessonId = null,
        [FromQuery] long? studentId = null)
        => Ok(await _lessonAttendanceService.GenerateReportAsync(startDate, endDate, lessonId, studentId));

    [HttpGet("students/{fullName}")]
    public async Task<IActionResult> GetStudentAttendancesByNameAsync(string fullName)
        => Ok(await _lessonAttendanceService.GetStudentAttendancesByNameAsync(fullName));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await _lessonAttendanceService.RetrieveByIdAsync(id));
}
