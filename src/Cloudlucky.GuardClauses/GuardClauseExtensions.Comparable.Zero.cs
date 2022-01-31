using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, byte input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, sbyte input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, sbyte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, short input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, ushort input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, ushort input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, int input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, uint input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, uint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, nint input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, nuint input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, nuint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, long input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, ulong input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, ulong input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, float input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, double input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, decimal input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, DateTime input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, DateOnly input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, TimeOnly input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, TimeSpan input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroInterpolatedStringHandler message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsZero()
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstZeroComparableInterpolatedStringHandler<T> message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero(comparison)
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstZeroInterpolatedStringHandler<T> message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsZero(comparer)
         ? throw options.GetZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause Zero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstZeroInterpolatedStringHandler<T> message, ZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsZero
         ? throw options.GetZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, byte input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, sbyte input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, sbyte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, short input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, ushort input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, ushort input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, int input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, uint input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, uint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, nint input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, nuint input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, nuint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, long input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, ulong input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, ulong input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, float input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, double input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, decimal input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, DateTime input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, DateOnly input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, TimeOnly input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, TimeSpan input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroInterpolatedStringHandler message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => !input.IsZero()
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotZeroComparableInterpolatedStringHandler<T> message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero(comparison)
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstNotZeroInterpolatedStringHandler<T> message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsZero(comparer)
         ? throw options.GetNotZeroException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstNotZeroInterpolatedStringHandler<T> message, NotZeroOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotZero
         ? throw options.GetNotZeroException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class ZeroOptions : IGuardOptions
{
    public static ZeroOptions Default { get; set; } = default!;

    public GuardFunc ZeroException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                ZeroException = (message, parameterName) => new ArgumentException(GuardMessages.Zero(message), parameterName)
            },
            _ => new()
            {
                ZeroException = (message, parameterName) => new ZeroException(message, parameterName)
            }
        };
    }
}

public static class ZeroOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetZeroException(this ZeroOptions? options)
        => options?.ZeroException ?? ZeroOptions.Default.ZeroException;
}

public class NotZeroOptions : IGuardOptions
{
    public static NotZeroOptions Default { get; set; } = default!;

    public GuardFunc NotZeroException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotZeroException = (message, parameterName) => new ArgumentException(GuardMessages.NotZero(message), parameterName)
            },
            _ => new()
            {
                NotZeroException = (message, parameterName) => new NotZeroException(message, parameterName)
            }
        };
    }
}

public static class NotZeroOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotZeroException(this NotZeroOptions? options)
        => options?.NotZeroException ?? NotZeroOptions.Default.NotZeroException;
}
