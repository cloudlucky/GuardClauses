#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class ZeroException : GuardParameterException
{
    public ZeroException()
        : base(ErrorMessages.Zero())
    {
    }

    public ZeroException(string? parameterName)
        : base(ErrorMessages.Zero(), parameterName)
    {
    }

    public ZeroException(string? message, string? parameterName)
        : base(ErrorMessages.Zero(message), parameterName)
    {
    }

    public ZeroException(string? message, Exception? innerException)
        : base(ErrorMessages.Zero(message), innerException)
    {
    }

    public ZeroException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.Zero(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected ZeroException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
