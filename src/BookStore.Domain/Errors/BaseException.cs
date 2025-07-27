using System.Runtime.Serialization;
#pragma warning disable SYSLIB0051

namespace BookStore.Domain.Errors;

[Serializable]
public class BaseException : Exception
{
    public BaseException() { }
    public BaseException(String message) : base(message) { }
    public BaseException(String message, Exception inner) : base(message, inner) { }
    protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}