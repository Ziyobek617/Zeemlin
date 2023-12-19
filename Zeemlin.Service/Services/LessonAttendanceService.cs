using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            this._mapper = mapper;
            this._lessonAttendanceRepository = lessonAttendanceRepository;
        }

        // ... Existing functions ...

        public async Task MarkAllPresentAsync()
        {
            // Get current date and time
            var currentDate = DateTime.UtcNow.Date;
            var markPresentTime = DateTime.UtcNow.TimeOfDay; // Use specific time you want

            // Check if past the deadline (8 AM)
            if (markPresentTime > new TimeSpan(8, 0, 0))
            {
                return; // No need to update if past deadline
            }

            // Filter students without existing attendance for the day
            var studentsWithoutAttendance = await _lessonAttendanceRepository
                .GetAllAsync(a => a.Date == currentDate && a.LessonAttendanceType == null);

            foreach (var student in studentsWithoutAttendance)
            {
                // Create new attendance record with "Yes" type
                var attendance = new LessonAttendance
                {
                    StudentId = student.StudentId,
                    Date = currentDate,
                    LessonAttendanceType = LessonAttendanceType.Present
                };

                await _lessonAttendanceRepository.InsertAsync(attendance);
            }
        }

        // ... Existing functions ...

        private async Task SetAttendanceNullAsync(long id, DateTime date)
        {
            // ... Original implementation ...
        }
    }
}
