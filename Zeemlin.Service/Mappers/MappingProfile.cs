using AutoMapper;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.User;
using Zeemlin.Service.DTOs.Grade;
using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.Course;
using Zeemlin.Service.DTOs.Homework;
using Zeemlin.Service.DTOs.UserGroup;
using Zeemlin.Service.DTOs.GroupRole;
using Zeemlin.Service.DTOs.GroupPermissions;
using Zeemlin.Service.DTOs.Lesson;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Student
        CreateMap<Student, UserForUpdateDto>().ReverseMap();
        CreateMap<Student, UserForResultDto>().ReverseMap();
        CreateMap<Student, UserForCreationDto>().ReverseMap();
        CreateMap<Student, UserForLoginDto>().ReverseMap();
        CreateMap<Student, UserForSendCodeDto>().ReverseMap();
        #endregion

        #region
        CreateMap<Teacher, TeacherForCreationDto>().ReverseMap();
        CreateMap<Teacher, TeacherForUpdateDto>().ReverseMap();
        CreateMap<Teacher, TeacherForResultDto>().ReverseMap();
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
        CreateMap<StudentGroup, UserGroupForUpdateDto>().ReverseMap();
        CreateMap<StudentGroup, UserGroupForResultDto>().ReverseMap();
        CreateMap<StudentGroup, UserGroupForCreationDto>().ReverseMap();
        #endregion

        #region GroupRole
        CreateMap<GroupRole, GroupRoleForResultDto>().ReverseMap();
        #endregion

        #region GroupPermission
        CreateMap<GroupPermission, GroupPermissionForResultDto>().ReverseMap();
        #endregion

        #region Lesson
        CreateMap<Lesson, LessonForCreationDto>().ReverseMap();
        CreateMap<Lesson, LessonForUpdateDto>().ReverseMap();
        CreateMap<Lesson, LessonForResultDto>().ReverseMap();
        #endregion

        #region LessonAttendance
        CreateMap<LessonAttendance, LessonForCreationDto>().ReverseMap();
        CreateMap<LessonAttendance, LessonForUpdateDto>().ReverseMap();
        CreateMap<LessonAttendance, LessonForResultDto>().ReverseMap();
        #endregion

        //CreateMap<Teacher, TeacherForCreationDto>().ReverseMap();
    }
}