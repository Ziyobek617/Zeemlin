using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts;

var builder = WebApplication.CreateBuilder(args);


//Servislardi ro'yxatdan o'tkazish
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database configuration 
builder.Services.AddDbContext<AppDbContext>(option
    => option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
