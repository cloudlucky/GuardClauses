using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this byte input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this sbyte input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this short input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this ushort input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this int input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this uint input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this nint input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this nuint input)
        => input >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this long input)
        => input >= 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this ulong input)
        => input >= 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this float input)
        => input >= 0.0f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this double input)
        => input >= 0.0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this decimal input)
        => input >= 0.0m;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero(this TimeSpan input)
        => input >= TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero<T>(this T input)
        where T : IComparable<T?>
        => input.CompareTo(default) >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero<T>(this T input, Comparison<T?> comparison)
        => comparison(input, default) >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanOrEqualToZero<T>(this T input, IComparer<T?> comparer)
        => comparer.Compare(input, default) >= 0;
}
