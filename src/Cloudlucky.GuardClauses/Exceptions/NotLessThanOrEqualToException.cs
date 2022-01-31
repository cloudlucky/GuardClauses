#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotLessThanOrEqualToException : GuardParameterException
{
    public NotLessThanOrEqualToException()
        : base(ErrorMessages.NotLessThanOrEqualTo())
    {
    }

    public NotLessThanOrEqualToException(string? parameterName)
        : base(ErrorMessages.NotLessThanOrEqualTo(), parameterName)
    {
    }

    public NotLessThanOrEqualToException(string? message, string? parameterName)
        : base(ErrorMessages.NotLessThanOrEqualTo(message), parameterName)
    {
    }

    public NotLessThanOrEqualToException(string? message, Exception? innerException)
        : base(ErrorMessages.NotLessThanOrEqualTo(message), innerException)
    {
    }

    public NotLessThanOrEqualToException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotLessThanOrEqualTo(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotLessThanOrEqualToException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
