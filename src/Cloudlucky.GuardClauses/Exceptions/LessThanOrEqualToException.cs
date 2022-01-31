#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class LessThanOrEqualToException : GuardParameterException
{
    public LessThanOrEqualToException()
        : base(ErrorMessages.LessThanOrEqualTo())
    {
    }

    public LessThanOrEqualToException(string? parameterName)
        : base(ErrorMessages.LessThanOrEqualTo(), parameterName)
    {
    }

    public LessThanOrEqualToException(string? message, string? parameterName)
        : base(ErrorMessages.LessThanOrEqualTo(message), parameterName)
    {
    }

    public LessThanOrEqualToException(string? message, Exception? innerException)
        : base(ErrorMessages.LessThanOrEqualTo(message), innerException)
    {
    }

    public LessThanOrEqualToException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.LessThanOrEqualTo(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected LessThanOrEqualToException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
