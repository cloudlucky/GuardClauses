#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class InRangeException : GuardParameterException
{
    public InRangeException()
        : base(ErrorMessages.InRange())
    {
    }

    public InRangeException(string? parameterName)
        : base(ErrorMessages.InRange(), parameterName)
    {
    }

    public InRangeException(string? message, string? parameterName)
        : base(ErrorMessages.InRange(message), parameterName)
    {
    }

    public InRangeException(string? message, Exception? innerException)
        : base(ErrorMessages.InRange(message), innerException)
    {
    }

    public InRangeException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.InRange(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected InRangeException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
