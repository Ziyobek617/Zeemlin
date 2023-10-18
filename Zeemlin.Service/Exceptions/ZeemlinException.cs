namespace Zeemlin.Service.Exceptions;

public class ZeemlinException : Exception
{
    public int StatusCode { get; set; }

    public ZeemlinException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}
