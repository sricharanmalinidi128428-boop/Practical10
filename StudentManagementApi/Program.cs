using StudentManagementApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<RequestLoggingMiddleware>();
app.MapGet("/", () => "Student Management API is running. Try /api/students.");
app.MapControllers();

app.Run();
