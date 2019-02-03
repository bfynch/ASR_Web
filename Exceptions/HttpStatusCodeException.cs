using System;
using Newtonsoft.Json.Linq;

public class HttpStatusCodeException : Exception
{
    public int StatusCode { get; }
    public string ContentType { get; } = "text/plain";

    public HttpStatusCodeException(int statusCode)
    {
        StatusCode = statusCode;
    }

    public HttpStatusCodeException(int statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }

    public HttpStatusCodeException(int statusCode, Exception inner) : this(statusCode, inner.ToString()) { }

    public HttpStatusCodeException(int statusCode, JObject errorObject) : this(statusCode, errorObject.ToString())
    {
        ContentType = "application/json";
    }
}
