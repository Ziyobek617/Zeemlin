using AutoMapper;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Course;
using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.DTOs.UserGroup;

namespace Zeemlin.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region User
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForLoginDto>().ReverseMap();
        CreateMap<User, UserForSendCodeDto>().ReverseMap();
        #endregion

        #region Group
        CreateMap<Group, GroupForUpdateDto>().ReverseMap();
        CreateMap<Group, GroupForResultDto>().ReverseMap();
        CreateMap<Group, GroupForCreationDto>().ReverseMap();
        #endregion

        #region Course
        CreateMap<Course, CourseForUpdateDto>().ReverseMap();
        CreateMap<Course, CourseForResultDto>().ReverseMap();
        CreateMap<Course, CourseForCreationDto>().ReverseMap();
        #endregion

        #region Homework
        CreateMap<Homework, HomeworkForUpdateDto>().ReverseMap();
        CreateMap<Homework, HomeworkForResultDto>().ReverseMap();
        CreateMap<Homework, HomeworkForCreationDto>().ReverseMap();
        #endregion

        #region Grade
        CreateMap<Grade, GradeForUpdateDto>().ReverseMap();
        CreateMap<Grade, GradeForResultDto>().ReverseMap();
        CreateMap<Grade, GradeForCreationDto>().ReverseMap();
        #endregion

        #region UserGroup
        CreateMap<UserGroup, UserGroupForUpdateDto>().ReverseMap();
        CreateMap<UserGroup, UserGroupForResultDto>().ReverseMap();
        CreateMap<UserGroup, UserGroupForCreationDto>().ReverseMap();
        #endregion
    }
}