using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this byte input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this sbyte input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this short input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this ushort input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this int input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this uint input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this nint input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this nuint input)
        => input == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this long input)
        => input == 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this ulong input)
        => input == 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this float input)
        => input == 0.0f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this double input)
        => input == 0.0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this decimal input)
        => input == 0.0m;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this Guid input)
        => input == Guid.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this TimeSpan input)
        => input == TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero<T>(this T input)
        where T : IComparable<T?>
        => input.CompareTo(default) == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero<T>(this T input, Comparison<T?> comparison)
        => comparison(input, default) == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero<T>(this T input, IComparer<T?> comparer)
        => comparer.Compare(input, default) == 0;
}
