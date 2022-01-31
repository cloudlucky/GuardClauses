using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Fluent;

public static class RangeExtensions
{
    public static int MustNotBeOutOfRange(this int input, int from, int to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.OutOfRange(input, from, to, message, options, parameterName);

        return input;
    }

    public static T? MustNotBeOutOfRange<T>(this T input, T from, T to, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T>
    {
        Guard.Against.OutOfRange(input, from, to, message, options, parameterName);

        return input;
    }

    public static T? MustNotBeOutOfRange<T>(this T input, ComparableRange<T> range, string? message = default, OutOfRangeOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IComparable<T?>
    {
        Guard.Against.OutOfRange(input, range, message, options, parameterName);

        return input;
    }
}
