using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static class ObjectExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsDefault<T>([NotNullWhen(false)] this T? input)
        => EqualityComparer<T?>.Default.Equals(input, default);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsDefault<T>([NotNullWhen(false)] this T? input, T defaultValue)
        => EqualityComparer<T?>.Default.Equals(input, defaultValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNull<T>([NotNullWhen(false)] this T? input)
        => input is null;
}
