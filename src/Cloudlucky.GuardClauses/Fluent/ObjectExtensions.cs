using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Fluent;

public static class ObjectExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? MustNotBeFound<T>(this T? input, string? message = default, FoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.Found(input, message, options, parameterName);

        return input;
    }

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? MustNotBeFound<T>(this T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotDefaultInterpolatedStringHandler<T> message, FoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.Found(input, ref message, options, parameterName);

        return input;
    }
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T MustBeFound<T>(this T? input, string? message = default, NotFoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.NotFound(input, message, options, parameterName);

        return input;
    }

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T MustBeFound<T>(this T? input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstDefaultInterpolatedStringHandler<T> message, NotFoundOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.NotFound(input, ref message, options, parameterName);

        return input;
    }
#endif
}
