using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, byte input, byte other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, sbyte input, sbyte other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, short input, short other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, ushort input, ushort other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, int input, int other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, uint input, uint other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, nint input, nint other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, nuint input, nuint other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, long input, long other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, ulong input, ulong other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, float input, float other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, double input, double other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, decimal input, decimal other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, DateTime input, DateTime other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanInterpolatedStringHandler message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsGreaterThan(other)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstGreaterThanComparableInterpolatedStringHandler<T> message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other, comparison)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstGreaterThanInterpolatedStringHandler<T> message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsGreaterThan(other, comparer)
         ? throw options.GetGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause GreaterThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstGreaterThanInterpolatedStringHandler<T> message, GreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsGreaterThan
         ? throw options.GetGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, byte input, byte other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, sbyte input, sbyte other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, short input, short other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, ushort input, ushort other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, int input, int other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, uint input, uint other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, nint input, nint other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, nuint input, nuint other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, long input, long other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, ulong input, ulong other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, float input, float other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, double input, double other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, decimal input, decimal other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, DateTime input, DateTime other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => !input.IsGreaterThan(other)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotGreaterThanComparableInterpolatedStringHandler<T> message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other, comparison)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler<T> message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsGreaterThan(other, comparer)
         ? throw options.GetNotGreaterThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotGreaterThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstNotGreaterThanInterpolatedStringHandler<T> message, NotGreaterThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotGreaterThan
         ? throw options.GetNotGreaterThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class GreaterThanOptions : IGuardOptions
{
    public static GreaterThanOptions Default { get; set; } = default!;

    public GuardFunc GreaterThanException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                GreaterThanException = (message, parameterName) => new ArgumentException(GuardMessages.GreaterThan(message), parameterName)
            },
            _ => new()
            {
                GreaterThanException = (message, parameterName) => new GreaterThanException(message, parameterName)
            }
        };
    }
}

public static class GreaterThanOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetGreaterThanException(this GreaterThanOptions? options)
        => options?.GreaterThanException ?? GreaterThanOptions.Default.GreaterThanException;
}

public class NotGreaterThanOptions : IGuardOptions
{
    public static NotGreaterThanOptions Default { get; set; } = default!;

    public GuardFunc NotGreaterThanException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotGreaterThanException = (message, parameterName) => new ArgumentException(GuardMessages.NotGreaterThan(message), parameterName)
            },
            _ => new()
            {
                NotGreaterThanException = (message, parameterName) => new NotGreaterThanException(message, parameterName)
            }
        };
    }
}

public static class NotGreaterThanOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotGreaterThanException(this NotGreaterThanOptions? options)
        => options?.NotGreaterThanException ?? NotGreaterThanOptions.Default.NotGreaterThanException;
}
