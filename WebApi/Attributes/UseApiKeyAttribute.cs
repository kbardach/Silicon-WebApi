using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class UseApiKeyAttribute : Attribute, IAsyncActionFilter
{
    

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {

        var secret = "5b56ec08-de9d-464d-aafc-b4c97ab5212d";

        if (context.HttpContext.Request.Query.TryGetValue("key", out var key)) 
        { 
            if (!string.IsNullOrEmpty(key))
            {
                if (secret == key)
                {
                    await next();
                }
            }
        }

        context.Result = new UnauthorizedResult();
        return;
    }
}
