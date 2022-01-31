#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotFoundException : GuardParameterException
{
    public NotFoundException()
        : base(ErrorMessages.NotFound())
    {
    }

    public NotFoundException(string? parameterName)
        : base(ErrorMessages.NotFound(), parameterName)
    {
    }

    public NotFoundException(string? message, string? parameterName)
        : base(ErrorMessages.NotFound(message), parameterName)
    {
    }

    public NotFoundException(string? message, Exception? innerException)
        : base(ErrorMessages.NotFound(message), innerException)
    {
    }

    public NotFoundException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotFound(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotFoundException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
