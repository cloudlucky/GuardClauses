#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotNullException : GuardParameterException
{
    public NotNullException()
        : base(ErrorMessages.NotNull())
    {
    }

    public NotNullException(string? parameterName)
        : base(ErrorMessages.NotNull(), parameterName)
    {
    }

    public NotNullException(string? message, string? parameterName)
        : base(ErrorMessages.NotNull(message), parameterName)
    {
    }

    public NotNullException(string? message, Exception? innerException)
        : base(ErrorMessages.NotNull(message), innerException)
    {
    }

    public NotNullException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotNull(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotNullException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
