using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Service.Interfaces;
using Zeemlin.Service.Services;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Zeemlin.Data.IRepositries.Assets;
using Zeemlin.Data.Repositories.Assets;
using Zeemlin.Service.Interfaces.Assets;
using Zeemlin.Service.Services.Assets;
using Zeemlin.Data.IRepositries.Users;
using Zeemlin.Data.Repositories.Users;
using Zeemlin.Service.Interfaces.Users;
using Zeemlin.Service.Services.Users;

namespace Zeemlin.Api.Extensions;

public static class ServiceExtensions
{
    public static void AddZeemlinService(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        //services.AddScoped<IAuthService, AuthService>();

        services.AddScoped<IEmailService, EmailService>();
        // Users
        services.AddScoped<IGradeService, GradeService>();
        services.AddScoped<IGradeRepository, GradeRepository>();

        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IStudentRepository, StudentRepository>();

        services.AddScoped<ISuperAdminService, SuperAdminService>();
        services.AddScoped<ISuperAdminRepository, SuperAdminRepository>();

        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();

        // Schools
        services.AddScoped<ISchoolRepository, SchoolRepository>();
        services.AddScoped<ISchoolService, SchoolService>();

        services.AddScoped<ICourseServices, CourseService>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        
        services.AddScoped<IGroupService, GroupService>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        
        services.AddScoped<ILessonService, LessonService>();
        services.AddScoped<ILessonRepository, LessonRepository>();

        services.AddScoped<ILessonAttendanceRepository, LessonAttendanceRepository>();
        services.AddScoped<ILessonAttendanceService, LessonAttendanceService>();

        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ISubjectRepository, SubjectRepository>();

        services.AddScoped<IHomeworkService, HomeworkService>();
        services.AddScoped<IHomeworkRepository, HomeworkRepository>();

        services.AddScoped<IScienceRepository, ScienceRepository>();
        services.AddScoped<IScienceService, ScienceService>();

        // Relationships
        services.AddScoped<IStudentGroupRepository, StudentGroupRepository>();
        services.AddScoped<IStudentGroupService, StudentGroupService>();

        services.AddScoped<ITeacherGroupRepository, TeacherGroupRepository>();
        services.AddScoped<ITeacherGroupService, TeacherGroupService>();

        services.AddScoped<IScienceTeacherRepository, ScienceTeacherRepository>();
        services.AddScoped<IScienceTeacherService, ScienceTeacherService>();


        // Assets
        services.AddScoped<ITeacherAssetRepository, TeacherAssetRepository>();
        services.AddScoped<ITeacherAssetService, TeacherAssetService>();

        services.AddScoped<IHomeworkAssetRepository, HomeworkAssetRepository>();
        services.AddScoped<IHomeworkAssetService, HomeworkAssetService>();

    }

   

    public static void AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Zeemlin.Api", Version = "v1" });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                BearerFormat = "JWT",
                Name = "JWT Authorization",
                Description =
                    "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                In = ParameterLocation.Header,
                Scheme = JwtBearerDefaults.AuthenticationScheme,
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { "Bearer" } // Add this
                }
            });
            
        });
    }





    public static void AddJwtService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["JWT:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                ClockSkew = TimeSpan.Zero
            };
        });
    }


}
