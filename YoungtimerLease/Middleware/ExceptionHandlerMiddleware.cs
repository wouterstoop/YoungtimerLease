using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using YoungtimerLease.Persistance.Exceptions;

namespace YoungtimerLease.Middleware;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<IDesignTimeDbContextFactory<DbContext>> _logger;

    public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<IDesignTimeDbContextFactory<DbContext>> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (ValidationException ex)
        {
            _logger.LogError(ex.Message);
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
        catch (DbRecordNotFoundException ex)
        {
            _logger.LogError(ex.Message);
            context.Response.StatusCode = StatusCodes.Status404NotFound;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}

