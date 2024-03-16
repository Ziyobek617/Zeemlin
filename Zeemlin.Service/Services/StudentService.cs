using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Students;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class StudentService : IStudentService
{
    private readonly IMapper _mapper;
    private readonly IStudentRepository _studentRepository;
    private readonly AppDbContext dbContext;

    public StudentService(
        IStudentRepository studentRepository,
        IMapper mapper, 
        AppDbContext dbContext)
    {
        _mapper = mapper;
        _studentRepository = studentRepository;
        this.dbContext = dbContext;
    }
    private async Task<string> GenerateUniqueStudentId()
    {
        string studentId;
        do
        {
            studentId = GenerateRandomAlphanumericString(8);
        } while (await _studentRepository.ExistsAsync(studentId)); // Check for existence

        return studentId;
    }

    private string GenerateRandomAlphanumericString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public async Task<StudentForResultDto> AddAsync(StudentForCreationDto dto)
    {
        var existingStudentEmail = await _studentRepository
          .SelectAll()
          .Where(e => e.Email.ToLower() == dto.Email.ToLower())
          .AsNoTracking()
          .FirstOrDefaultAsync();

        if (existingStudentEmail is not null)
            throw new ZeemlinException(409, "User is already exist.");

        var existingStudentPhoneNumber = await _studentRepository
          .SelectAll()
          .Where(e => e.PhoneNumber == dto.PhoneNumber)
          .AsNoTracking()
          .FirstOrDefaultAsync();

        if (existingStudentPhoneNumber is not null)
            throw new ZeemlinException(409, "User is already exist.");

        var mappedStudent = _mapper.Map<Student>(dto);
        mappedStudent.StudentUniqueId = await GenerateUniqueStudentId();
        mappedStudent.CreatedAt = DateTime.UtcNow;
        await _studentRepository.InsertAsync(mappedStudent);

        return _mapper.Map<StudentForResultDto>(mappedStudent);
    }


    public async Task<StudentForResultDto> ModifyAsync(long id, StudentForUpdateDto dto)
    {
        var user = await _studentRepository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User not found");

        var person = _mapper.Map(dto, user);
        person.UpdatedAt = DateTime.UtcNow;
        await _studentRepository.UpdateAsync(person);

        return _mapper.Map<StudentForResultDto>(person);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await _studentRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        await _studentRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<StudentForResultDto>> RetrieveAllAsync()
    {
        var users = await _studentRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<StudentForResultDto>>(users);
    }

    public async Task<Student> RetrieveByEmailAsync(string email)
    {
        var user = await _studentRepository.SelectAll()
            .Where(u => u.Email.ToLower() == email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User Not Found");

        return user;
    }

    public async Task<StudentForResultDto> RetrieveByIdAsync(long id)
    {
        var student = await _studentRepository.SelectAll()
            .Where(s => s.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
    
        if (student is null)
            throw new ZeemlinException(404, "Student not found");
        
        return _mapper.Map<StudentForResultDto>(student);
    }

    public async Task<List<Student>> RetrieveByDataAsync(string data)
    {
        var query = dbContext.Students.Where(a =>
           a.FirstName.Contains(data) ||
           a.LastName.Contains(data) ||
           a.Email.Contains(data) ||
           a.PhoneNumber.Contains(data));
        return await query.ToListAsync();
    }
}
