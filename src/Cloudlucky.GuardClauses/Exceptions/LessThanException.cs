#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class LessThanException : GuardParameterException
{
    public LessThanException()
        : base(ErrorMessages.LessThan())
    {
    }

    public LessThanException(string? parameterName)
        : base(ErrorMessages.LessThan(), parameterName)
    {
    }

    public LessThanException(string? message, string? parameterName)
        : base(ErrorMessages.LessThan(message), parameterName)
    {
    }

    public LessThanException(string? message, Exception? innerException)
        : base(ErrorMessages.LessThan(message), innerException)
    {
    }

    public LessThanException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.LessThan(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected LessThanException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
