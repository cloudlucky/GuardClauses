using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, byte input, byte from, byte to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, byte input, byte from, byte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, byte input, byte from, byte to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, short input, short from, short to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, short input, short from, short to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, short input, short from, short to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ushort input, ushort from, ushort to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ushort input, ushort from, ushort to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ushort input, ushort from, ushort to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, int input, int from, int to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, int input, int from, int to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, int input, int from, int to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, uint input, uint from, uint to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, uint input, uint from, uint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, uint input, uint from, uint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, nint input, nint from, nint to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, nint input, nint from, nint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, nint input, nint from, nint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, nuint input, nuint from, nuint to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, nuint input, nuint from, nuint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, long input, long from, long to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, long input, long from, long to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, long input, long from, long to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ulong input, ulong from, ulong to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ulong input, ulong from, ulong to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, ulong input, ulong from, ulong to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, float input, float from, float to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, float input, float from, float to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, float input, float from, float to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, double input, double from, double to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, double input, double from, double to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, double input, double from, double to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, decimal input, decimal from, decimal to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, decimal input, decimal from, decimal to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, decimal input, decimal from, decimal to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsInRange(from, to, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstInRangeComparableInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstInRangeComparableInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, comparison, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "from", "to", "comparison")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "comparison", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit = default, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(from, to, comparer, rangeLimit)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "from", "to", "comparer")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "comparer", "rangeLimit")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, ComparableRange<T> range, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsInRange(range)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, ComparableRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstInRangeComparableInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, ComparisonRange<T> range, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(range)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, byte input, ComparisonRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, T input, ComparerRange<T> range, string? message = default, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsInRange(range)
         ? throw options.GetInRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause InRange<T>(this IGuardClause guard, byte input, ComparerRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstInRangeInterpolatedStringHandler<T> message, InRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsInRange
         ? throw options.GetInRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class InRangeOptions
{
    public static InRangeOptions Default { get; set; } = default!;

    public GuardFunc InRangeException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                InRangeException = (message, parameterName) => new ArgumentException(GuardMessages.InRange(message), parameterName)
            },
            _ => new()
            {
                InRangeException = (message, parameterName) => new InRangeException(message, parameterName)
            }
        };
    }
}

public static class InRangeOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetInRangeException(this InRangeOptions? options)
        => options?.InRangeException ?? InRangeOptions.Default.InRangeException;
}
