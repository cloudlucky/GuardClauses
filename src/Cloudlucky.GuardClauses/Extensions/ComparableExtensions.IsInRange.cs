using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class ComparableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this byte input, byte from, byte to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this sbyte input, sbyte from, sbyte to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this short input, short from, short to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this ushort input, ushort from, ushort to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this int input, int from, int to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this uint input, uint from, uint to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this nint input, nint from, nint to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this nuint input, nuint from, nuint to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this long input, long from, long to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this ulong input, ulong from, ulong to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this float input, float from, float to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this double input, double from, double to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this decimal input, decimal from, decimal to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this DateTime input, DateTime from, DateTime to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

#if NET6_0_OR_GREATER
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this DateOnly input, DateOnly from, DateOnly to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this TimeOnly input, TimeOnly from, TimeOnly to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange(this TimeSpan input, TimeSpan from, TimeSpan to)
    {
        if (from > to)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return from <= input && input <= to;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to)
        where T : IComparable<T>
    {
        if (from.CompareTo(to) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return input.CompareTo(from) >= 0 && input.CompareTo(to) <= 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to, Comparison<T> comparison)
    {
        if (comparison(from, to) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return comparison(input, from) >= 0 && comparison(input, to) <= 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input, T from, T to, IComparer<T> comparer)
    {
        if (comparer.Compare(from, to) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        return comparer.Compare(input, from) >= 0 && comparer.Compare(input, to) <= 0;
    }

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
