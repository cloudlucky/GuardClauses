using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, byte input, byte from, byte to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, byte input, byte from, byte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, byte input, byte from, byte to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, short input, short from, short to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, short input, short from, short to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, short input, short from, short to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ushort input, ushort from, ushort to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ushort input, ushort from, ushort to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ushort input, ushort from, ushort to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, int input, int from, int to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, int input, int from, int to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, int input, int from, int to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, uint input, uint from, uint to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, uint input, uint from, uint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, uint input, uint from, uint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nint input, nint from, nint to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nint input, nint from, nint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nint input, nint from, nint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nuint input, nuint from, nuint to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nuint input, nuint from, nuint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nuint input, nuint from, nuint to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, long input, long from, long to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, long input, long from, long to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, long input, long from, long to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ulong input, ulong from, ulong to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ulong input, ulong from, ulong to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ulong input, ulong from, ulong to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, float input, float from, float to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, float input, float from, float to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, float input, float from, float to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, double input, double from, double to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, double input, double from, double to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, double input, double from, double to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, decimal input, decimal from, decimal to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, decimal input, decimal from, decimal to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, decimal input, decimal from, decimal to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsOutOfRange(from, to, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeComparableInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "rangeLimit")] ref GuardAgainstOutOfRangeComparableInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, comparison, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "from", "to", "comparison")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "comparison", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit = default, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, comparer, rangeLimit)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "from", "to", "comparer")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit, [InterpolatedStringHandlerArgument("input", "from", "to", "comparer", "rangeLimit")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, ComparableRange<T> range, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsOutOfRange(range)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, ComparableRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstOutOfRangeComparableInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, ComparisonRange<T> range, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(range)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, byte input, ComparisonRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, ComparerRange<T> range, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(range)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, byte input, ComparerRange<T> range, [InterpolatedStringHandlerArgument("input", "range")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class OutOfRangeOptions
{
    public static OutOfRangeOptions Default { get; set; } = default!;

    public GuardFunc OutOfRangeException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.GuardOnly => new()
            {
                OutOfRangeException = (message, parameterName) => new OutOfRangeException(message, parameterName)
            },
            _ => new()
            {
                OutOfRangeException = (message, parameterName) => new ArgumentOutOfRangeException(GuardMessages.OutOfRange(message), parameterName)
            },
        };
    }
}

public static class OutOfRangeOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetOutOfRangeException(this OutOfRangeOptions? options)
        => options?.OutOfRangeException ?? OutOfRangeOptions.Default.OutOfRangeException;
}
