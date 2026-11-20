using System.Diagnostics;

namespace Assignment_1_MVC.CustomMiddelweare
{
    public class RequestTimingMiddelware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddelware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var Watch = Stopwatch.StartNew();

            await _next(context);
            Watch.Stop();
            Console.WriteLine($"{context.Request.Path}{Watch.ElapsedMilliseconds}ms");
        }
    }
}
