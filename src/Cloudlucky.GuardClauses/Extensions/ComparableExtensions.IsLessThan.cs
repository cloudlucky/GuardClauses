using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this byte input, byte other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this sbyte input, sbyte other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this short input, short other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this ushort input, ushort other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this int input, int other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this uint input, uint other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this nint input, nint other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this nuint input, nuint other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this long input, long other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this ulong input, ulong other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this float input, float other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this double input, double other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this decimal input, decimal other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this DateTime input, DateTime other)
        => input < other;

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this DateOnly input, DateOnly other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this TimeOnly input, TimeOnly other)
        => input < other;
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan(this TimeSpan input, TimeSpan other)
        => input < other;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan<T>(this T input, T other)
        where T : IComparable<T>
        => input.CompareTo(other) < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan<T>(this T input, T other, Comparison<T> comparison)
        => comparison(input, other) < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThan<T>(this T input, T other, IComparer<T> comparer)
        => comparer.Compare(input, other) < 0;
}
