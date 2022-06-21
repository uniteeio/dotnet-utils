using System;

namespace Unitee.Models;

public class Error
{
    public string Code { get; set; }
    public string Message { get; set; }
    public Exception Exception { get; set; }
}

public class ResponseModel<T>
{
    public static ResponseModel<T> Success(T data, string correlationId)
    {
        return new ResponseModel<T>
        {
            Data = data,
            CorrelationId = correlationId,
            Error = null,
        };
    }

    public static ResponseModel<T> Fail(string code, string correlationId, string message = null, Exception e = null)
    {
        return new ResponseModel<T>
        {
            Data = default,
            CorrelationId = correlationId,
            Error = new()
            {
                Code = code,
                Message = message,
                Exception = e
            },
        };
    }

    public Error Error { get; set; }
    public T Data { get; set; }
    public string CorrelationId { get; set; }
}