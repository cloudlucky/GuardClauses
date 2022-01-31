using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, byte input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, short input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, int input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, nint input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, long input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, float input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, double input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, decimal input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, DateTime input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, DateOnly input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, TimeOnly input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, TimeSpan input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero<T>(this IGuardClause guard, T input, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => input.IsLessThanZero()
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstLessThanZeroComparableInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero(comparison)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstLessThanZeroInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanZero(comparer)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstLessThanZeroInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanZero
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, byte input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, byte input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, short input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, short input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, int input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, int input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, nint input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, nint input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, long input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, long input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, float input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, float input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, double input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, double input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, decimal input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, decimal input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, DateTime input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, DateTime input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, DateOnly input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, DateOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, TimeOnly input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, TimeOnly input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, TimeSpan input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero(this IGuardClause guard, TimeSpan input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => !input.IsLessThanZero()
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, [InterpolatedStringHandlerArgument("input")] ref GuardAgainstNotLessThanOrEqualToComparableInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero(comparison)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, Comparison<T?> comparison, [InterpolatedStringHandlerArgument("input", "comparison")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanZero(comparer)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanZero<T>(this IGuardClause guard, T input, IComparer<T?> comparer, [InterpolatedStringHandlerArgument("input", "comparer")] ref GuardAgainstNotLessThanZeroInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanZero
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}
