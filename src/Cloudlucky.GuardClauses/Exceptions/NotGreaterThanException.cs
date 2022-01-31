#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotGreaterThanException : GuardParameterException
{
    public NotGreaterThanException()
        : base(ErrorMessages.NotGreaterThan())
    {
    }

    public NotGreaterThanException(string? parameterName)
        : base(ErrorMessages.NotGreaterThan(), parameterName)
    {
    }

    public NotGreaterThanException(string? message, string? parameterName)
        : base(ErrorMessages.NotGreaterThan(message), parameterName)
    {
    }

    public NotGreaterThanException(string? message, Exception? innerException)
        : base(ErrorMessages.NotGreaterThan(message), innerException)
    {
    }

    public NotGreaterThanException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotGreaterThan(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotGreaterThanException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
