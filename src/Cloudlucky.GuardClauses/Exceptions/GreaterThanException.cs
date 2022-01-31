#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class GreaterThanException : GuardParameterException
{
    public GreaterThanException()
        : base(ErrorMessages.GreaterThan())
    {
    }

    public GreaterThanException(string? parameterName)
        : base(ErrorMessages.GreaterThan(), parameterName)
    {
    }

    public GreaterThanException(string? message, string? parameterName)
        : base(ErrorMessages.GreaterThan(message), parameterName)
    {
    }

    public GreaterThanException(string? message, Exception? innerException)
        : base(ErrorMessages.GreaterThan(message), innerException)
    {
    }

    public GreaterThanException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.GreaterThan(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected GreaterThanException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
