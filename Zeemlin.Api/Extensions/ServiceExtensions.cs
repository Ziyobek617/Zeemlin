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

    }
}
