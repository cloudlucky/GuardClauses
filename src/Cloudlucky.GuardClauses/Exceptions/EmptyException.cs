#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class EmptyException : GuardParameterException
{
    public EmptyException()
        : base(ErrorMessages.Empty())
    {
    }

    public EmptyException(string? parameterName)
        : base(ErrorMessages.Empty(), parameterName)
    {
    }

    public EmptyException(string? message, string? parameterName)
        : base(ErrorMessages.Empty(message), parameterName)
    {
    }

    public EmptyException(string? message, Exception? innerException)
        : base(ErrorMessages.Empty(message), innerException)
    {
    }

    public EmptyException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.Empty(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected EmptyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
