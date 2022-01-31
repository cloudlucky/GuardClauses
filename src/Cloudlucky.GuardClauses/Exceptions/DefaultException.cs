#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class DefaultException : GuardParameterException
{
    public DefaultException()
        : base(ErrorMessages.Default())
    {
    }

    public DefaultException(string? parameterName)
        : base(ErrorMessages.Default(), parameterName)
    {
    }

    public DefaultException(string? message, string? parameterName)
        : base(ErrorMessages.Default(message), parameterName)
    {
    }

    public DefaultException(string? message, Exception? innerException)
        : base(ErrorMessages.Default(message), innerException)
    {
    }

    public DefaultException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.Default(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected DefaultException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
