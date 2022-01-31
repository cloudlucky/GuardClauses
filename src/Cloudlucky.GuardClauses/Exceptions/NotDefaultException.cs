#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class NotDefaultException : GuardParameterException
{
    public NotDefaultException()
        : base(ErrorMessages.NotDefault())
    {
    }

    public NotDefaultException(string? parameterName)
        : base(ErrorMessages.NotDefault(), parameterName)
    {
    }

    public NotDefaultException(string? message, string? parameterName)
        : base(ErrorMessages.NotDefault(message), parameterName)
    {
    }

    public NotDefaultException(string? message, Exception? innerException)
        : base(ErrorMessages.NotDefault(message), innerException)
    {
    }

    public NotDefaultException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.NotDefault(message), parameterName, innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected NotDefaultException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
