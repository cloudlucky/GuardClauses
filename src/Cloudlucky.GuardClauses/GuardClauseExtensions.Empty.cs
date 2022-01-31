using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, string input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, string input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, Guid input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, Guid input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, IEnumerable input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty(this IGuardClause guard, IEnumerable input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, IEnumerable<T> input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, IEnumerable<T> input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler<T> message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, ICollection<T> input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, ICollection<T> input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler<T> message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, T[] input, string? message = default, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsEmpty()
         ? throw options.GetEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Empty<T>(this IGuardClause guard, T[] input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstEmptyInterpolatedStringHandler<T> message, EmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsEmpty
         ? throw options.GetEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, string input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, string input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, Guid input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, Guid input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, IEnumerable input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty(this IGuardClause guard, IEnumerable input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, IEnumerable<T> input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, IEnumerable<T> input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler<T> message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, ICollection<T> input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, ICollection<T> input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler<T> message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, T[] input, string? message = default, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsEmpty()
         ? throw options.GetNotEmptyException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotEmpty<T>(this IGuardClause guard, T[] input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotEmptyInterpolatedStringHandler<T> message, NotEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotEmpty
         ? throw options.GetNotEmptyException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class EmptyOptions : IGuardOptions
{
    public static EmptyOptions Default { get; set; } = default!;

    public GuardFunc EmptyException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                EmptyException = (message, parameterName) => new ArgumentException(GuardMessages.Empty(message), parameterName)
            },
            _ => new()
            {
                EmptyException = (message, parameterName) => new EmptyException(message, parameterName)
            }
        };
    }
}

public static class EmptyOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetEmptyException(this EmptyOptions? options)
        => options?.EmptyException ?? EmptyOptions.Default.EmptyException;
}

public class NotEmptyOptions : IGuardOptions
{
    public static NotEmptyOptions Default { get; set; } = default!;

    public GuardFunc NotEmptyException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotEmptyException = (message, parameterName) => new ArgumentException(GuardMessages.NotEmpty(message), parameterName)
            },
            _ => new()
            {
                NotEmptyException = (message, parameterName) => new NotEmptyException(message, parameterName)
            }
        };
    }
}

public static class NotEmptyOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotEmptyException(this NotEmptyOptions? options)
        => options?.NotEmptyException ?? NotEmptyOptions.Default.NotEmptyException;
}
