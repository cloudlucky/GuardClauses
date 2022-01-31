using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, byte input, byte other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, short input, short other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, int input, int other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, uint input, uint other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, nint input, nint other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, long input, long other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, float input, float other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, double input, double other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsLessThanOrEqualTo(other)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanOrEqualToComparableInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other, comparison)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThanOrEqualTo(other, comparer)
         ? throw options.GetLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstLessThanOrEqualToInterpolatedStringHandler<T> message, LessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThanOrEqualTo
         ? throw options.GetLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, byte input, byte other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, short input, short other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, int input, int other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, uint input, uint other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, nint input, nint other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, long input, long other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, float input, float other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, double input, double other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => !input.IsLessThanOrEqualTo(other)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanOrEqualToComparableInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other, comparison)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThanOrEqualTo(other, comparer)
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThanOrEqualTo<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstNotLessThanOrEqualToInterpolatedStringHandler<T> message, NotLessThanOrEqualToOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThanOrEqualTo
         ? throw options.GetNotLessThanOrEqualToException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class LessThanOrEqualToOptions : IGuardOptions
{
    public static LessThanOrEqualToOptions Default { get; set; } = default!;

    public GuardFunc LessThanOrEqualToException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                LessThanOrEqualToException = (message, parameterName) => new ArgumentException(GuardMessages.LessThanOrEqualTo(message), parameterName)
            },
            _ => new()
            {
                LessThanOrEqualToException = (message, parameterName) => new LessThanOrEqualToException(message, parameterName)
            }
        };
    }
}

public static class LessThanOrEqualToOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetLessThanOrEqualToException(this LessThanOrEqualToOptions? options)
        => options?.LessThanOrEqualToException ?? LessThanOrEqualToOptions.Default.LessThanOrEqualToException;
}

public class NotLessThanOrEqualToOptions : IGuardOptions
{
    public static NotLessThanOrEqualToOptions Default { get; set; } = default!;

    public GuardFunc NotLessThanOrEqualToException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotLessThanOrEqualToException = (message, parameterName) => new ArgumentException(GuardMessages.NotLessThanOrEqualTo(message), parameterName)
            },
            _ => new()
            {
                NotLessThanOrEqualToException = (message, parameterName) => new NotLessThanOrEqualToException(message, parameterName)
            }
        };
    }
}

public static class NotLessThanOrEqualToOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotLessThanOrEqualToException(this NotLessThanOrEqualToOptions? options)
        => options?.NotLessThanOrEqualToException ?? NotLessThanOrEqualToOptions.Default.NotLessThanOrEqualToException;
}
