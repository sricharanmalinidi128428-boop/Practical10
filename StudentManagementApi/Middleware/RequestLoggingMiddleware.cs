using System.Diagnostics;

namespace StudentManagementApi.Middleware;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var timer = Stopwatch.StartNew();
        await _next(context);
        timer.Stop();

        Console.WriteLine($"{context.Request.Method} {context.Request.Path} " +
                          $"=> {context.Response.StatusCode} ({timer.ElapsedMilliseconds} ms)");
    }
}
