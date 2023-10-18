using AutoMapper;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
    }
}