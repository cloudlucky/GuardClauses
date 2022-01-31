using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Fluent;

public static class StringExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string MustNotBeNullOrEmpty([NotNull] this string? input, string? message = default, NullOrEmptyOptions? options = default, [CallerArgumentExpression("input")] string? parameterName = default)
    {
        Guard.Against.NullOrEmpty(input, message, options, parameterName);

        return input;
    }
}
