namespace MiddlewareLearn.Middlewares
{
    public class CustomExeptionMiddleware : IMiddleware
    {
        private readonly ILogger<CustomExeptionMiddleware> _logger;
        public CustomExeptionMiddleware(ILogger<CustomExeptionMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Middleware: {ex.Message} {ex.StackTrace}");
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
