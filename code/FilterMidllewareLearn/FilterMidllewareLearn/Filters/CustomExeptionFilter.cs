using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace FilterLearn.Filters
{
    public class CustomExeptionFilter : IExceptionFilter
    {
        private readonly ILogger<CustomExeptionFilter> _logger;
        public CustomExeptionFilter(ILogger<CustomExeptionFilter> logger)
        {
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            _logger.LogError($"Filter: {context.Exception.Message} {context.Exception.StackTrace}");
            context.HttpContext.Response.StatusCode = 500;
            context.HttpContext.Response.WriteAsync(context.Exception.Message);
        }
    }
}
