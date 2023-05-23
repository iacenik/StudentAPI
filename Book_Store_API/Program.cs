using Book_Store_API.Data;
using Book_Store_API.Services.Abstractions;
using Book_Store_API.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>
    (op => op.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

//Service Layer DI Injections
builder.Services.AddScoped<IStudentsService, StudentsService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IExamService, ExamService>();
builder.Services.AddScoped<ILecturerService, LecturerService>();
builder.Services.AddScoped<IStudentCoursesService, StudentCoursesService>();


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
