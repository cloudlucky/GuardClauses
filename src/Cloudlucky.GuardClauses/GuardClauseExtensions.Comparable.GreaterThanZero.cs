using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, byte input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, sbyte input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, sbyte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, short input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, ushort input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, ushort input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, int input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, uint input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, uint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, nint input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, nuint input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, nuint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, long input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, ulong input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, ulong input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, float input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, double input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, decimal input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, DateTime input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, DateOnly input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, TimeOnly input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, TimeSpan input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero<T>(this IGuardClause guard, T input, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsGreaterThanZero()
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstGreaterThanZeroComparableInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero(comparison)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanZero(comparer)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstGreaterThanZeroInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanZero
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, byte input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, sbyte input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, sbyte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, short input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, ushort input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, ushort input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, int input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, uint input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, uint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, nint input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, nuint input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, nuint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, long input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, ulong input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, ulong input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, float input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, double input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, decimal input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, DateTime input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, DateOnly input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, TimeOnly input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, TimeSpan input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => !input.IsGreaterThanZero()
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero(comparison)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanZero(comparer)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstNotGreaterThanZeroInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanZero
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}
