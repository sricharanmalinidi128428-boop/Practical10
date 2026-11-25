using System.Diagnostics;

namespace StudentManagementApi.Middleware;

public class RequestLoggingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var timer = Stopwatch.StartNew();
        await next(context);
        timer.Stop();

        Console.WriteLine($"{context.Request.Method} {context.Request.Path} " +
                          $"=> {context.Response.StatusCode} ({timer.ElapsedMilliseconds} ms)");
    }
}
