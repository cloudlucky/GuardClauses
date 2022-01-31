using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, byte input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, short input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, int input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, nint input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, long input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, float input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, double input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, decimal input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, DateTime input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, DateOnly input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, TimeOnly input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, TimeSpan input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualToZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsLessThanOrEqualToZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanOrEqualToZeroComparableInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero(comparison)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualToZero(comparer)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstLessThanOrEqualToZeroInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualToZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, byte input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, short input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, int input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, nint input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, long input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, float input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, double input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, decimal input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, DateTime input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, DateOnly input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, TimeOnly input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, TimeSpan input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualToZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => !input.IsLessThanOrEqualToZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToComparableInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero(comparison)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualToZero(comparer)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstNotLessThanOrEqualToZeroInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualToZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}
