//using System.Data.SqlClient;
//using AutoMapper;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using Zeemlin.Data.IRepositries;
//using Zeemlin.Domain.Entities;
//using Zeemlin.Domain.Enums;
//using Zeemlin.Service.DTOs.LessonAttendances;
//using Zeemlin.Service.Exceptions;
//using Zeemlin.Service.Interfaces;
//using Zeemlin.Service.DTOs.User;
//using Zeemlin.Data.Repositories;

//namespace Zeemlin.Service.Services
//{
//    public class LessonAttendanceService : ILessonAttendanceService
//    {
//        private readonly IMapper _mapper;
//        private readonly IRepository<LessonAttendance> _lessonAttendanceRepository;
//        private readonly IUserRepository _userRepository;

//        public LessonAttendanceService(IMapper mapper, IRepository<LessonAttendance> lessonAttendanceRepository, IUserRepository userRepository)
//        {
//            this._mapper = mapper;
//            this._lessonAttendanceRepository = lessonAttendanceRepository;
//            this._userRepository = userRepository;
//        }

//        public Task<LessonAttendanceForResultDto> CreateAsync(LessonAttendanceForCreationDto dto)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<UserForResultDto>> GetUsersWithoutAttendanceAsync()
//        {
//            var currentDate = DateTime.UtcNow.Date;
//            var existingAttendances = await _lessonAttendanceRepository.FindByDateAsync(currentDate);

//            // Get all users
//            var allUsers = await _userRepository.GetAllAsync();

//            // Filter users present on current date
//            var presentUsers = new HashSet<User>(existingAttendances.Select(a => a.User));

//            // Return users without attendance
//            return allUsers.Where(u => !presentUsers.Contains(u))
//                          .Select(u => new UserForResultDto
//                          {
//                              Id = u.Id,
//                              FirstName = u.FirstName,
//                              LastName = u.LastName,
//                              // Include other relevant fields from User to UserForResultDto
//                              // based on your requirements
//                          });
//        }


//        public async Task MarkAllPresentAsync()
//        {
//            // Get current date and time
//            var currentDate = DateTime.UtcNow.Date;
//            var markPresentTime = DateTime.UtcNow.TimeOfDay; // Use specific time you want

//            // Check if past the deadline (8 AM)
//            if (markPresentTime > new TimeSpan(8, 0, 0))
//            {
//                return; // No need to update if past deadline
//            }

//            // Filter students without existing attendance for the day
//            var studentsWithoutAttendanceList = await GetStudentsWithoutAttendanceAsync();

//            // Convert to LessonAttendance objects
//            var attendanceRecords = studentsWithoutAttendanceList.Select(student =>
//                new LessonAttendance { UserId = student.UserId, DateTime = currentDate, LessonAttendanceType = LessonAttendanceType.Yes });

//            using (var connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                using (var bulkCopy = new SqlBulkCopy(connection))
//                {
//                    bulkCopy.DestinationTableName = "LessonAttendances";

//                    foreach (var property in typeof(LessonAttendance).GetProperties())
//                    {
//                        bulkCopy.ColumnMappings.Add(property.Name, property.Name);
//                    }

//                    bulkCopy.WriteToServer(attendanceRecords);
//                }
//            }
//        }


//        public async Task<LessonAttendanceForResultDto> ModifyAsync(long id, LessonAttendanceForUpdateDto dto)
//        {
//            // Check if attendance record exists
//            /// Summary
//            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
//            .Where(l => l.Id == id)
//            .AsNoTracking()
//            .FirstOrDefaultAsync(); ;
//            if (existingAttendance is null)
//                throw new ZeemlinException(404, "Lesson attendance not found.");

//            /// Summary
//            var CheckLessonByIdAsync = await _lessonAttendanceRepository.SelectAll()
//                .Where(l => l.LessonId == dto.LessonId)
//                .AsNoTracking()
//                .FirstOrDefaultAsync();
//            if (CheckLessonByIdAsync is null)
//                throw new ZeemlinException(404, "Lesson is not found.");

//            /// Summary
//            var CheckUserByIdAsync = await _lessonAttendanceRepository.SelectAll()
//                .Where(u => u.UserId == dto.UserId)
//                .AsNoTracking()
//                .FirstOrDefaultAsync();
//            if (CheckUserByIdAsync is null)
//                throw new ZeemlinException(404, "User is not found.");

//            // Validate provided data
//            if (dto.LessonId != existingAttendance.LessonId)
//            {
//                throw new ZeemlinException(400, "Modifying lesson ID is not allowed.");
//            }

//            _mapper.Map(dto, existingAttendance);

//            // Assuming "UpdatedAt" isn't mapped
//            existingAttendance.UpdatedAt = DateTime.UtcNow; 
//            await _lessonAttendanceRepository.UpdateAsync(existingAttendance);

//            return _mapper.Map<LessonAttendanceForResultDto>(existingAttendance);
//        }


//        public Task<bool> RemoveAsync(long id)
//        {

//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<LessonAttendanceForResultDto>> RetrieveAllAsync()
//        {
//            var Attendance = await _lessonAttendanceRepository.SelectAll().ToListAsync();

//            return _mapper.Map<IEnumerable<LessonAttendanceForResultDto>>(Attendance);
//        }

//        public async Task<LessonAttendanceForResultDto> RetrieveByIdAsync(long id)
//        {
//            var existingAttendance = await _lessonAttendanceRepository.SelectAll()
//            .Where(l => l.Id == id)
//            .AsNoTracking()
//            .FirstOrDefaultAsync(); ;
//            if (existingAttendance is null)
//                throw new ZeemlinException(404, "Lesson attendance not found.");

//            return _mapper.Map<LessonAttendanceForResultDto>(existingAttendance);

//        }

        
//    }
//}
