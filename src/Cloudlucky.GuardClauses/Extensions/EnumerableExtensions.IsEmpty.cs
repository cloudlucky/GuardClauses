using System.Collections;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class EnumerableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty(this IEnumerable input)
        => input.TryGetCount(out var count)
         ? count == 0
         : !input.AnyOrDefault();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty<T>(this IEnumerable<T> input)
        => input.TryGetCount(out var count)
         ? count == 0
         : !input.AnyOrDefault();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty<T>(this ICollection<T> input)
        => input.Count == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty<T>(this T[] input)
        => input.Length == 0;
}
