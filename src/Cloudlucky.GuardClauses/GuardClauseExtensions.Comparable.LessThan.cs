using Cloudlucky.GuardClauses.Exceptions;
using Cloudlucky.GuardClauses.Extensions;
using Cloudlucky.GuardClauses.Runtime.CompilerServices;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public static partial class GuardClauseExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, byte input, byte other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
         => input.IsLessThan(other)
          ? throw options.GetLessThanException().Invoke(message, parameterName)
          : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, sbyte input, sbyte other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, short input, short other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, ushort input, ushort other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, int input, int other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, uint input, uint other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, nint input, nint other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, nuint input, nuint other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, long input, long other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, ulong input, ulong other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, float input, float other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, double input, double other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, decimal input, decimal other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, DateTime input, DateTime other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanInterpolatedStringHandler message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => input.IsLessThan(other)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstLessThanComparableInterpolatedStringHandler<T> message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other, comparison)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstLessThanInterpolatedStringHandler<T> message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => input.IsLessThan(other, comparer)
         ? throw options.GetLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause LessThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstLessThanInterpolatedStringHandler<T> message, LessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsLessThan
         ? throw options.GetLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, byte input, byte other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, byte input, byte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, sbyte input, sbyte other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, sbyte input, sbyte other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, short input, short other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, short input, short other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, ushort input, ushort other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, ushort input, ushort other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, int input, int other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, int input, int other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, uint input, uint other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, uint input, uint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, nint input, nint other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, nint input, nint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, nuint input, nuint other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, nuint input, nuint other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, long input, long other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, long input, long other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, ulong input, ulong other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, ulong input, ulong other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, float input, float other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, float input, float other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, double input, double other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, double input, double other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, decimal input, decimal other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, decimal input, decimal other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, DateTime input, DateTime other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, DateTime input, DateTime other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, DateOnly input, DateOnly other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, DateOnly input, DateOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, TimeOnly input, TimeOnly other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, TimeOnly input, TimeOnly other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, TimeSpan input, TimeSpan other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan(this IGuardClause guard, TimeSpan input, TimeSpan other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanInterpolatedStringHandler message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => !input.IsLessThan(other)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, [InterpolatedStringHandlerArgument("input", "other")] ref GuardAgainstNotLessThanComparableInterpolatedStringHandler<T> message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other, comparison)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, Comparison<T> comparison, [InterpolatedStringHandlerArgument("input", "other", "comparison")] ref GuardAgainstNotLessThanInterpolatedStringHandler<T> message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, string? message = default, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => !input.IsLessThan(other, comparer)
         ? throw options.GetNotLessThanException().Invoke(message, parameterName)
         : guard;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IGuardClause NotLessThan<T>(this IGuardClause guard, T input, T other, IComparer<T> comparer, [InterpolatedStringHandlerArgument("input", "other", "comparer")] ref GuardAgainstNotLessThanInterpolatedStringHandler<T> message, NotLessThanOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        => message.IsNotLessThan
         ? throw options.GetNotLessThanException().Invoke(message.ToString(), parameterName)
         : guard;
#endif
}

public class LessThanOptions : IGuardOptions
{
    public static LessThanOptions Default { get; set; } = default!;

    public GuardFunc LessThanException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                LessThanException = (message, parameterName) => new ArgumentNullException(GuardMessages.LessThan(message), parameterName)
            },
            _ => new()
            {
                LessThanException = (message, parameterName) => new LessThanException(message, parameterName)
            }
        };
    }
}

public static class LessThanOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetLessThanException(this LessThanOptions? options)
        => options?.LessThanException ?? LessThanOptions.Default.LessThanException;
}

public class NotLessThanOptions : IGuardOptions
{
    public static NotLessThanOptions Default { get; set; } = default!;

    public GuardFunc NotLessThanException { get; set; } = default!;

    internal static void SetDefault(GuardOptionsInitializerConfiguration configuration)
    {
        Default = configuration.Exceptions switch
        {
            GuardExceptionInitializerType.SystemOnly => new()
            {
                NotLessThanException = (message, parameterName) => new ArgumentException(GuardMessages.NotLessThan(message), parameterName)
            },
            _ => new()
            {
                NotLessThanException = (message, parameterName) => new NotLessThanException(message, parameterName)
            }
        };
    }
}

public static class NotLessThanOptionsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static GuardFunc GetNotLessThanException(this NotLessThanOptions? options)
        => options?.NotLessThanException ?? NotLessThanOptions.Default.NotLessThanException;
}
