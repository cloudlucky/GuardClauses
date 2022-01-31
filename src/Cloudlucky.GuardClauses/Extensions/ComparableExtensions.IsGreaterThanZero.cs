﻿using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this byte input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this sbyte input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this short input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this ushort input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this int input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this uint input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this nint input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this nuint input)
        => input > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this long input)
        => input > 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this ulong input)
        => input > 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this float input)
        => input > 0.0f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this double input)
        => input > 0.0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this decimal input)
        => input > 0.0m;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero(this TimeSpan input)
        => input > TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero<T>(this T input)
        where T : IComparable<T?>
        => input.CompareTo(default) > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero<T>(this T input, Comparison<T?> comparison)
        => comparison(input, default) > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsGreaterThanZero<T>(this T input, IComparer<T?> comparer)
        => comparer.Compare(input, default) > 0;
}
