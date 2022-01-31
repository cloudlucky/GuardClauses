#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotEmptyException : GuardParameterException
{
    public NotEmptyException()
        : base(ErrorMessages.NotEmpty())
    {
    }

    public NotEmptyException(string? parameterName)
        : base(ErrorMessages.NotEmpty(), parameterName)
    {
    }

    public NotEmptyException(string? message, string? parameterName)
        : base(ErrorMessages.NotEmpty(message), parameterName)
    {
    }

    public NotEmptyException(string? message, Exception? innerException)
        : base(ErrorMessages.NotEmpty(message), innerException)
    {
    }

    public NotEmptyException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotEmpty(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotEmptyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
