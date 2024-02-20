using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.LessonAttendances;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services
{

    public class LessonAttendanceService : ILessonAttendanceService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<LessonAttendance> _lessonAttendanceRepository;

        public LessonAttendanceService(IMapper mapper, IRepository<LessonAttendance> lessonAttendanceRepository)
        {
            _mapper = mapper;
            _lessonAttendanceRepository = lessonAttendanceRepository;
        }

        public Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LessonAttendanceReportDataDto>> GenerateReportAsync(
    DateTime? startDate = null,
    DateTime? endDate = null,
    long? lessonId = null,
    long? studentId = null)
        {
            var query = _lessonAttendanceRepository.SelectAll();

            if (startDate.HasValue)
            {
                query = query.Where(a => a.DateTime >= startDate);
            }

            if (endDate.HasValue)
            {
                query = query.Where(a => a.DateTime <= endDate);
            }

            // Add more filters if needed

            var attendanceData = await query
                .GroupBy(a => new { a.DateTime, a.Lesson.Title, a.Lesson.Teacher.FirstName, a.GroupName })
                .Select(g => new LessonAttendanceReportDataDto
                {
                    Date = g.Key.DateTime,
                    LessonName = g.Key.Title,
                    TeacherName = g.Key.FirstName,
                    GroupName = g.Key.GroupName,
                    TotalStudents = g.Count(),
                    PresentStudents = g.Count(a => a.LessonAttendanceType == LessonAttendanceType.Yes),
                    // Add more calculations as needed
                })
                .ToListAsync();

            return attendanceData;
        }

        public async Task<IEnumerable<StudentAttendanceDataDto>> GetStudentAttendancesByNameAsync(string studentFullName)
        {
            // Assuming you have a LessonAttendanceRepository for data access
            var studentAttendances = await _lessonAttendanceRepository.SelectAll()
                .Where(a => a.Student.FirstName + " " + a.Student.LastName == studentFullName)
                .Include(a => a.Student)
                .Include(a => a.Lesson)
                .ThenInclude(l => l.Group)
                .Include(a => a.Lesson)
                .ThenInclude(l => l.Subjects)
                .Include(a => a.Lesson)
                .ThenInclude(l => l.Teacher)
                .ToListAsync();

            // Map to a DTO for presentation
            return studentAttendances.Select(a => new StudentAttendanceDataDto
            {
                StudentName = a.Student.FirstName,
                StudentSurname = a.Student.LastName,
                GroupName = a.Lesson.Group.Name,
                Lesson = a.Lesson.Title,
                Hour = a.Lesson.StartDate, 
            }).ToList();
        }

        public async Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto)
        {
            // Check if attendance record exists
            /// Summary
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.Id == id)
            .FirstOrDefaultAsync(); ;
            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            /// Summary
            var CheckLessonByIdAsync = await _lessonAttendanceRepository.SelectAll()
                .AsNoTracking()
                .Where(l => l.LessonId == dto.LessonId)
                .FirstOrDefaultAsync();
            if (CheckLessonByIdAsync is null)
                throw new ZeemlinException(404, "Lesson is not found.");

            /// Summary
            var CheckStudentByIdAsync = await _lessonAttendanceRepository.SelectAll()
                .AsNoTracking()
                .Where(u => u.StudentId == dto.StudentId)
                .FirstOrDefaultAsync();
            if (CheckStudentByIdAsync is null)
                throw new ZeemlinException(404, "User is not found.");

            // Validate provided data
            if (dto.LessonId != existingAttendance.LessonId)
            {
                throw new ZeemlinException(400, "Modifying lesson ID is not allowed.");
            }

            _mapper.Map(dto, existingAttendance);

            // Assuming "UpdatedAt" isn't mapped
            existingAttendance.UpdatedAt = DateTime.UtcNow;
            await _lessonAttendanceRepository.UpdateAsync(existingAttendance);

            return _mapper.Map<LessonAttendanceForResultDto>(existingAttendance);
        }


        public async Task<bool> RemoveAsync(long id)
        {
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.Id == id)
            .FirstOrDefaultAsync(); ;
            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            await _lessonAttendanceRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync()
        {
            var Attendance = await _lessonAttendanceRepository.SelectAll().ToListAsync();

            return _mapper.Map<IEnumerable<LessonAttendanceForResultDto>>(Attendance);
        }

        public async Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id)
        {
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
            .AsNoTracking()
            .Where(l => l.Id == id)
            .FirstOrDefaultAsync(); ;
            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            return _mapper.Map<LessonAttendanceForResultDto>(existingAttendance);

        }

    }
}
