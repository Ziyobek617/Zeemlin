using AutoMapper;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.DTOs.Grade; //3
using Zeemlin.Service.DTOs.Group; //6
using Zeemlin.Service.DTOs.Homework; //7
using Zeemlin.Service.DTOs.GroupRole; //5
using Zeemlin.Service.DTOs.GroupPermissions; //4
using Zeemlin.Service.DTOs.Lesson; //7
using Zeemlin.Service.DTOs.Teachers; //2
using Zeemlin.Service.DTOs.StudentGroups;
using Zeemlin.Service.DTOs.Students; //1
using Zeemlin.Service.DTOs.Schools;
using Zeemlin.Service.DTOs.TeacherGroups;
using Zeemlin.Service.DTOs.Sciences;
using Zeemlin.Service.DTOs.ScienceTeachers; //8

namespace Zeemlin.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Student
        CreateMap<Student, StudentForCreationDto>().ReverseMap();
        CreateMap<Student, StudentForUpdateDto>().ReverseMap();
        CreateMap<Student, StudentForResultDto>().ReverseMap();
        #endregion

        #region Teacher
        CreateMap<Teacher, TeacherForCreationDto>().ReverseMap();
        CreateMap<Teacher, TeacherForUpdateDto>().ReverseMap();
        CreateMap<Teacher, TeacherForResultDto>().ReverseMap();
        #endregion

        #region Group
        CreateMap<Group, GroupForCreationDto>().ReverseMap();
        CreateMap<Group, GroupForUpdateDto>().ReverseMap();
        CreateMap<Group, GroupForResultDto>().ReverseMap();
        #endregion

        #region Homework
        CreateMap<Homework, HomeworkForCreationDto>().ReverseMap();
        CreateMap<Homework, HomeworkForUpdateDto>().ReverseMap();
        CreateMap<Homework, HomeworkForResultDto>().ReverseMap();
        #endregion

        #region Grade
        CreateMap<Grade, GradeForCreationDto>().ReverseMap();
        CreateMap<Grade, GradeForUpdateDto>().ReverseMap();
        CreateMap<Grade, GradeForResultDto>().ReverseMap();
        #endregion

        #region StudentGroup
        CreateMap<StudentGroup, StudentGroupForCreationDto>().ReverseMap();
        CreateMap<StudentGroup, StudentGroupForUpdateDto>().ReverseMap();
        CreateMap<StudentGroup, StudentGroupForResultDto>().ReverseMap();
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

        #region School
        CreateMap<School, SchoolForCreationDto>().ReverseMap();
        CreateMap<School, SchoolForUpdateDto>().ReverseMap();
        CreateMap<School, SchoolForResultDto>().ReverseMap();
        #endregion

        CreateMap<Teacher, TeacherForCreationDto>().ReverseMap();
        CreateMap<Teacher, TeacherForUpdateDto>().ReverseMap();
        CreateMap<Teacher, TeacherForResultDto>().ReverseMap();

        CreateMap<TeacherGroup, TeacherGroupForCreationDto>().ReverseMap();
        CreateMap<TeacherGroup, TeacherGroupForUpdateDto>().ReverseMap();
        CreateMap<TeacherGroup, TeacherGroupForResultDto>().ReverseMap();

        CreateMap<Science, ScienceForCreationDto>().ReverseMap();
        CreateMap<Science, ScienceForUpdateDto>().ReverseMap();
        CreateMap<Science, ScienceForResultDto>().ReverseMap();

        CreateMap<ScienceTeacher, ScienceTeacherForCreationDto>().ReverseMap();
        CreateMap<ScienceTeacher, ScienceTeacherForUpdateDto>().ReverseMap();
        CreateMap<ScienceTeacher, ScienceTeacherForResultDto>().ReverseMap();
    }
}