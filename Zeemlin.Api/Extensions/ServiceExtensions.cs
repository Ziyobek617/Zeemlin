using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Runtime.CompilerServices;
using Zeemlin.Data.IRepositries;
using Zeemlin.Data.Repositories;
using Zeemlin.Service.Interfaces;
using Zeemlin.Service.Services;

namespace Zeemlin.Api.Extensions;

public static class ServiceExtensions
{
    public static void AddZeemlinService(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        
        services.AddScoped<IEmailService, EmailService>();

        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ICourseRepository, CourseRepository>();

        services.AddScoped<IGroupService, GroupService>();
        services.AddScoped<IGroupRepository, GroupRepository>();

        services.AddScoped<IUserGroupService, UserGroupService>();
        services.AddScoped<IUserGroupRepository, UserGroupRepository>();

        services.AddScoped<IHomeworkService, HomeworkService>();
        services.AddScoped<IHomeworkRepository, HomeworkRepository>();

    }
}
