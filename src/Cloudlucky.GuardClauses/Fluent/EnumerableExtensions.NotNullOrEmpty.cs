using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Fluent;

public static class EnumerableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T MustNotBeNullOrEmpty<T>([NotNull] this T? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IEnumerable
    {
        Guard.Against.NullOrEmpty(input, message, options, parameterName);

        return input;
    }

    // TODO Only the previous method is detected
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? MustNotBeNullOrEmpty<T, TItems>([NotNull] this T? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
        where T : IEnumerable<TItems>
    {
        Guard.Against.NullOrEmpty(input, message, options, parameterName);

        return input;
    }
}
