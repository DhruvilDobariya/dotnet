using Microsoft.AspNetCore.Mvc.Filters;

namespace UsingFilter.Filters
{
    public class ParameterFilter1 : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ActionArguments["gender"].Equals("Male"))
            {
                context.ActionArguments["name"] = "Mr." + context.ActionArguments["name"];
                context.ActionArguments["gender"] = "Female";

            }
            else
            {
                context.ActionArguments["name"] = "Ms." + context.ActionArguments["name"];
                context.ActionArguments["gender"] = "Male";
            }
            await next();

        }
    }
}
