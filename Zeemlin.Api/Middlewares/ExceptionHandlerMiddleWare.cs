using Zeemlin.Api.Models;
using Zeemlin.Service.Exceptions;

namespace Zeemlin.Api.Middlewares;

public class ExceptionHandlerMiddleWare
{
    private readonly RequestDelegate next;
    private readonly ILogger<ExceptionHandlerMiddleWare> logger;

    public ExceptionHandlerMiddleWare(RequestDelegate next, ILogger<ExceptionHandlerMiddleWare> logger)
    {
        this.next = next;
        this.logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (ZeemlinException ex)
        {
            this.logger.LogError(ex.Message);
            context.Response.StatusCode = ex.StatusCode;
            await context.Response.WriteAsJsonAsync(new Response
            {
                StatusCode = ex.StatusCode,
                Message = ex.Message,
            });
        }
        catch (Exception ex)
        {
            this.logger.LogError($"{ex}\n\n");
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new Response
            {
                StatusCode = 500,
                Message = ex.Message,
            });
        }
    }
}
