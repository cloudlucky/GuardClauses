using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, byte input, byte from, byte to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, byte input, byte from, byte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, sbyte input, sbyte from, sbyte to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, short input, short from, short to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, short input, short from, short to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ushort input, ushort from, ushort to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ushort input, ushort from, ushort to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, int input, int from, int to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, int input, int from, int to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, uint input, uint from, uint to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, uint input, uint from, uint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nint input, nint from, nint to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nint input, nint from, nint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nuint input, nuint from, nuint to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, nuint input, nuint from, nuint to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, long input, long from, long to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, long input, long from, long to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ulong input, ulong from, ulong to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, ulong input, ulong from, ulong to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, float input, float from, float to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, float input, float from, float to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, double input, double from, double to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, double input, double from, double to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, decimal input, decimal from, decimal to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, decimal input, decimal from, decimal to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateTime input, DateTime from, DateTime to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, DateOnly input, DateOnly from, DateOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeOnly input, TimeOnly from, TimeOnly to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange(this IGuardClause guard, TimeSpan input, TimeSpan from, TimeSpan to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeInterpolatedStringHandler message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsOutOfRange(from, to)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, [InterpolatedStringHandlerArgument("input", "from", "to")] ref GuardAgainstOutOfRangeComparableInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, comparison)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "from", "to", "comparison")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsOutOfRange
         ? throw options.GetOutOfRangeException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsOutOfRange(from, to, comparer)
         ? throw options.GetOutOfRangeException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause OutOfRange<T>(this IGuardClause guard, T input, T from, T to, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "from", "to", "comparer")] ref GuardAgainstOutOfRangeInterpolatedStringHandler<T> message, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
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
            GuardExceptionInitializerType.SystemOnly => new()
            {
                OutOfRangeException = (message, parameterName) => new ArgumentOutOfRangeException(GuardMessages.OutOfRange(message), parameterName)
            },
            _ => new()
            {
                OutOfRangeException = (message, parameterName) => new OutOfRangeException(message, parameterName)
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
