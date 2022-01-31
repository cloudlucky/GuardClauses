#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotLessThanException : GuardParameterException
{
    public NotLessThanException()
        : base(ErrorMessages.NotLessThan())
    {
    }

    public NotLessThanException(string? parameterName)
        : base(ErrorMessages.NotLessThan(), parameterName)
    {
    }

    public NotLessThanException(string? message, string? parameterName)
        : base(ErrorMessages.NotLessThan(message), parameterName)
    {
    }

    public NotLessThanException(string? message, Exception? innerException)
        : base(ErrorMessages.NotLessThan(message), innerException)
    {
    }

    public NotLessThanException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotLessThan(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotLessThanException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
