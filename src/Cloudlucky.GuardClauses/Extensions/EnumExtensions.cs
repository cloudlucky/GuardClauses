using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses.Extensions;

public static class EnumExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsInRange<T>(this T input) 
        where T : Enum
        => EnumInfo<T>.IsValidEnumValue(input);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOutOfRange<T>(this T input)
        where T : Enum
        => !EnumInfo<T>.IsValidEnumValue(input);
}
