namespace ASP02DI.Middlewares
{
    public class RequestTimeMiddleware
    {
        private readonly RequestDelegate _next; // odkaz na další middleware v sekvenci​
        public RequestTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }    
        
        public async Task InvokeAsync(HttpContext context)
        {
        // Zaznamenání času před zpracováním požadavku
        var startTime = DateTime.Now;
        // Předání požadavku dalšímu middleware v pipeline
        await _next(context);
        // Zaznamenání času po zpracování požadavku
        var endTime = DateTime.Now;
        // Výpočet doby trvání
        var duration = endTime - startTime;
        // Zaznamenání doby trvání do konzole
        Console.WriteLine($"Požadavek {context.Request.Path} trval {duration.TotalMilliseconds} ms.");
        }
    }

    public static class RequestTimeMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestTime(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimeMiddleware>();
        }
    }
}
