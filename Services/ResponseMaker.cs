using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Unitee.Models;

namespace Unitee.Services;

public class ResponseMaker
{
    private readonly IHttpContextAccessor _httpContext;
    private readonly ILogger<ResponseMaker> _logger;

    public ResponseMaker(IHttpContextAccessor httpContext, ILogger<ResponseMaker> logger)
    {
        _httpContext = httpContext;
        _logger = logger;
    }

    public ResponseModel<T> Success<T>(T data)
    {
        return ResponseModel<T>.Success(data, _httpContext.HttpContext.TraceIdentifier);
    }

    public ResponseModel<T> Fail<T>(string code, string message = null, Exception exception = null)
    {
        _logger.LogError(exception, "{} - {}", message, code);
        return ResponseModel<T>.Fail(code, _httpContext.HttpContext.TraceIdentifier, message, exception);
    }
}