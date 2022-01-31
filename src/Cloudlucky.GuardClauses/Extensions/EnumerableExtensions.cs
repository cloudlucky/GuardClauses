using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static partial class EnumerableExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool? TryGetCountInternal(this IEnumerable? input, out int count)
    {
        count = 0;
        return input?.TryGetCount(out count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool? TryGetCountInternal<T>(this IEnumerable<T>? input, out int count)
    {
        count = 0;
        return input?.TryGetCount(out count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool AnyOrDefault(this IEnumerable input)
        => input.GetEnumerator().MoveNext();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool AnyOrDefault<T>(this IEnumerable<T> input)
        => input.Any();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool TryGetCount(this IEnumerable input, out int count)
    {
        if (input is ICollection collection)
        {
            count = collection.Count;

            return true;
        }

        if (input is string @string)
        {
            count = @string.Length;

            return true;
        }

        if (input is Array array)
        {
            count = array.Length;

            return true;
        }

        count = default;

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool TryGetCount<T>(this IEnumerable<T> input, out int count)
    {
        if (input is ICollection collection)
        {
            count = collection.Count;

            return true;
        }

        if (input is ICollection<T> collectionGeneric)
        {
            count = collectionGeneric.Count;

            return true;
        }

        if (input is string @string)
        {
            count = @string.Length;

            return true;
        }

        if (input is Array array)
        {
            count = array.Length;

            return true;
        }

        count = default;

        return false;
    }
}
