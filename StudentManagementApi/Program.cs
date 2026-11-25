using StudentManagementApi.Middleware;
using StudentManagementApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<StudentService>();

var app = builder.Build();

app.UseMiddleware<RequestLoggingMiddleware>();
app.MapGet("/", () => Results.Content(
    "<h1>Student Management API</h1><p>The API is running.</p>" +
    "<p><a href='/api/students'>View all students (GET)</a></p>" +
    "<p>Use StudentManagementApi.http in Visual Studio to try GET, POST, PUT, and DELETE.</p>",
    "text/html"));
app.MapControllers();

app.Run();
