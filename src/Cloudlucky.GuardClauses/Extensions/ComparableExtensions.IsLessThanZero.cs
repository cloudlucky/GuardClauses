using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this short input)
        => input < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this int input)
        => input < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this nint input)
        => input < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this long input)
        => input < 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this float input)
        => input < 0.0f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this double input)
        => input < 0.0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero(this decimal input)
        => input < 0.0m;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThan(this TimeSpan input)
        => input < TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero<T>(this T input)
        where T : IComparable<T?>
        => input.CompareTo(default) < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero<T>(this T input, Comparison<T?> comparison)
        => comparison(input, default) < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsLessThanZero<T>(this T input, IComparer<T?> comparer)
        => comparer.Compare(input, default) < 0;
}
