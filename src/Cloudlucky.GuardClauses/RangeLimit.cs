using System.Runtime.CompilerServices;

namespace Cloudlucky.GuardClauses;

[Flags]
public enum RangeLimit : byte
{
    FromInclusive = 0b_0000,
    FromExclusive = 0b_0001,
    ToInclusive = 0b_0000,
    ToExclusive = 0b_0010,

    FromInclusiveToInclusive = FromInclusive | ToInclusive,
    FromInclusiveToExclusive = FromInclusive | ToExclusive,
    FromExclusiveToInclusive = FromExclusive | ToInclusive,
    FromExclusiveToExclusive = FromExclusive | ToExclusive
}

internal static class RangeLimitExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool FromExclusive(this RangeLimit rangeLimit)
        => (rangeLimit & RangeLimit.FromExclusive) == RangeLimit.FromExclusive;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ToExclusive(this RangeLimit rangeLimit)
        => (rangeLimit & RangeLimit.ToExclusive) == RangeLimit.ToExclusive;
}
