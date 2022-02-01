using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this byte input, byte from, byte to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this short input, short from, short to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this ushort input, ushort from, ushort to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this int input, int from, int to, RangeLimit rangeLimit = default)
            => from > to
             ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
             : (rangeLimit.FromExclusive() ? from < input : from <= input)
               && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this uint input, uint from, uint to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this nint input, nint from, nint to, RangeLimit rangeLimit = default)
            => from > to
             ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
             : (rangeLimit.FromExclusive() ? from < input : from <= input)
               && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this nuint input, nuint from, nuint to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this long input, long from, long to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this ulong input, ulong from, ulong to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this float input, float from, float to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this double input, double from, double to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this decimal input, decimal from, decimal to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit = default)
        => from > to
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? from < input : from <= input)
           && (rangeLimit.ToExclusive() ? input < to : input <= to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to, RangeLimit rangeLimit = default)
        where T : IComparable<T>
        => from.CompareTo(to) > 0
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? input.CompareTo(from) > 0 : input.CompareTo(from) >= 0)
           && (rangeLimit.ToExclusive() ? input.CompareTo(to) < 0 : input.CompareTo(to) <= 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit = default)
        => comparison(from, to) > 0
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? comparison(input, from) > 0 : comparison(input, from) >= 0)
           && (rangeLimit.ToExclusive() ? comparison(input, to) < 0 : comparison(input, to) <= 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit = default)
        => comparer.Compare(from, to) > 0
         ? throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}") // TODO
         : (rangeLimit.FromExclusive() ? comparer.Compare(input, from) > 0 : comparer.Compare(input, from) >= 0)
           && (rangeLimit.ToExclusive() ? comparer.Compare(input, to) < 0 : comparer.Compare(input, to) <= 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>([NotNullWhen(true)] this T input, ComparableRange<T> range)
        where T : IComparable<T>
        => range.IsInRange(input);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>([NotNullWhen(true)] this T input, ComparisonRange<T> range)
        => range.IsInRange(input);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>([NotNullWhen(true)] this T input, ComparerRange<T> range)
        => range.IsInRange(input);
}
