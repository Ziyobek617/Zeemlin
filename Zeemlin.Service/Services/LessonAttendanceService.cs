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
        private readonly ILessonRepository _lessonRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ILessonAttendanceRepository _lessonAttendanceRepository;

        public LessonAttendanceService(
            IMapper mapper,
            ILessonRepository lessonRepository,
            IStudentRepository studentRepository,
            ILessonAttendanceRepository lessonAttendanceRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _studentRepository = studentRepository;
            _lessonAttendanceRepository = lessonAttendanceRepository;
        }



        public async Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto)
        {
            var lesson = await _lessonRepository
                .SelectAll()
                .Where(l => l.Id == dto.LessonId)
                .AsNoTracking().FirstOrDefaultAsync();

            if (lesson is null)
                throw new ZeemlinException(404, "Lesson not found");

            var student = await _studentRepository
                .SelectAll()
                .Where(l => l.Id == dto.StudentId)
                .AsNoTracking().FirstOrDefaultAsync();

            if (student is null)
                throw new ZeemlinException(404, "Student not found");

            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
                .Where(a => a.LessonId == dto.LessonId && a.StudentId == dto.StudentId && a.DateTime.Date == dto.Date.Date)
                .FirstOrDefaultAsync();

            if (existingAttendance is not null)
                throw new Exception("Student attendance data already exists for this date."); // Or a more specific error message  

            var mapped = _mapper.Map<LessonAttendance>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            mapped.LessonAttendanceType = LessonAttendanceType.Yes;
            await _lessonAttendanceRepository.InsertAsync(mapped);

            return _mapper.Map<LessonAttendanceForResultDto>(mapped);

        }

        public async Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto)
        {
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
                .AsNoTracking()
                .Where(l => l.Id == id)
                .FirstOrDefaultAsync();

            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            var lesson = await _lessonRepository
                .SelectAll()
                .Where(l => l.Id == dto.LessonId)
                .AsNoTracking().FirstOrDefaultAsync();

            if (lesson is null)
                throw new ZeemlinException(404, "Lesson not found");

            var student = await _studentRepository
                .SelectAll()
                .Where(l => l.Id == dto.StudentId)
                .AsNoTracking().FirstOrDefaultAsync();

            if (student is null)
                throw new ZeemlinException(404, "Student not found");

            // Validate provided data
            if (dto.LessonId != existingAttendance.LessonId)
            {
                throw new ZeemlinException(400, "Modifying lesson ID is not allowed.");
            }

            var mapped = _mapper.Map(dto, existingAttendance);
            mapped.UpdatedAt = DateTime.UtcNow;
            await _lessonAttendanceRepository.UpdateAsync(mapped);

            return _mapper.Map<LessonAttendanceForResultDto>(mapped);
        }


        public async Task<bool> RemoveAsync(long id)
        {
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            await _lessonAttendanceRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync()
        {
            var Attendance = await _lessonAttendanceRepository.SelectAll().AsNoTracking().ToListAsync();

            return _mapper.Map<IEnumerable<LessonAttendanceForResultDto>>(Attendance);
        }

        public async Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id)
        {
            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync(); ;
            if (existingAttendance is null)
                throw new ZeemlinException(404, "Lesson attendance not found.");

            return _mapper.Map<LessonAttendanceForResultDto>(existingAttendance);

        }

        public async Task<IEnumerable<StudentAttendanceReportDto>> GetStudentAttendanceReportAsync(
            string studentFullName, DateTime startDate, DateTime endDate)
        {
            var attendances = await _lessonAttendanceRepository.SelectAll()
                .Where(sla => sla.Student.FirstName + " " + sla.Student.LastName == studentFullName)
                .Where(sla => sla.DateTime >= startDate && sla.DateTime <= endDate)
                .Include(sla => sla.Student)
                .ToListAsync();

            return attendances.Select(sla => new StudentAttendanceReportDto
            {
                StudentId = sla.Student.Id,
                StudentName = sla.Student.FirstName,
                StudentSurname = sla.Student.LastName,
                Date = sla.DateTime,
                AttendanceType = sla.LessonAttendanceType.ToString()
            }).ToList();
        }

        public async Task<IEnumerable<StudentAttendanceReportDto>> GetLessonAttendanceReportAsync(
            long groupId, long lessonId, DateTime startDate, DateTime endDate)
        {
            var attendances = await _lessonAttendanceRepository.SelectAll()
                .Where(la => la.Lesson.GroupId == groupId)
                .Where(la => la.LessonId == lessonId)
                .Where(la => la.DateTime >= startDate && la.DateTime <= endDate)
                .Include(la => la.Student)
                .ToListAsync();

            return attendances.Select(la => new StudentAttendanceReportDto
            {
                StudentId = la.Student.Id,
                StudentName = la.Student.FirstName,
                StudentSurname = la.Student.LastName,
                Date = la.DateTime,
                AttendanceType = la.LessonAttendanceType.ToString()
            }).ToList();
        }

    }
}
