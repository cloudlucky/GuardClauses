#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotZeroException : GuardParameterException
{
    public NotZeroException()
        : base(ErrorMessages.NotZero())
    {
    }

    public NotZeroException(string? parameterName)
        : base(ErrorMessages.NotZero(), parameterName)
    {
    }

    public NotZeroException(string? message, string? parameterName)
        : base(ErrorMessages.NotZero(message), parameterName)
    {
    }

    public NotZeroException(string? message, Exception? innerException)
        : base(ErrorMessages.NotZero(message), innerException)
    {
    }

    public NotZeroException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotZero(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotZeroException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
