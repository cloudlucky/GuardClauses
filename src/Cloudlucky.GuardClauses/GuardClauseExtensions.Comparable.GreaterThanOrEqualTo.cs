using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, byte input, byte other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, short input, short other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, int input, int other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, uint input, uint other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, nint input, nint other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, long input, long other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, float input, float other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, double input, double other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanOrEqualToComparableInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other, comparison)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThanOrEqualTo(other, comparer)
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstGreaterThanOrEqualToInterpolatedStringHandler<T> message, GreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThanOrEqualTo
         ? throw options.GetGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, byte input, byte other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, short input, short other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, int input, int other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, uint input, uint other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, nint input, nint other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, long input, long other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, float input, float other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, double input, double other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => !input.IsGreaterThanOrEqualTo(other)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanOrEqualToComparableInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other, comparison)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThanOrEqualTo(other, comparer)
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstNotGreaterThanOrEqualToInterpolatedStringHandler<T> message, NotGreaterThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThanOrEqualTo
         ? throw options.GetNotGreaterThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class GreaterThanOrEqualToOptions : IGuardOptions
{
    public static GreaterThanOrEqualToOptions Default { get; set; } = default!;

    public GuardFunc GreaterThanOrEqualToException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                GreaterThanOrEqualToException = (message, parameterName) => new ArgumentException(GuardMessages.GreaterThanOrEqualTo(message), parameterName)
            },
            _ => new()
            {
                GreaterThanOrEqualToException = (message, parameterName) => new GreaterThanOrEqualToException(message, parameterName)
            }
        };
    }
}

public static class GreaterThanOrEqualToOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetGreaterThanOrEqualToException(this GreaterThanOrEqualToOptions? options)
        => options?.GreaterThanOrEqualToException ?? GreaterThanOrEqualToOptions.Default.GreaterThanOrEqualToException;
}

public class NotGreaterThanOrEqualToOptions : IGuardOptions
{
    public static NotGreaterThanOrEqualToOptions Default { get; set; } = default!;

    public GuardFunc NotGreaterThanOrEqualToException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotGreaterThanOrEqualToException = (message, parameterName) => new ArgumentException(GuardMessages.NotGreaterThanOrEqualTo(message), parameterName)
            },
            _ => new()
            {
                NotGreaterThanOrEqualToException = (message, parameterName) => new NotGreaterThanOrEqualToException(message, parameterName)
            }
        };
    }
}

public static class NotGreaterThanOrEqualToOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotGreaterThanOrEqualToException(this NotGreaterThanOrEqualToOptions? options)
        => options?.NotGreaterThanOrEqualToException ?? NotGreaterThanOrEqualToOptions.Default.NotGreaterThanOrEqualToException;
}
