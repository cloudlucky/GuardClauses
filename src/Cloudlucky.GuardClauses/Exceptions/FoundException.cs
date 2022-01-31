#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class FoundException : GuardParameterException
{
    public FoundException()
        : base(ErrorMessages.Found())
    {
    }

    public FoundException(string? parameterName)
        : base(ErrorMessages.Found(), parameterName)
    {
    }

    public FoundException(string? message, string? parameterName)
        : base(ErrorMessages.Found(message), parameterName)
    {
    }

    public FoundException(string? message, Exception? innerException)
        : base(ErrorMessages.Found(message), innerException)
    {
    }

    public FoundException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.Found(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected FoundException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
