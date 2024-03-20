using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.LessonAttendances;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers
{
    public class LessonAttendencesController : BaseController
    {
        private readonly ILessonAttendanceService _lessonAttendanceService;

        public LessonAttendencesController(ILessonAttendanceService lessonAttendanceService)
        {
            _lessonAttendanceService = lessonAttendanceService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] LessonAttendanceForCreationDto dto)
        {
            return Ok(await _lessonAttendanceService.CreateAsync(dto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, [FromBody] LessonAttendanceForUpdateDto dto)
        {
            return Ok(await _lessonAttendanceService.ModifyAsync(id, dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await _lessonAttendanceService.RemoveAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _lessonAttendanceService.RetrieveAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        {
            return Ok(await _lessonAttendanceService.RetrieveByIdAsync(id));
        }

        // Expose GetStudentAttendanceReportAsync method
        [HttpGet("reports/student/{studentFullName}")]
        public async Task<IActionResult> GetStudentAttendanceReportAsync(
            string studentFullName, DateTime startDate, DateTime endDate)
        {
            var report = await _lessonAttendanceService.GetStudentAttendanceReportAsync(studentFullName, startDate, endDate);
            return Ok(report);
        }

        // Expose GetLessonAttendanceReportAsync method
        [HttpGet("reports/lesson/{groupId}/{lessonId}")]
        public async Task<IActionResult> GetLessonAttendanceReportAsync(
            long groupId, long lessonId, DateTime startDate, DateTime endDate)
        {
            var report = await _lessonAttendanceService.GetLessonAttendanceReportAsync(groupId, lessonId, startDate, endDate);
            return Ok(report);
        }
    }
}
