#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class GreaterThanOrEqualToException : GuardParameterException
{
    public GreaterThanOrEqualToException()
        : base(ErrorMessages.GreaterThanOrEqualTo())
    {
    }

    public GreaterThanOrEqualToException(string? parameterName)
        : base(ErrorMessages.GreaterThanOrEqualTo(), parameterName)
    {
    }

    public GreaterThanOrEqualToException(string? message, string? parameterName)
        : base(ErrorMessages.GreaterThanOrEqualTo(message), parameterName)
    {
    }

    public GreaterThanOrEqualToException(string? message, Exception? innerException)
        : base(ErrorMessages.GreaterThanOrEqualTo(message), innerException)
    {
    }

    public GreaterThanOrEqualToException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.GreaterThanOrEqualTo(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected GreaterThanOrEqualToException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
