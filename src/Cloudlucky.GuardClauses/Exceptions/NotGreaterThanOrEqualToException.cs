#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotGreaterThanOrEqualToException : GuardParameterException
{
    public NotGreaterThanOrEqualToException()
        : base(ErrorMessages.NotGreaterThanOrEqualTo())
    {
    }

    public NotGreaterThanOrEqualToException(string? parameterName)
        : base(ErrorMessages.NotGreaterThanOrEqualTo(), parameterName)
    {
    }

    public NotGreaterThanOrEqualToException(string? message, string? parameterName)
        : base(ErrorMessages.NotGreaterThanOrEqualTo(message), parameterName)
    {
    }

    public NotGreaterThanOrEqualToException(string? message, Exception? innerException)
        : base(ErrorMessages.NotGreaterThanOrEqualTo(message), innerException)
    {
    }

    public NotGreaterThanOrEqualToException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotGreaterThanOrEqualTo(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotGreaterThanOrEqualToException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
