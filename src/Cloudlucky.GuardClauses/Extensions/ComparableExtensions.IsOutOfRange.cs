using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this byte input, byte from, byte to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this sbyte input, sbyte from, sbyte to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this short input, short from, short to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this ushort input, ushort from, ushort to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this int input, int from, int to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this uint input, uint from, uint to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this nint input, nint from, nint to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this nuint input, nuint from, nuint to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this long input, long from, long to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this ulong input, ulong from, ulong to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this float input, float from, float to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this double input, double from, double to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this decimal input, decimal from, decimal to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this DateTime input, DateTime from, DateTime to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this DateOnly input, DateOnly from, DateOnly to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this TimeOnly input, TimeOnly from, TimeOnly to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this TimeSpan input, TimeSpan from, TimeSpan to, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to, RangeLimit rangeLimit = default)
        where T : IComparable<T>
        => !IsInRange(input, from, to, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to, Comparison<T> comparison, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, comparison, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to, IComparer<T> comparer, RangeLimit rangeLimit = default)
        => !IsInRange(input, from, to, comparer, rangeLimit);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>([NotNullWhen(true)] this T input, ComparableRange<T> range)
        where T : IComparable<T>
        => !range.IsInRange(input);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>([NotNullWhen(true)] this T input, ComparisonRange<T> range)
        => !range.IsInRange(input);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>([NotNullWhen(true)] this T input, ComparerRange<T> range)
        => !range.IsInRange(input);
}
