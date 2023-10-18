using Zeemlin.Api.Models;
using Zeemlin.Service.Exceptions;

namespace Zeemlin.Api.Middlewares;

public class ExceptionHandlerMiddleWare
{
    private readonly RequestDelegate next;

    public ExceptionHandlerMiddleWare(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (ZeemlinException ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            await context.Response.WriteAsJsonAsync(new Response
            {
                StatusCode = ex.StatusCode,
                Message = ex.Message,
            });
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new Response
            {
                StatusCode = 500,
                Message = ex.Message,
            });
        }
    }
}
