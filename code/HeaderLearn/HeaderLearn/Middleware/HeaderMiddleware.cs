using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace HeaderLearn.Middleware
{
    public class HeaderMiddleware : IMiddleware
    {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!context.Request.Headers.ContainsKey("company-name") || context.Request.Headers["company-name"] == "")
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("missing company-name header");
                return;
            }
            await next(context);
        }
    }
}
