using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Students;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class StudentService : IStudentService
{
    private readonly IMapper _mapper;
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository, IMapper mapper)
    {
        _mapper = mapper;
        _studentRepository = studentRepository;
    }

    public async Task<StudentForResultDto> AddAsync(StudentForCreationDto dto)
    {
        var students = await _studentRepository
            .SelectAll()
            .Where(e => e.Email.ToLower() == dto.Email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (students is not null)
            throw new ZeemlinException(409, "User is already exist.");

        var mappedUser = _mapper.Map<Student>(dto);
        mappedUser.CreatedAt = DateTime.UtcNow;
        var createdUser = await _studentRepository.InsertAsync(mappedUser);

        return _mapper.Map<StudentForResultDto>(mappedUser);
    }

    public async Task<StudentForResultDto> ModifyAsync(long id, StudentForUpdateDto dto)
    {
        var user = await _studentRepository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User not found");

        user.UpdatedAt = DateTime.UtcNow;
        var person = _mapper.Map(dto, user);
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

    public Task<StudentForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<Student> RetrieveByPhoneNumberAsync(string phoneNumber)
    {
        var student = await _studentRepository.SelectAll()
            .Where(u => u.PhoneNumber == phoneNumber)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (student is null)
            throw new ZeemlinException(404, "User Not Found");

        return student;
    }
}
