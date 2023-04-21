using Microsoft.AspNetCore.Mvc.Filters;

namespace UsingFilter.Filters
{
    public class ParameterFilter2 : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ActionArguments["gender"].Equals("Male"))
            {
                context.ActionArguments["gender"] = "Female";

            }
            else
            {
                context.ActionArguments["gender"] = "Male";
            }
            await next();

        }
    }
}
