#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotNullOrEmptyException : GuardParameterException
{
    public NotNullOrEmptyException()
        : base(ErrorMessages.NotNullOrEmpty())
    {
    }

    public NotNullOrEmptyException(string? parameterName)
        : base(ErrorMessages.NotNullOrEmpty(), parameterName)
    {
    }

    public NotNullOrEmptyException(string? message, string? parameterName)
        : base(ErrorMessages.NotNullOrEmpty(message), parameterName)
    {
    }

    public NotNullOrEmptyException(string? message, Exception? innerException)
        : base(ErrorMessages.NotNullOrEmpty(message), innerException)
    {
    }

    public NotNullOrEmptyException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotNullOrEmpty(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotNullOrEmptyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
