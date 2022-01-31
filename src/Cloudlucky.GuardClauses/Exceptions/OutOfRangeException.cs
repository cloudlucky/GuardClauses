#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class OutOfRangeException : GuardParameterException
{
    public OutOfRangeException()
        : base(ErrorMessages.OutOfRange())
    {
    }

    public OutOfRangeException(string? parameterName) 
        : base(ErrorMessages.OutOfRange(), parameterName)
    {
    }

    public OutOfRangeException(string? message, string? parameterName) 
        : base(ErrorMessages.OutOfRange(message), parameterName)
    {
    }

    public OutOfRangeException(string? message, Exception? innerException) 
        : base(ErrorMessages.OutOfRange(message), innerException)
    {
    }

    public OutOfRangeException(string? message, string? parameterName, Exception? innerException) 
        : base(ErrorMessages.OutOfRange(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected OutOfRangeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
