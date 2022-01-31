using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

public interface IRange<in T>
{
    bool IsInRange(T value);
}

public readonly record struct ComparableRange<T> : IRange<T>
        where T : IComparable<T>
{
    private readonly int compareFromValue;
    private readonly int compareToValue;

    internal ComparableRange(in RangeValue<T> from, in RangeValue<T> to)
    {
        if (from.Value.CompareTo(to.Value) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        this.From = from;
        this.compareFromValue = from.Inclusive ? 0 : 1;
        this.To = to;
        this.compareToValue = to.Inclusive ? 0 : -1;
    }

    public RangeValue<T> From { get; }
    public RangeValue<T> To { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsInRange(T value)
    {
        return value.CompareTo(this.From.Value) >= this.compareFromValue
            && value.CompareTo(this.To.Value) <= this.compareToValue;
    }
}

public readonly record struct ComparisonRange<T> : IRange<T>
{
    private readonly int compareFromValue;
    private readonly int compareToValue;

    internal ComparisonRange(in RangeValue<T> from, in RangeValue<T> to, Comparison<T> comparison)
    {
        if (comparison(from.Value, to.Value) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        this.From = from;
        this.compareFromValue = from.Inclusive ? 0 : 1;
        this.To = to;
        this.compareToValue = to.Inclusive ? 0 : -1;
        this.Comparison = comparison;
    }

    public RangeValue<T> From { get; }
    public RangeValue<T> To { get; }
    public Comparison<T> Comparison { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsInRange(T value)
    {
        return this.Comparison(value, this.From.Value) >= this.compareFromValue
            && this.Comparison(value, this.To.Value) <= this.compareToValue;
    }
}

public readonly record struct ComparerRange<T> : IRange<T>
{
    private readonly int compareFromValue;
    private readonly int compareToValue;

    internal ComparerRange(in RangeValue<T> from, in RangeValue<T> to, IComparer<T> comparer)
    {
        if (comparer.Compare(from.Value, to.Value) > 0)
        {
            throw new ArgumentException($"{nameof(from)} should be less or equal than {nameof(to)}"); // TODO
        }

        this.From = from;
        this.compareFromValue = from.Inclusive ? 0 : 1;
        this.To = to;
        this.compareToValue = to.Inclusive ? 0 : -1;
        this.Comparer = comparer;
    }

    public RangeValue<T> From { get; }
    public RangeValue<T> To { get; }
    public IComparer<T> Comparer { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsInRange(T value)
    {
        return this.Comparer.Compare(value, this.From.Value) >= this.compareFromValue
            && this.Comparer.Compare(value, this.To.Value) <= this.compareToValue;
    }
}

public readonly record struct RangeValue<T>
{
    internal RangeValue(T value, bool inclusive)
    {
        this.Value = value;
        this.Inclusive = inclusive;
    }

    public T Value { get; }
    public bool Inclusive { get; }
}

public static class Range
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RangeValue<T> From<T>(T value, bool inclusive)
        where T : IComparable<T>
        => new(value, inclusive);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RangeValue<T> FromInclusive<T>(T value)
        where T : IComparable<T>
        => From(value, true);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RangeValue<T> FromExclusive<T>(T value)
        where T : IComparable<T>
        => From(value, false);
}

public static class RangeValueExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparableRange<T> To<T>(in this RangeValue<T> from, T value, bool inclusive)
        where T : IComparable<T>
        => new(from, new(value, inclusive));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparableRange<T> ToInclusive<T>(in this RangeValue<T> from, T value)
        where T : IComparable<T>
        => To(from, value, true);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparableRange<T> ToExclusive<T>(in this RangeValue<T> from, T value)
        where T : IComparable<T>
        => To(from, value, false);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparisonRange<T> To<T>(this RangeValue<T> from, T value, bool includeValue, Comparison<T> comparison)
        => new(from, new(value, includeValue), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparisonRange<T> ToInclusive<T>(this RangeValue<T> from, T value, Comparison<T> comparison)
        => To(from, value, true, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparisonRange<T> ToExclusive<T>(this RangeValue<T> from, T value, Comparison<T> comparison)
        => To(from, value, false, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparerRange<T> To<T>(this RangeValue<T> from, T value, bool includeValue, IComparer<T> comparer)
        => new(from, new(value, includeValue), comparer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparerRange<T> ToInclusive<T>(this RangeValue<T> from, T value, IComparer<T> comparer)
        => To(from, value, true, comparer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComparerRange<T> ToExclusive<T>(this RangeValue<T> from, T value, IComparer<T> comparer)
        => To(from, value, false, comparer);
}
