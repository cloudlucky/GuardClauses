#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NullException : GuardParameterException
{
    public NullException()
        : base(ErrorMessages.Null())
    {
    }

    public NullException(string? parameterName)
        : base(ErrorMessages.Null(), parameterName)
    {
    }

    public NullException(string? message, string? parameterName)
        : base(ErrorMessages.Null(message), parameterName)
    {
    }

    public NullException(string? message, Exception? innerException)
        : base(ErrorMessages.Null(message), innerException)
    {
    }

    public NullException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.Null(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NullException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
