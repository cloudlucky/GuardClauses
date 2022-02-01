#if NETSTANDARD2_0_OR_GREATER
using System.Runtime.Serialization;
#endif

namespace Cloudlucky.GuardClauses.Exceptions;

public class GuardException : Exception
{
    public GuardException()
        : base(ErrorMessages.GetGenericErrorMessage())
    {
    }

    public GuardException(string? message)
        : base(message ?? ErrorMessages.GetGenericErrorMessage())
    {
    }

    public GuardException(string? message, Exception? innerException)
        : base(message ?? ErrorMessages.GetGenericErrorMessage(), innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected GuardException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}

public class GuardParameterException : GuardException
{
    public GuardParameterException()
        : base(ErrorMessages.GetGenericErrorMessage())
    {
    }

    public GuardParameterException(string? parameterName)
        : base(ErrorMessages.GetGenericErrorMessage(null, parameterName))
    {
    }

    public GuardParameterException(string? message, string? parameterName)
        : base(ErrorMessages.GetGenericErrorMessage(message, parameterName))
    {
    }

    public GuardParameterException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    public GuardParameterException(string? message, string? parameterName, Exception? innerException)
        : base(ErrorMessages.GetGenericErrorMessage(message, parameterName), innerException)
    {
    }

#if NETSTANDARD2_0_OR_GREATER
    protected GuardParameterException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#endif
}
