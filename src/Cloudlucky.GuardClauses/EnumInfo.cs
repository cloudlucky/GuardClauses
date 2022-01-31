using Cloudlucky.GuardClauses.Reflection;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

// Special Thanks to Light.GuardClauses

/// <summary>
/// Provides meta-information about enum values and the flag bitmask if the enum is marked with the <see cref="FlagsAttribute" />.
/// Can be used to validate that an enum value is valid.
/// </summary>
/// <typeparam name="T">The type of the enum.</typeparam>
/// <remarks>Special Thanks to <see href="https://github.com/feO2x/Light.GuardClauses">Light.GuardClauses</see> for this implementation</remarks>
public static class EnumInfo<T>
    where T : Enum
{
    private static readonly int EnumSize = Unsafe.SizeOf<T>();
    private static readonly T[] EnumConstantsArray;

    /// <summary>
    /// Gets the value indicating whether the enum type is marked with the flags attribute.
    /// </summary>
    public static bool IsFlagsEnum { get; } = typeof(T).GetCustomAttribute(TypeCache.FlagsAttributeType) != null;

    /// <summary>
    /// Gets the flags pattern when <see cref="IsFlagsEnum"/> is true. If the enum is not a flags enum, then 0UL is returned.
    /// </summary>
    public static ulong FlagsPattern { get; }

    /// <summary>
    /// Gets the underlying type that is used for the enum (<see cref="int" /> for default enums).
    /// </summary>
    public static Type UnderlyingType { get; }

    /// <summary>
    /// Gets the values of the enum as a read-only collection.
    /// </summary>
    public static ReadOnlyMemory<T> EnumConstants { get; }

    static EnumInfo()
    {
        EnumConstantsArray = (T[])Enum.GetValues(typeof(T));
        var fields = typeof(T).GetFields();

        UnderlyingType = fields[0].FieldType;
        EnumConstants = new ReadOnlyMemory<T>(EnumConstantsArray);

        if (!IsFlagsEnum)
        {
            return;
        }

        for (var i = 0; i < EnumConstantsArray.Length; ++i)
        {
            var convertedValue = ConvertToUInt64(EnumConstantsArray[i]);
            FlagsPattern |= convertedValue;
        }
    }

    /// <summary>
    /// Checks if the specified enum value is valid. This is true if either the enum is a standard enum and the enum value corresponds
    /// to one of the enum constant values or if the enum type is marked with the <see cref="FlagsAttribute" /> and the given value
    /// is a valid combination of bits for this type.
    /// </summary>
    /// <param name="enumValue">The enum value to be checked.</param>
    /// <returns>True if either the enum value is </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValidEnumValue(T enumValue) =>
        IsFlagsEnum ? IsValidFlagsValue(enumValue) : IsValidValue(enumValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsValidFlagsValue(T enumValue)
    {
        var convertedValue = ConvertToUInt64(enumValue);
        return (FlagsPattern & convertedValue) == convertedValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsValidValue(T parameter)
    {
        var comparer = EqualityComparer<T>.Default;
        for (var i = 0; i < EnumConstantsArray.Length; ++i)
        {
            if (comparer.Equals(EnumConstantsArray[i], parameter))
            {
                return true;
            }
        }

        return false;
    }

    private static ulong ConvertToUInt64(T value)
        => EnumSize switch
        {
            1 => Unsafe.As<T, byte>(ref value),
            2 => Unsafe.As<T, ushort>(ref value),
            4 => Unsafe.As<T, uint>(ref value),
            8 => Unsafe.As<T, ulong>(ref value),
            _ => throw new InvalidOperationException($"The enum type \"{typeof(T)}\" has an unknown size of {EnumSize}. This means that the underlying enum type is not one of the supported ones."),
        };
}
