using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Student> _userRepository;

    public UserService(IMapper mapper, IRepository<Student> userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
    {
        var users = await _userRepository.SelectAll()
            .Where(u => u.Email.ToLower() == dto.Email.ToLower())
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (users is not null)
            throw new ZeemlinException(409, "User is already exist.");

        var mappedUser = _mapper.Map<Student>(dto);
        mappedUser.CreatedAt = DateTime.UtcNow;

        var createdUser = await _userRepository.InsertAsync(mappedUser);
        return _mapper.Map<UserForResultDto>(mappedUser);
    }

    public async Task<UserForResultDto> ChangeUserRoleAsynch(long id, Role role)
    {
        var user = await _userRepository.SelectAll()
            .Where (u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new ZeemlinException(404, "User not found");
        
        var result = await this._userRepository.UpdateAsync(user);

        return this._mapper.Map<UserForResultDto>(result);

    }

    public async Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
    {
        var user = await _userRepository.SelectAll()
        .Where(u => u.Id == id)
        .AsNoTracking()
        .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User not found");

        user.UpdatedAt = DateTime.UtcNow;
        var person = _mapper.Map(dto, user);

        await _userRepository.UpdateAsync(person);

        return _mapper.Map<UserForResultDto>(person);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await _userRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        await _userRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
    {
        var users = await _userRepository.SelectAll().ToListAsync();


        return _mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    public async Task<Student> RetrieveByEmailAsync(string email)
    {
        var user = await _userRepository.SelectAll()
            .Where(u => u.Email.ToLower() == email.ToLower())
            .FirstOrDefaultAsync();
        if (user is null)
            throw new ZeemlinException(404, "User Not Found");

        return user;
    }

    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var users = await _userRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (users is null)
            throw new ZeemlinException(404, "User is not found");

        return _mapper.Map<UserForResultDto>(users);
    }
}
