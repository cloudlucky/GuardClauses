using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this byte input, byte from, byte to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this sbyte input, sbyte from, sbyte to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this short input, short from, short to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this ushort input, ushort from, ushort to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this int input, int from, int to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this uint input, uint from, uint to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this nint input, nint from, nint to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this nuint input, nuint from, nuint to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this long input, long from, long to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this ulong input, ulong from, ulong to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this float input, float from, float to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this double input, double from, double to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this decimal input, decimal from, decimal to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this DateTime input, DateTime from, DateTime to)
        => !IsInRange(input, from, to);

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this DateOnly input, DateOnly from, DateOnly to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this TimeOnly input, TimeOnly from, TimeOnly to)
        => !IsInRange(input, from, to);
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange(this TimeSpan input, TimeSpan from, TimeSpan to)
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to)
        where T : IComparable<T>
        => !IsInRange(input, from, to);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to, Comparison<T> comparison)
        => !IsInRange(input, from, to, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input, T from, T to, IComparer<T> comparer)
        => !IsInRange(input, from, to, comparer);

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
