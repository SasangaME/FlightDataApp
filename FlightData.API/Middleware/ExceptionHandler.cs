using System.Net;
using FlightData.Models.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FlightData.API.Middleware;

public class ExceptionHandler(ILogger<ExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception,
        CancellationToken cancellationToken)
    {
        logger.LogError(exception.Message, exception);

        var statusCode = exception switch
        {
            NotFoundException => (int)HttpStatusCode.NotFound,
            BadRequestException => (int)HttpStatusCode.BadRequest,
            UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
            _ => (int)HttpStatusCode.InternalServerError
        };

        await httpContext.Response.WriteAsJsonAsync(new ProblemDetails
        {
            Status = statusCode,
            Type = exception.GetType().Name,
            Title = exception.Message,
            Detail = exception.StackTrace,
            Instance = $"{httpContext.Request.Method} {httpContext.Request.Path}"
        });

        return true;
    }
}