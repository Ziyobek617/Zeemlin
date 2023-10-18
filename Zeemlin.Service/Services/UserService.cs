using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;

    public UserService(IMapper mapper, IRepository<User> userRepository)
    {
        this.mapper = mapper;
        this.userRepository = userRepository;
    }
    public async Task<UserForResultDto> CreateAsync(UserForCreationDto dto)
    {
        var user = await this.userRepository.SelectAll().
            FirstOrDefaultAsync(u => u.Email.ToLower() == dto.Email.ToLower());

        if (user is not null)
            throw new ZeemlinException(409, "User already exsits");

        var mappeduser = this.mapper.Map<User>(dto);
        mappeduser.CreatedAt = DateTime.UtcNow;

        var result = await this.userRepository.InsertAsync(mappeduser);
        await this.userRepository.SaveAsync();

        return this.mapper.Map<UserForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        await this.userRepository.DeleteAsync(id);
        await this.userRepository.SaveAsync();
        return true;
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
    {
        var users = await this.userRepository.SelectAll()
            .ToListAsync();
        await this.userRepository.SaveAsync();

        return this.mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    public async Task<UserForResultDto> RetrieveIdAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        await this.userRepository.SaveAsync();
        return this.mapper.Map<UserForResultDto>(user);
    }

    public async Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto)
    {
        var user = await this.userRepository.SelectByIdAsync(dto.Id);
        if (user is null)
            throw new ZeemlinException(404, "User is not found");

        var mappedUser = this.mapper.Map<User>(dto);
        mappedUser.UpdatedAt = DateTime.UtcNow;

        await this.userRepository.SaveAsync();

        return this.mapper.Map<UserForResultDto>(mappedUser);
    }
}
