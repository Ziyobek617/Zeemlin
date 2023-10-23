using Zeemlin.Api.Extensions;
using Zeemlin.Api.Middlewares;
using Zeemlin.Data.DbContexts;
using Zeemlin.Service.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Database configuration 
builder.Services.AddDbContext<AppDbContext>(option
    => option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//Servislardi ro'yxatdan o'tkazish
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddZeemlinService();
builder.Services.AddAutoMapper(typeof(MappingProfile));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlerMiddleWare>();
app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
