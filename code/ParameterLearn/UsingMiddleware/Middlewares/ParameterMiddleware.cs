namespace UsingMiddleware.Middlewares
{
    public class ParameterMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // For Route:
            //if (context.Request.RouteValues["gender"].Equals("Male"))
            //{
            //    context.Request.RouteValues["gender"] = "Female";
            //}
            //else
            //{
            //    context.Request.RouteValues["gender"] = "Male";
            //}

            // For Query:
            // For without check gender is available or not
            // context.Request.Query["gender"].Equals("Male")
            // If we want to check gender is available or not

            //StringValues genderValues;
            //if (context.Request.Query.TryGetValue("gender", out genderValues))
            //{
            //    if (genderValues.FirstOrDefault().Equals("Male"))
            //    {
            //        context.Request.QueryString = QueryHelpers.AddQueryString("")
            //    }
            //    else
            //    {
            //        context.Request.QueryString.Add("gender", "Male");
            //    }
            //}

            // For Body:
            //var bodyStream = context.Request.Body;
            //var body = await new StreamReader(bodyStream).ReadToEndAsync();

            //if (body.Contains("Male"))
            //{
            //    // body.Replace("\"Male\"", "\"Female\"");
            //    body = "\"Female\"";
            //}
            //else
            //{
            //    // body.Replace("\"Female\"", "\"Male\"");
            //    body = "\"Male\"";
            //}

            //var bodyBytes = Encoding.UTF8.GetBytes(body);
            //context.Request.Body = new MemoryStream(bodyBytes);

            // For Header:
            //FormCollection form = (FormCollection)await context.Request.ReadFormAsync();
            //if (form["gender"].Equals("Male"))
            //{
            //    form = new FormCollection(form.ToDictionary(x => x = x.Key == "gender" ? "Female" : x.Value));
            //}
            //else
            //{
            //    context.Request.Headers["gender"] = "Male";
            //}

            // For Header:
            //if (context.Request.Headers["gender"].Equals("Male"))
            //{
            //    context.Request.Headers["gender"] = "Female";
            //}
            //else
            //{
            //    context.Request.Headers["gender"] = "Male";
            //}
            await next(context);
        }
    }
}
